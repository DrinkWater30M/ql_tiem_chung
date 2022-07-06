using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ql_tiem_chung.BUS;
using ql_tiem_chung.DTO;
using ql_tiem_chung.GUI;


namespace ql_tiem_chung
{
    public partial class Login : Form
    {
        TaiKhoanDTO account = new TaiKhoanDTO();
        TaiKhoanBUS accountBUS = new TaiKhoanBUS();

        public Login()
        {
            InitializeComponent();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //get account
            account.username = txbUsername.Text;
            account.password = txbPassword.Text;

            //check validate input data
            int resultLogin = accountBUS.validateInput(account);
            switch (resultLogin)
            {
                case 1:
                    MessageBox.Show("Tên đăng nhập trống!", "Thông báo");
                    return;
                case 2:
                    MessageBox.Show("Mật khẩu trống!", "Thông báo");
                    return;
                case 3:
                    MessageBox.Show("Mật khẩu 6 kí tư trở lên!", "Thông báo");
                    return;
            }

            //check account
            int checkAccount = accountBUS.checkAccount(account);
            switch (checkAccount)
            {
                case 1:
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo");
                    return;
                case 2:
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo");
                    return;
            }

            //pass
            this.Hide();
            switch (checkAccount)
            {
                case 3:
                    Customer customer = new Customer(account.username);
                    customer.ShowDialog();
                    break;
                case 4:
                    Accountant accountant = new Accountant(account.username);
                    accountant.ShowDialog();
                    break;
                case 5:
                    MessageBox.Show("Tài khoản nvyt!", "Thông báo");
                    break;
                case 6:
                    Doctor doctor = new Doctor(account.username);
                    doctor.ShowDialog();
                    break;
            }
            this.Show();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form register = new Register();
            register.ShowDialog();
            this.Show();
        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("register is click", "click");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
