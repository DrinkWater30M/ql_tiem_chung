using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class DonDKTiemDAO : DAO
    {
        public bool addInjectionRegister(DonDKTiemDTO injectionRegisterDTO)
        {
            try
            {
                string queryInsertDichVu =
                    "insert into dich_vu(diachi_ndk, gioitinh_ndk, sdt_ndk, ngaysinh_ndk, ngaydk, khdv) value "
                    + "('" + injectionRegisterDTO.diachi_ndk + "', '" + injectionRegisterDTO.gioitinh_ndk + "', '"
                    + injectionRegisterDTO.sdt_ndk + "', '" + injectionRegisterDTO.ngaysinh_ndk + "', '"
                    + injectionRegisterDTO.ngaydk + "', " + injectionRegisterDTO.khdv + ");";

                long madv = queryInsert(queryInsertDichVu);

                string queryInsertDonDKTiem =
                    "insert into don_dk_tiem(madktiem, tennguoitiem, ngaymuontiem, magoidk, gia) value "
                    + "(" + madv + ", '" + injectionRegisterDTO.tennguoitiem + "', '" + injectionRegisterDTO.ngaymuontiem
                    + "', " + injectionRegisterDTO.magoidk + ", " + injectionRegisterDTO.gia + ");";

                query(queryInsertDonDKTiem);
                
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<DonDKTiemDTO> getListInjection(int id, int idBill)
        {
            List<DonDKTiemDTO> list = new List<DonDKTiemDTO>();
            try
            {
                string queryListOrder =
                    "select * from dich_vu join don_dk_tiem on dich_vu.madv = don_dk_tiem.madktiem " +
                    "where dich_vu.khdv = " + id + " and dich_vu.hddv is null;";

                if(idBill != 0)
                {
                    queryListOrder =
                    "select * from dich_vu join don_dk_tiem on dich_vu.madv = don_dk_tiem.madktiem " +
                    "where dich_vu.hddv = " + idBill + ";";
                }

                DataTable data = query(queryListOrder);

                foreach (DataRow item in data.Rows)
                {
                    DonDKTiemDTO donDKTiemDTO = new DonDKTiemDTO();
                    donDKTiemDTO.diachi_ndk = item["diachi_ndk"].ToString();
                    donDKTiemDTO.gia = Int32.Parse(item["gia"].ToString());
                    donDKTiemDTO.gioitinh_ndk = item["gioitinh_ndk"].ToString();
                    donDKTiemDTO.khdv = Int32.Parse(item["khdv"].ToString());
                    donDKTiemDTO.madv = Int32.Parse(item["madv"].ToString());
                    donDKTiemDTO.ngaydk = DateTime.Parse(item["ngaydk"].ToString()).ToString("dd/MM/yyyy");
                    donDKTiemDTO.ngaysinh_ndk = item["ngaysinh_ndk"].ToString();
                    donDKTiemDTO.sdt_ndk = item["sdt_ndk"].ToString();
                    donDKTiemDTO.tennguoitiem = item["tennguoitiem"].ToString();


                    list.Add(donDKTiemDTO);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }

        public List<BenhNhanDTO> getListPatient(string type)
        {
            List<BenhNhanDTO> list = new List<BenhNhanDTO>();
            try
            {
                string queryPatient = "";
                if (type == "EXAMINATION") {
                    queryPatient =
                    "select * from don_dk_tiem " +
                    "join dich_vu on don_dk_tiem.madktiem = dich_vu.madv " +
                    "join tien_trinh_tiem on don_dk_tiem.madktiem = tien_trinh_tiem.madktiem " +
                    "join kham on tien_trinh_tiem.matt = kham.mattkham " +
                    "where kham.bskham is null;";
                }
                else if (type == "INJECTION")
                {
                    queryPatient =
                   "select * from don_dk_tiem " +
                   "join dich_vu on don_dk_tiem.madktiem = dich_vu.madv " +
                   "join tien_trinh_tiem on don_dk_tiem.madktiem = tien_trinh_tiem.madktiem " +
                   "join tiem on tien_trinh_tiem.matt = tiem.matttiem " +
                   "where tiem.ysitiem is null;";
                }
                else
                {

                }

                    DataTable data = query(queryPatient);
                foreach (DataRow item in data.Rows)
                {
                    BenhNhanDTO benhNhanDTO = new BenhNhanDTO();
                    benhNhanDTO.matt = Int32.Parse(item["matt"].ToString());
                    benhNhanDTO.hoten = item["tennguoitiem"].ToString();
                    benhNhanDTO.gioitinh = item["gioitinh_ndk"].ToString();
                    benhNhanDTO.ngaysinh = item["ngaysinh_ndk"].ToString();
                    benhNhanDTO.sdt = item["sdt_ndk"].ToString();
                    benhNhanDTO.benhnen = "Không";


                    list.Add(benhNhanDTO);
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
