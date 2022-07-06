using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class HoaDonDAO : DAO
    {
        public bool updateCheckout(int idUser, int totallBill, List<int> listId)
        {
            try
            {
                string queryInsertBill =
                    "insert hoa_don(tongtien, trangthaithanhtoan) value " +
                    "(" + totallBill + ", 'Chưa Thanh Toán')";

                long idBill = queryInsert(queryInsertBill);

                foreach(int id in listId)
                {
                    query("update dich_vu set dich_vu.hddv = " + idBill +
                        " where dich_vu.madv = " + id + ";");
                }

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<HoaDonDTO> getListBill(string type, int idUser, int idStaff)
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            try
            {
                string queryBill = "";
                
                if(type == "ALL")
                {
                    if (idUser == 0)
                    {
                        queryBill = "select * from hoa_don;";
                    }
                    else
                    {
                        queryBill =
                            "select * from hoa_don join dich_vu on hoa_don.mahd = dich_vu.hddv " + 
                            "group by hoa_don.mahd " + 
                            "having dich_vu.khdv = " + idUser + ";";
                    }
                }

                if(type == "PAID")
                {
                 
                    if (idUser == 0)
                    {
                        queryBill = "select * from hoa_don where hoa_don.nvlap is not null;";
                    }
                    else
                    {
                        queryBill =
                            "select * from hoa_don join dich_vu on hoa_don.mahd = dich_vu.hddv " +
                            "where hoa_don.nvlap is not null " +
                            "group by hoa_don.mahd " +
                            "having dich_vu.khdv = " + idUser + ";";
                    }

                    if(idStaff != 0){
                        queryBill = "select * from hoa_don where hoa_don.nvlap = " + idStaff + ";";
                    }
                }

                if(type == "UNPAID")
                {
                    if (idUser == 0)
                    {
                        queryBill = "select * from hoa_don where hoa_don.nvlap is null;";
                    }
                    else
                    {
                        queryBill =
                            "select * from hoa_don join dich_vu on hoa_don.mahd = dich_vu.hddv " +
                            "where hoa_don.nvlap is null " +
                            "group by hoa_don.mahd " +
                            "having dich_vu.khdv = " + idUser + ";";
                    }
                }

                DataTable data = query(queryBill);

                foreach(DataRow item in data.Rows)
                {
                    HoaDonDTO hoaDonDTO = new HoaDonDTO();
                    hoaDonDTO.mahd = Int32.Parse(item["mahd"].ToString());
                    hoaDonDTO.tongtien = Int32.Parse(item["tongtien"].ToString());
                    hoaDonDTO.trangthaithanhtoan = item["trangthaithanhtoan"].ToString();

                    list.Add(hoaDonDTO);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }

        public bool updateBill(int idBill, int idAccountant)
        {
            try
            {
                string queryUpdateBill =
                    "update hoa_don " +
                    "set hoa_don.nvlap = " + idAccountant + ", hoa_don.trangthaithanhtoan = 'Đã Thanh Toán' " +
                    "where hoa_don.mahd = " + idBill + ";";

                query(queryUpdateBill);

                //create injection process
                string queryListInjection =
                    "select don_dk_tiem.madktiem from don_dk_tiem left join dich_vu " +
                    "on don_dk_tiem.madktiem = dich_vu.madv join hoa_don " +
                    "on dich_vu.hddv = hoa_don.mahd " +
                    "where hoa_don.mahd = " + idBill + " and hoa_don.nvlap is not null;";

                DataTable listIdInjection = query(queryListInjection);
                List<int> listId = new List<int>();
                foreach(DataRow item in listIdInjection.Rows)
                {
                    listId.Add(Int32.Parse(item["madktiem"].ToString()));
                }

                foreach(int id in listId)
                {

                    string queryInsertInjectionProcess =
                        "insert into tien_trinh_tiem(madktiem) value (" + id + ");";
                    long idProcess = queryInsert(queryInsertInjectionProcess);

                    string queryInsertExaminationProcess =
                        "insert into kham(mattkham, trangthai) value (" + idProcess + ", 'Chưa Khám');";
                    queryInsert(queryInsertExaminationProcess);
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

    }
}
