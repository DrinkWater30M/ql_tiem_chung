using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class ThongTinGoiTiemDAO : DAO
    {
        public List<ThongTinGoiTiemDTO> getListInjectionPackageInfo()
        {
            List<ThongTinGoiTiemDTO> listInjectionPackageInfo = new List<ThongTinGoiTiemDTO>();
            string queryListInJectionPackageInfo = "select * from goi_tiem left join vaccine on goi_tiem.vaccine = vaccine.mavaccine";

            DataTable data = query(queryListInJectionPackageInfo);

            foreach(DataRow item in data.Rows)
            {
                ThongTinGoiTiemDTO injectionPackageInfoDTO = new ThongTinGoiTiemDTO();
                injectionPackageInfoDTO.magoi = Int32.Parse(item["magoi"].ToString());
                injectionPackageInfoDTO.tenvaccine = item["tenvaccine"].ToString();
                injectionPackageInfoDTO.mavaccine = item["mavaccine"].ToString();
                injectionPackageInfoDTO.gia = Int32.Parse(item["gia"].ToString());
                injectionPackageInfoDTO.hsd = item["hsd"].ToString();
                injectionPackageInfoDTO.doituong = item["doituong"].ToString();

                listInjectionPackageInfo.Add(injectionPackageInfoDTO);
            }

            return listInjectionPackageInfo;
        }
    }
}
