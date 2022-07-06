using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class TaiKhoanDAO : DAO
    {
        public TaiKhoanDTO getAccount(string username)
        {
            TaiKhoanDTO account = new TaiKhoanDTO();
            //Get data in here
            string queryAccount = "select * from tai_khoan where tai_khoan.username = " + "'" + username + "';";
            DataTable dataTable = query(queryAccount);
            if(dataTable.Rows.Count != 0)
            {
                account.username = dataTable.Rows[0]["username"].ToString();
                account.password = dataTable.Rows[0]["password"].ToString();
                account.quyen = Int32.Parse(dataTable.Rows[0]["quyen"].ToString());
            }

            return account;
        }
    }
}
