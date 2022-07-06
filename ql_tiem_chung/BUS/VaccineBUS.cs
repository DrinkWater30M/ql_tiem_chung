using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;
using ql_tiem_chung.DAO;

namespace ql_tiem_chung.BUS
{
    public class VaccineBUS
    {
        VaccineDAO vaccineDAO = new VaccineDAO();
        public List<VaccineDTO> getListVaccine()
        {
            List<VaccineDTO> listVaccine = vaccineDAO.getListVaccine();
            return listVaccine;
        }
    }
}
