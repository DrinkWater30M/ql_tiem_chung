using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ql_tiem_chung.BUS;
using ql_tiem_chung.DTO;

namespace ql_tiem_chung.GUI
{
    public partial class Customer : Form
    {
        TaiKhoanDTO account = new TaiKhoanDTO();
        KhachHangDTO customerDTO = new KhachHangDTO();
        KhachHangBUS customerBUS = new KhachHangBUS();
        DonDKTiemDTO injectionRegisterDTO = new DonDKTiemDTO();
        ThongTinGoiTiemBUS injectionPackageInfoBUS = new ThongTinGoiTiemBUS();
        GoiTiemBUS injectionPackageBUS = new GoiTiemBUS();
        GoiTiemDTO injectionPackageDTO = new GoiTiemDTO();
        DonDKTiemBUS injectionRegisterBUS = new DonDKTiemBUS();
        VaccineDTO vaccineDTO = new VaccineDTO();
        VaccineBUS vaccineBUS = new VaccineBUS();
        DonDKMuaDTO donDKMuaDTO = new DonDKMuaDTO();
        DonDKMuaBUS donDKMuaBUS = new DonDKMuaBUS();
        DichVuBUS dichVuBUS = new DichVuBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private string usernameAccount;

        public Customer(string usernameAccount)
        {
            //Init
            InitializeComponent();

            //Get user
            this.usernameAccount = usernameAccount;

            //Load combobox
            loadComboboxOfInjectionPackage();
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

        private void handleTabProfile()
        {
            customerDTO = customerBUS.getUserInfo(this.usernameAccount);
            txbFullname.Text = customerDTO.tenkh;
            dtpBirthday.Text = customerDTO.ngaysinh;
            txbGender.Text = customerDTO.gioitinh;
            txbAddress.Text = customerDTO.diachi;
            txbPhone.Text = customerDTO.sdt;
            txbUsername.Text = customerDTO.khuser;
            txbIDUser.Text = customerDTO.makh.ToString();
        }

        private void loadComboboxOfVaccine()
        {
            //Get list vaccine
            List<VaccineDTO> listVaccine = vaccineBUS.getListVaccine();

            //Show to combobox
            cbbVaccine_Order.Items.Clear();
            foreach(VaccineDTO item in listVaccine)
            {
                cbbVaccine_Order.Items.Add(item.mavaccine + " - " + item.tenvaccine + " - " + item.gia + "vnđ");
            }
        }

        private void handleTabOrderVaccine()
        {
            //load combobox vaccine
            loadComboboxOfVaccine();
        }

        private void setHeaderServices(DataGridView dtgv)
        {
            dtgv.Columns[0].HeaderText = "Mã";
            dtgv.Columns[1].HeaderText = "Loại DV";
            dtgv.Columns[2].HeaderText = "Người Trong Đơn";
            dtgv.Columns[3].HeaderText = "Số Điện Thoại";
            dtgv.Columns[4].HeaderText = "Ngày Đăng Kí";
            dtgv.Columns[5].HeaderText = "Giá";
        }

        private void setHeaderBill(DataGridView dtgv)
        {
            dtgv.Columns[0].HeaderText = "Mã";
            dtgv.Columns[1].HeaderText = "Tổng Tiền";
            dtgv.Columns[2].HeaderText = "Trạng Thái";
            dtgv.Columns[3].HeaderText = "Mã Nhân Viên Lập";
        }

        private void loadListItemNotCheckout()
        {
            List<DichVuDTO> list = dichVuBUS.getListServices(this.usernameAccount);
            if(list.Count > 0)
            {
                dtgvServices.DataSource = list;
                setHeaderServices(dtgvServices);
                return;
            }

            MessageBox.Show("Chưa có đăng kí dịch vụ nào!", "Thông báo");
            return;
        }

        private void handleTabCheckout()
        {
            //load list item that not checkout
            loadListItemNotCheckout();
        }

        private void loadBill(string type)
        {
            //Get list bill
            List<HoaDonDTO> list = hoaDonBUS.getListBill(type, this.usernameAccount);

            //control gui
            if(list.Count > 0)
            {
                dtgvHistoryBill.DataSource = list;
                setHeaderBill(dtgvHistoryBill);
                dtgvHistoryBill.Columns[3].Visible = false;
                return;
            }

            MessageBox.Show("Chưa có giao dịch nào!", "Thông báo");
            dtgvHistoryBill.DataSource = null;
        }

        private void handleTabHistory()
        {
            loadBill("ALL");
        }

        private void tabCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabCustomer.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    handleTabOrderVaccine();
                    break;
                case 2:
                    handleTabCheckout();
                    break;
                case 3:
                    handleTabProfile();
                    break;
                case 4:
                    handleTabHistory();
                    break;
            }
        }

