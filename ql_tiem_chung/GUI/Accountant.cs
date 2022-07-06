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

namespace ql_tiem_chung.GUI
{
    public partial class Accountant : Form
    {
        private string username;

        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        public Accountant(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
        }

        private void setHeaderBill(DataGridView dtgv)
        {
            dtgv.Columns[0].HeaderText = "Mã";
            dtgv.Columns[1].HeaderText = "Tổng Tiền";
            dtgv.Columns[2].HeaderText = "Trạng Thái";
            dtgv.Columns[3].Visible = false;
        }

        private void handleTabUpdateBill()
        {
            dtgvUnpaid.DataSource = null;
            List<HoaDonDTO> list = hoaDonBUS.getListBill("UNPAID");

            if (list.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn nào chờ thanh toán!", "Thông báo");
                return;
            }

            dtgvUnpaid.DataSource = list;
            setHeaderBill(dtgvUnpaid);
        }
        private void handleTabHistory()
        {
            List<HoaDonDTO> list = hoaDonBUS.getListBill("PAID", "", this.username);

            if(list.Count == 0)
            {
                MessageBox.Show("Chưa Thu Tiền Cho Hóa Đơn Nào!", "Thông báo");
                return;
            }

            dtgvHistory.DataSource = list;
            setHeaderBill(dtgvHistory);
        }
        private void handleTabProfile()
        {
            MessageBox.Show("Đây là chức năng cập nhật thông tin cá nhân");
        }
        private void tabAccountant_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabAccountant.SelectedIndex)
            {
                case 0:
                    handleTabUpdateBill();
                    break;
                case 1:
                    handleTabHistory();
                    break;
                case 2:
                    handleTabProfile();
                    break;
            }
        }

        private void payBill(int idBill)
        {
            bool resultPayBill = hoaDonBUS.updateBill(idBill, this.username);

            if (!resultPayBill)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            MessageBox.Show("Hóa Đơn Đã Thu Tiền!", "Thông Báo");
            handleTabUpdateBill();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvUnpaid.Rows.Count > 0)
            {
                int index = dtgvUnpaid.CurrentCell.RowIndex;
                int totalBill = Int32.Parse(dtgvUnpaid.Rows[index].Cells[1].Value.ToString());
                if (MessageBox.Show("Bạn đã nhận được " + totalBill + "vnđ từ khách hàng?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idBill = Int32.Parse(dtgvUnpaid.Rows[index].Cells[0].Value.ToString());
                    payBill(idBill);
                }
            }
        }

        private void Accountant_Shown(object sender, EventArgs e)
        {
            handleTabUpdateBill();
        }

        private void Accountant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
