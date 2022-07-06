using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;
using ql_tiem_chung.DAO;

namespace ql_tiem_chung.BUS
{
    public class DonDKTiemBUS
    {
        KhachHangDAO customer = new KhachHangDAO();
        DonDKTiemDAO injectionForm = new DonDKTiemDAO();
        public int validateInput(DonDKTiemDTO injectionRegisterDTO)
        {
            //validate input here
            if(injectionRegisterDTO.tennguoitiem == "" || injectionRegisterDTO.gioitinh_ndk == "" ||
                injectionRegisterDTO.sdt_ndk == "" || injectionRegisterDTO.diachi_ndk == "" ||
                injectionRegisterDTO.magoidk == 0)
            {
                return 1;
            }

            return 0;
        }

        public bool addInjectionRegister(DonDKTiemDTO injectionRegisterDTO, string username) 
        {
            KhachHangDTO dbCustomer = customer.getUserInfo(username);
            GoiTiemDAO goiTiemDAO = new GoiTiemDAO();
            GoiTiemDTO goiTiemDTO = goiTiemDAO.getInjectionPackage(injectionRegisterDTO.magoidk);
            injectionRegisterDTO.khdv = dbCustomer.makh;
            injectionRegisterDTO.ngaydk = DateTime.Today.ToString("yyyyMMdd");
            injectionRegisterDTO.gia = goiTiemDTO.gia;

            return injectionForm.addInjectionRegister(injectionRegisterDTO);
        }

        public List<BenhNhanDTO> getListPatient(string type)
        {
            List<BenhNhanDTO> list = injectionForm.getListPatient(type);
            return list;
        }
    }
}
