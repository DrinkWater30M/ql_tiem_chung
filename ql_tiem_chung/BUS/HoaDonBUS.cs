using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DAO;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.BUS
{
    public class HoaDonBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public bool updateCheckout(string username, int totalBill, List<int> listId)
        {
            KhachHangDTO khachHangDTO = khachHangDAO.getUserInfo(username);
            return hoaDonDAO.updateCheckout(khachHangDTO.makh, totalBill, listId);
        }

        public List<HoaDonDTO> getListBill(string type, string username = "", string usernameStaff = "")
        {
            int idUser = 0;
            int idStaff = 0;
            if (username != "")
            {
                KhachHangDTO khachHangDTO = khachHangDAO.getUserInfo(username);
                idUser = khachHangDTO.makh;
            }

            if (usernameStaff != "")
            {
                NhanVienDTO nhanVienDTO = nhanVienDAO.getStaffInfo(usernameStaff);
                idStaff = nhanVienDTO.manv;
            }

            List<HoaDonDTO> list = hoaDonDAO.getListBill(type, idUser, idStaff);
            return list;
        }

        public bool updateBill(int idBill, string username)
        {
            NhanVienDTO staffInfo = nhanVienDAO.getStaffInfo(username);
            return hoaDonDAO.updateBill(idBill, staffInfo.manv);
        }
    }
}
