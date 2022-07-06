using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class VaccineDAO : DAO
    {
        public List<VaccineDTO> getListVaccine()
        {
            string queryListVaccine = "select * from vaccine";
            DataTable data = query(queryListVaccine);

            List<VaccineDTO> listVaccine = new List<VaccineDTO>();
            foreach(DataRow item in data.Rows)
            {
                VaccineDTO vaccine = new VaccineDTO();
                vaccine.mavaccine = item["mavaccine"].ToString();
                vaccine.tenvaccine = item["tenvaccine"].ToString();
                vaccine.hsd = item["hsd"].ToString();
                vaccine.ncc_vaccine = Int32.Parse(item["ncc_vaccine"].ToString());
                vaccine.gia = Int32.Parse(item["gia"].ToString());
                listVaccine.Add(vaccine);
            }

            return listVaccine;
        }

        public VaccineDTO getVaccine(string id)
        {
            string queryVaccine = "select * from vaccine where vaccine.mavaccine = '" + id + "';";

            DataTable data = query(queryVaccine);
            VaccineDTO vaccine = new VaccineDTO();
            if(data.Rows.Count != 0)
            {
                vaccine.mavaccine = data.Rows[0]["mavaccine"].ToString();
                vaccine.tenvaccine = data.Rows[0]["tenvaccine"].ToString();
                vaccine.hsd = data.Rows[0]["hsd"].ToString();
                vaccine.gia = Int32.Parse(data.Rows[0]["gia"].ToString());
                vaccine.ncc_vaccine = Int32.Parse(data.Rows[0]["ncc_vaccine"].ToString());
            }

            return vaccine;
        }
    }
}
