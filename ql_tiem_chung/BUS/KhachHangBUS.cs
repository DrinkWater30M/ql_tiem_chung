using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DAO;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.BUS
{
    public class KhachHangBUS
    {
        TaiKhoanDAO accountDAO = new TaiKhoanDAO();
        KhachHangDTO customerDTO = new KhachHangDTO();
        KhachHangDAO customerDAO = new KhachHangDAO();
        public KhachHangDTO getUserInfo(string username)
        {
            customerDTO = customerDAO.getUserInfo(username);
            string birthday = customerDTO.ngaysinh.Substring(0, customerDTO.ngaysinh.IndexOf(" "));
            customerDTO.ngaysinh = birthday;
            
            return customerDTO;
        }

        public int validateInput(KhachHangDTO customer, TaiKhoanDTO account)
        {
            //check validate input here

            //pass
            TaiKhoanDTO dbAccount = accountDAO.getAccount(account.username);
            if(dbAccount.password != account.password) { return 0; }
            return 1;
        }

        public bool updateProfile(KhachHangDTO customerDTO)
        {
            try
            {
                bool resultUpdate = customerDAO.updateProfile(customerDTO);
                return resultUpdate;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
