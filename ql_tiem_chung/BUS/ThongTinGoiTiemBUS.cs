using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;
using ql_tiem_chung.DAO;

namespace ql_tiem_chung.BUS
{
    public class ThongTinGoiTiemBUS
    {
        ThongTinGoiTiemDAO injectionPackageInfoDAO = new ThongTinGoiTiemDAO();
        public List<ThongTinGoiTiemDTO> getListInjectionPackageInfo()
        {
            List<ThongTinGoiTiemDTO> listInjectionPackageInfo = injectionPackageInfoDAO.getListInjectionPackageInfo();
            return listInjectionPackageInfo;
        }
    }
}
