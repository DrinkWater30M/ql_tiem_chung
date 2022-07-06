using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;
using ql_tiem_chung.DAO;

namespace ql_tiem_chung.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO accountDAO = new TaiKhoanDAO();
        public int validateInput(TaiKhoanDTO account)
        {
            if(account.username == "") { return 1; }
            if(account.password == "") { return 2; }
            if(account.password.Length < 6) { return 3; }

            //true input
            return 0;
        }

        public int checkAccount(TaiKhoanDTO userAccount)
        {
            TaiKhoanDTO dbAccount = accountDAO.getAccount(userAccount.username);

            if (dbAccount.username == null && dbAccount.password == null) { return 1; }
            if(dbAccount.password != userAccount.password) { return 2; }

            //pass
            int quyen = dbAccount.quyen;
            return quyen + 3;
        }
    }
}
