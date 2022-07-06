using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_tiem_chung.DAO
{
    public class TienTrinhDAO:DAO
    {
        public bool updateExaminationProcess(int idProcess, string stateExamination, int idDoctor)
        {
            try
            {
                if (stateExamination != "Chưa Khám") {
                    string queryUpdateExaminationProcess =
                        "update kham set kham.trangthai = '" + stateExamination + "', kham.bskham = " + idDoctor +
                        " where kham.mattkham = " + idProcess + ";";

                    query(queryUpdateExaminationProcess);

                    if (stateExamination == "Đạt")
                    {
                        string insertInjectionProcess =
                            "insert into tiem(matttiem, trangthai) value (" + idProcess + ", 'Chưa Tiêm');";
                        queryInsert(insertInjectionProcess);
                    }
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool updateInjectionProcess(int idProcess, string stateInjection, int idDoctor)
        {
            try
            {
                if (stateInjection != "Chưa Tiêm")
                {
                    string queryUpdateInjectionProcess =
                        "update tiem set tiem.trangthai = '" + stateInjection + "', tiem.ysitiem = " + idDoctor +
                        " where tiem.matttiem = " + idProcess + ";";

                    query(queryUpdateInjectionProcess);

                    string insertInjectionProcess =
                        "insert into theo_doi(matttd, trangthai) value (" + idProcess + ", 'Đã Tiêm');";
                    queryInsert(insertInjectionProcess);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
