using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class GoiTiemDAO : DAO
    {

        public GoiTiemDTO getInjectionPackage(int id)
        {
            GoiTiemDTO goiTiemDTO = new GoiTiemDTO();
            try
            {
                string queryPackage = "select * from goi_tiem " +
                    "where goi_tiem.magoi = " + id + ";";
                
                DataTable data = query(queryPackage);

  
                if(data.Rows.Count > 0) {
                    goiTiemDTO.magoi = Int32.Parse(data.Rows[0]["magoi"].ToString());
                    goiTiemDTO.doituong = data.Rows[0]["doituong"].ToString();
                    goiTiemDTO.gia = Int32.Parse(data.Rows[0]["gia"].ToString());
                    goiTiemDTO.vaccine = data.Rows[0]["vaccine"].ToString();
                }

          
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return goiTiemDTO;
        }
    }
}