        private void updatePassword()
        {
            MessageBox.Show("thay doi mat khau", "thong bao");
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            updatePassword();
        }

        void updateProfile()
        {
            //validate input
            customerDTO.tenkh = txbFullname.Text;
            customerDTO.ngaysinh = dtpBirthday.Value.ToString("yyyyMMdd");
            customerDTO.gioitinh = txbGender.Text;
            customerDTO.diachi = txbAddress.Text;
            customerDTO.sdt = txbPhone.Text;
            customerDTO.khuser = txbUsername.Text;
            customerDTO.makh = Int32.Parse(txbIDUser.Text);
            account.username = this.usernameAccount;
            account.password = txbPassword.Text;

            int resultValidate = customerBUS.validateInput(customerDTO, account);
            if (resultValidate != 1)
            {
                MessageBox.Show("Mật khẩu sai! Không thể cập nhật!", "Thông báo");
                return;
            }

            bool resultUpdate = customerBUS.updateProfile(customerDTO);
            if (!resultUpdate)
            {
                MessageBox.Show("Lỗi phía Server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProfile();
        }


        void injectionRegister()
        {
            //Get data from form
            injectionRegisterDTO.diachi_ndk = txbAddress_Injection.Text;
            injectionRegisterDTO.gioitinh_ndk = cbbGender_Injection.Text;
            if (cbbInjectionPackage_Injection.Text == "")
            {
                injectionRegisterDTO.magoidk = 0;
            }
            else
            {
                injectionRegisterDTO.magoidk = Int32.Parse(
                    cbbInjectionPackage_Injection.Text.Substring(
                    0, cbbInjectionPackage_Injection.Text.IndexOf(".")
                    )
                );
            }
            injectionRegisterDTO.ngaymuontiem = dtpInjectionDay_Injection.Value.ToString("yyyyMMdd");
            injectionRegisterDTO.ngaysinh_ndk = dtpBirthday_Injection.Value.ToString("yyyyMMdd");
            injectionRegisterDTO.sdt_ndk = txbPhone_Injection.Text;
            injectionRegisterDTO.tennguoitiem = txbFullname_Injection.Text;

            //validate input
            int resultValidate = injectionRegisterBUS.validateInput(injectionRegisterDTO);

            //show message when invalid input here
            if(resultValidate == 1)
            {
                MessageBox.Show("Không được để trống dữ liệu!", "Thông báo");
                return;
            }

            //pass
            bool registerResult = injectionRegisterBUS.addInjectionRegister(injectionRegisterDTO, this.usernameAccount);

            if (!registerResult)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại", "Thông báo");
                return;
            }

            MessageBox.Show("Đăng kí thành công!", "Thông báo");

            //Set input to default value
            txbAddress_Injection.Text = "";
            cbbGender_Injection.Text = null;
            dtpBirthday_Injection.Text = "";
            dtpInjectionDay_Injection.Text = "";
            cbbInjectionPackage_Injection.Text = null;
            txbPhone_Injection.Text = "";
            txbFullname_Injection.Text = "";
        }

        private void btnRegisterInjection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng kí tiêm?", "Thông báo", MessageBoxButtons.YesNo) 
                == System.Windows.Forms.DialogResult.Yes)
            {
                injectionRegister();
            }
        }

        private void orderVaccine()
        {
            //Get data form form
            if (cbbVaccine_Order.Text != "") { donDKMuaDTO.vaccine = cbbVaccine_Order.Text.Substring(0, cbbVaccine_Order.Text.IndexOf(" - ")); }
            donDKMuaDTO.tennguoidat = txbFullname_Order.Text;
            donDKMuaDTO.soluong = Convert.ToInt32(nudAmount_Order.Value);
            donDKMuaDTO.sdt_ndk = txbPhone_Order.Text;
            donDKMuaDTO.ngaysinh_ndk = dtpBirthday_Order.Value.ToString("yyyyMMdd");
            donDKMuaDTO.gioitinh_ndk = cbbGender_Order.Text;
            donDKMuaDTO.diachi_ndk = txbAddress_Order.Text;

            //validate input here
            int resultValidate = donDKMuaBUS.validateInput(donDKMuaDTO);

            //show message when invalid input here
            if (resultValidate == 1)
            {
                MessageBox.Show("Không được để trống dữ liệu!", "Thông báo");
                return;
            }

            //pass
            bool registerResult = donDKMuaBUS.addOrderVaccine(donDKMuaDTO, this.usernameAccount);

            if (!registerResult)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại", "Thông báo");
                return;
            }

            MessageBox.Show("Đặt mua thành công!", "Thông báo");

            //Set input to default value
            txbFullname_Order.Text = "";
            txbAddress_Order.Text = "";
            txbPhone_Order.Text = "";
            cbbGender_Order.Text = null;
            cbbVaccine_Order.Text = null;
            nudAmount_Order.Value = 1;
        }

        private void btnOrder_Order_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đặt mua?", "Thông báo", MessageBoxButtons.YesNo)
               == System.Windows.Forms.DialogResult.Yes)
            {
                orderVaccine();
            }
        }

        private void loadComboboxOfInjectionPackage()
        {
            //Get data
            List<ThongTinGoiTiemDTO> listInjectionPackageInfo = injectionPackageInfoBUS.getListInjectionPackageInfo();
            if (listInjectionPackageInfo.Count == 0)
            {
                cbbInjectionPackage_Injection.Text = "Hết gói!";
                return;
            }

            foreach (ThongTinGoiTiemDTO item in listInjectionPackageInfo)
            {
                cbbInjectionPackage_Injection.Items.Add(item.magoi.ToString() + ". "
                    + item.tenvaccine + " - " + item.doituong + " - " + item.gia + "vnđ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadServices(int type, string username)
        {

        }

        private void btnChuaThanhToan_Click(object sender, EventArgs e)
        {
            loadListItemNotCheckout();
        }

        private void btnDaThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void requestCheckout()
        {
            int totalBill = 0;
            List<int> listId = new List<int>();
            foreach (DataGridViewRow row in dtgvServices.Rows)
            {
                totalBill += Int32.Parse(row.Cells[5].Value.ToString());
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                listId.Add(id);
            }

            bool resultUpdateCheckout = hoaDonBUS.updateCheckout(this.usernameAccount, totalBill, listId);

            if (!resultUpdateCheckout)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            MessageBox.Show("Đã lập hóa đơn! Tổng hóa đơn là " + totalBill + ".\nVui lòng đến cơ sở gần nhất để được cập nhật thanh toán!", "Thông báo!");
            dtgvServices.DataSource = null;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvServices.Rows.Count > 0)
            {
                requestCheckout();
            }
        }

        private void loadDetailBill(int idBill)
        {
            //Get data
            List<DichVuDTO> list = dichVuBUS.getListServices(this.usernameAccount, idBill);

            if(list.Count == 0)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            dtgvHistoryBill.DataSource = list;
            setHeaderServices(dtgvHistoryBill);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dtgvHistoryBill.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có giao dịch nào!", "Thông báo");
                return;
            }

            //Get index
            int index = dtgvHistoryBill.CurrentCell.RowIndex;

            //Get id bill
            int idBill = Int32.Parse(dtgvHistoryBill.Rows[index].Cells[0].Value.ToString());

            //load detail
            loadDetailBill(idBill);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            loadBill("UNPAID");
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            loadBill("PAID");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            loadBill("ALL");
        }
    }
}
