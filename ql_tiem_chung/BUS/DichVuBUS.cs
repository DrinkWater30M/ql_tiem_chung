using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DAO;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.BUS
{
    public class DichVuBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        DonDKMuaDAO donDKMuaDAO = new DonDKMuaDAO();
        DonDKTiemDAO donDKTiemDAO = new DonDKTiemDAO();
        public List<DichVuDTO> getListServices(string username, int idBill = 0)
        {
            //Get user info
            KhachHangDTO user = khachHangDAO.getUserInfo(username);

            //Get list order
            List<DonDKMuaDTO> listOrder = donDKMuaDAO.getListOrder(user.makh, idBill);

            //Get list injection
            List<DonDKTiemDTO> listInjection = donDKTiemDAO.getListInjection(user.makh, idBill);

            //
            List<DichVuDTO> list = new List<DichVuDTO>();
            foreach(DonDKMuaDTO item in listOrder)
            {
                DichVuDTO dichVuDTO = new DichVuDTO();
                dichVuDTO.madv = item.madv;
                dichVuDTO.ten_dk = item.tennguoidat;
                dichVuDTO.ngaydk = item.ngaydk;
                dichVuDTO.gia = item.dongia * item.soluong;
                dichVuDTO.sdt = item.sdt_ndk;
                dichVuDTO.loai_dv = "Đơn Mua";

                list.Add(dichVuDTO);
            }

            //
            foreach (DonDKTiemDTO item in listInjection)
            {
                DichVuDTO dichVuDTO = new DichVuDTO();
                dichVuDTO.madv = item.madv;
                dichVuDTO.ten_dk = item.tennguoitiem;
                dichVuDTO.ngaydk = item.ngaydk;
                dichVuDTO.gia = item.gia;
                dichVuDTO.sdt = item.sdt_ndk;
                dichVuDTO.loai_dv = "Đơn Tiêm";

                list.Add(dichVuDTO);
            }

            return list;
        }
    }
}
