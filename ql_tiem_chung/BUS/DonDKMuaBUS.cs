using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DAO;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.BUS
{
    public class DonDKMuaBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        VaccineDAO vaccineDAO = new VaccineDAO();
        DonDKMuaDAO donDKMuaDAO = new DonDKMuaDAO();
        public int validateInput(DonDKMuaDTO donDKMuaDTO)
        {
            //validate each input here
            if (donDKMuaDTO.tennguoidat == "" || donDKMuaDTO.gioitinh_ndk == ""
                || donDKMuaDTO.sdt_ndk == "" || donDKMuaDTO.vaccine == ""
                || donDKMuaDTO.diachi_ndk == "")
            {
                return 1;
            }

            //pass
            return 0;
        }

        public bool addOrderVaccine(DonDKMuaDTO donDKMuaDTO, string username)
        {
            KhachHangDTO dbCustomer = khachHangDAO.getUserInfo(username);
            VaccineDTO dbVaccine = vaccineDAO.getVaccine(donDKMuaDTO.vaccine);
            donDKMuaDTO.khdv = dbCustomer.makh;
            donDKMuaDTO.ngaydk = DateTime.Today.ToString("yyyyMMdd");
            donDKMuaDTO.dongia = dbVaccine.gia;

            return donDKMuaDAO.addOrderVaccine(donDKMuaDTO);
        }

    }
}
