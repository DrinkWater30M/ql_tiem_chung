using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DAO;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.BUS
{
    public class TienTrinhBUS
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        TienTrinhDAO tienTrinhDAO = new TienTrinhDAO();
        public bool updateExaminationProcess(int idProcess, string stateExamination, string usernameDoctor)
        {
            NhanVienDTO nhanVienDTO = nhanVienDAO.getStaffInfo(usernameDoctor);
            return tienTrinhDAO.updateExaminationProcess(idProcess, stateExamination, nhanVienDTO.manv);
        }

        public bool updateInjectionProcess(int idProcess, string stateInjection, string usernameDoctor)
        {
            NhanVienDTO nhanVienDTO = nhanVienDAO.getStaffInfo(usernameDoctor);
            return tienTrinhDAO.updateInjectionProcess(idProcess, stateInjection, nhanVienDTO.manv);
        }
    }
}
