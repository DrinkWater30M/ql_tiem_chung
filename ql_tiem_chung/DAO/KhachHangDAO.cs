using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class KhachHangDAO : DAO
    {
        KhachHangDTO customerDTO = new KhachHangDTO();
        public KhachHangDTO getUserInfo(string username)
        {
            try
            {
                string queryUser = "select * from khach_hang where khach_hang.khuser = '" + username + "';";
                DataTable data = query(queryUser);
                customerDTO.makh = Int32.Parse(data.Rows[0]["makh"].ToString());
                customerDTO.tenkh = data.Rows[0]["tenkh"].ToString();
                customerDTO.ngaysinh = data.Rows[0]["ngaysinh"].ToString();
                customerDTO.diachi = data.Rows[0]["diachi"].ToString();
                customerDTO.sdt = data.Rows[0]["sdt"].ToString();
                customerDTO.khuser = data.Rows[0]["khuser"].ToString();
                customerDTO.gioitinh = data.Rows[0]["gioitinh"].ToString();

                return customerDTO;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return customerDTO;
            }
        }

        public bool updateProfile(KhachHangDTO customer)
        {
            try
            {
                string queryUpdateUser =
                    "update khach_hang " +
                    "set khach_hang.tenkh = '" + customer.tenkh + "', " + 
                    "khach_hang.ngaysinh = '" + customer.ngaysinh + "'," + 
                    "khach_hang.diachi = '" + customer.diachi + "', " + 
                    "khach_hang.gioitinh = '" + customer.gioitinh + "', " + 
                    "khach_hang.sdt = '" + customer.sdt + "' " +
                    "where khach_hang.makh = " + customer.makh;
                query(queryUpdateUser);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
