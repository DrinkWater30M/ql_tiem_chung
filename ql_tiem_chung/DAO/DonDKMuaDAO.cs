using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class DonDKMuaDAO : DAO
    {
        public bool addOrderVaccine(DonDKMuaDTO donDKMuaDTO)
        {
            try
            {
                string queryInsertDichVu =
                        "insert into dich_vu(diachi_ndk, gioitinh_ndk, sdt_ndk, ngaysinh_ndk, ngaydk, khdv) value "
                        + "('" + donDKMuaDTO.diachi_ndk + "', '" + donDKMuaDTO.gioitinh_ndk + "', '"
                        + donDKMuaDTO.sdt_ndk + "', '" + donDKMuaDTO.ngaysinh_ndk + "', '"
                        + donDKMuaDTO.ngaydk + "', " + donDKMuaDTO.khdv + ");";

                long id = queryInsert(queryInsertDichVu);

                string queryInsertDonDatMua =
                    "insert into don_dat_mua(madatmua, tennguoidat) value "
                    + "(" + id + ", '" + donDKMuaDTO.tennguoidat + "');";
                query(queryInsertDonDatMua);

                string queryInsertCTDatMua =
                    "insert into ct_dat_mua(datmua, vaccine, soluong, dongia) value "
                    + "(" + id + ", '" + donDKMuaDTO.vaccine + "', " + donDKMuaDTO.soluong
                    + ", " + donDKMuaDTO.dongia + ");";
                query(queryInsertCTDatMua);

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<DonDKMuaDTO> getListOrder(int id, int idBill)
        {
            List<DonDKMuaDTO> list = new List<DonDKMuaDTO>();
            try
            {
                string queryListOrder =
                    "select * from dich_vu join don_dat_mua on dich_vu.madv = don_dat_mua.madatmua " +
                    "join ct_dat_mua on don_dat_mua.madatmua = ct_dat_mua.datmua " +
                    "where dich_vu.khdv = " + id + " and dich_vu.hddv is null;";

                if(idBill != 0)
                {
                    queryListOrder =
                    "select * from dich_vu join don_dat_mua on dich_vu.madv = don_dat_mua.madatmua " +
                    "join ct_dat_mua on don_dat_mua.madatmua = ct_dat_mua.datmua " +
                    "where dich_vu.hddv = " + idBill + ";";
                }

                DataTable data = query(queryListOrder);

                foreach (DataRow item in data.Rows)
                {
                    DonDKMuaDTO donDKMuaDTO = new DonDKMuaDTO();
                    donDKMuaDTO.diachi_ndk = item["diachi_ndk"].ToString();
                    donDKMuaDTO.dongia = Int32.Parse(item["dongia"].ToString());
                    donDKMuaDTO.gioitinh_ndk = item["gioitinh_ndk"].ToString();
                    donDKMuaDTO.khdv = Int32.Parse(item["khdv"].ToString());
                    donDKMuaDTO.madv = Int32.Parse(item["madv"].ToString());
                    donDKMuaDTO.ngaydk = DateTime.Parse(item["ngaydk"].ToString()).ToString("dd/MM/yyyy");
                    donDKMuaDTO.ngaysinh_ndk = item["ngaysinh_ndk"].ToString();
                    donDKMuaDTO.sdt_ndk = item["sdt_ndk"].ToString();
                    donDKMuaDTO.soluong = Int32.Parse(item["soluong"].ToString());
                    donDKMuaDTO.tennguoidat = item["tennguoidat"].ToString();

                    list.Add(donDKMuaDTO);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }
    }
}
