using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.DAO
{
    public class NhanVienDAO :DAO
    {
        public NhanVienDTO getStaffInfo(string username)
        {
            NhanVienDTO staffInfo = new NhanVienDTO();
            try
            {
                string queryStaff = "select * from nhan_vien where nhan_vien.nvuser = '" + username + "';";

                DataTable data = query(queryStaff);

                if(data.Rows.Count > 0)
                {
                    staffInfo.manv = Int32.Parse(data.Rows[0]["manv"].ToString());
                    staffInfo.tennv = data.Rows[0]["tennv"].ToString();
                    staffInfo.ngaysinh = data.Rows[0]["ngaysinh"].ToString();
                    staffInfo.sdt = data.Rows[0]["sdt"].ToString();
                    staffInfo.luong = Int32.Parse(data.Rows[0]["luong"].ToString());
                    staffInfo.diachi = data.Rows[0]["diachi"].ToString();
                    staffInfo.bangcap = data.Rows[0]["bangcap"].ToString();
                    staffInfo.email = data.Rows[0]["email"].ToString();
                    staffInfo.nvuser = data.Rows[0]["nvuser"].ToString();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return staffInfo;
        }
    }
}
