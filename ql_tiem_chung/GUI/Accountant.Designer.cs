
namespace ql_tiem_chung.GUI
{
    partial class Accountant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.txbIDUser = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tabUpdateBill = new System.Windows.Forms.TabPage();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtgvUnpaid = new System.Windows.Forms.DataGridView();
            this.tabAccountant = new System.Windows.Forms.TabControl();
            this.tabHistoryUpdate = new System.Windows.Forms.TabPage();
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabProfile.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabUpdateBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUnpaid)).BeginInit();
            this.tabAccountant.SuspendLayout();
            this.tabHistoryUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(322, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(330, 35);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "Hệ Thống Tiêm Chủng";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(895, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 32);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.txbIDUser);
            this.tabProfile.Controls.Add(this.panel8);
            this.tabProfile.Controls.Add(this.panel7);
            this.tabProfile.Controls.Add(this.panel10);
            this.tabProfile.Controls.Add(this.panel9);
            this.tabProfile.Controls.Add(this.panel6);
            this.tabProfile.Controls.Add(this.panel4);
            this.tabProfile.Controls.Add(this.panel3);
            this.tabProfile.Controls.Add(this.panel2);
            this.tabProfile.Location = new System.Drawing.Point(4, 36);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(965, 481);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Thông Tin Cá Nhân";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // txbIDUser
            // 
            this.txbIDUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDUser.Location = new System.Drawing.Point(201, 6);
            this.txbIDUser.Name = "txbIDUser";
            this.txbIDUser.Size = new System.Drawing.Size(234, 34);
            this.txbIDUser.TabIndex = 18;
            this.txbIDUser.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbGender);
            this.panel8.Controls.Add(this.lbGender);
            this.panel8.Location = new System.Drawing.Point(18, 162);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(461, 51);
            this.panel8.TabIndex = 17;
            // 
            // txbGender
            // 
            this.txbGender.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGender.Location = new System.Drawing.Point(183, 8);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(234, 34);
            this.txbGender.TabIndex = 1;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(11, 13);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(96, 29);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Giới tính: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpBirthday);
            this.panel7.Controls.Add(this.lbBirthday);
            this.panel7.Location = new System.Drawing.Point(485, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(461, 51);
            this.panel7.TabIndex = 14;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(183, 8);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(234, 34);
            this.dtpBirthday.TabIndex = 29;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(11, 12);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(109, 29);
            this.lbBirthday.TabIndex = 0;
            this.lbBirthday.Text = "Ngày sinh: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbAddress);
            this.panel10.Controls.Add(this.Address);
            this.panel10.Location = new System.Drawing.Point(485, 273);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(461, 51);
            this.panel10.TabIndex = 16;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(183, 6);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(234, 34);
            this.txbAddress.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(11, 11);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(86, 29);
            this.Address.TabIndex = 0;
            this.Address.Text = "Địa chỉ: ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbPhone);
            this.panel9.Controls.Add(this.Phone);
            this.panel9.Location = new System.Drawing.Point(18, 273);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(461, 51);
            this.panel9.TabIndex = 15;
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(183, 6);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(234, 34);
            this.txbPhone.TabIndex = 1;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(11, 11);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(144, 29);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Số điện thoại: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbFullname);
            this.panel6.Controls.Add(this.lbFullname);
            this.panel6.Location = new System.Drawing.Point(18, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(461, 51);
            this.panel6.TabIndex = 13;
            // 
            // txbFullname
            // 
            this.txbFullname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullname.Location = new System.Drawing.Point(183, 8);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(234, 34);
            this.txbFullname.TabIndex = 1;
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.Location = new System.Drawing.Point(11, 13);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(83, 29);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "Họ tên: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdatePassword);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Location = new System.Drawing.Point(555, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 52);
            this.panel4.TabIndex = 12;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.AutoSize = true;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(20, 7);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(144, 39);
            this.btnUpdatePassword.TabIndex = 4;
            this.btnUpdatePassword.Text = "Đổi mật khẩu";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(197, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassword);
            this.panel3.Controls.Add(this.lbPassword);
            this.panel3.Location = new System.Drawing.Point(18, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 53);
            this.panel3.TabIndex = 10;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(183, 8);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(234, 34);
            this.txbPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(29, 12);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(106, 29);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Mât khẩu: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUsername);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Location = new System.Drawing.Point(485, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 52);
            this.panel2.TabIndex = 9;
            // 
            // txbUsername
            // 
            this.txbUsername.Enabled = false;
            this.txbUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(183, 8);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(234, 34);
            this.txbUsername.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(11, 13);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(157, 29);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tên đăng nhập: ";
            // 
            // tabUpdateBill
            // 
            this.tabUpdateBill.Controls.Add(this.btnThanhToan);
            this.tabUpdateBill.Controls.Add(this.dtgvUnpaid);
            this.tabUpdateBill.Location = new System.Drawing.Point(4, 36);
            this.tabUpdateBill.Name = "tabUpdateBill";
            this.tabUpdateBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateBill.Size = new System.Drawing.Size(965, 481);
            this.tabUpdateBill.TabIndex = 0;
            this.tabUpdateBill.Text = "Cập Nhật Thanh Toán";
            this.tabUpdateBill.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(832, 443);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(127, 32);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtgvUnpaid
            // 
            this.dtgvUnpaid.AllowUserToAddRows = false;
            this.dtgvUnpaid.AllowUserToDeleteRows = false;
            this.dtgvUnpaid.AllowUserToResizeColumns = false;
            this.dtgvUnpaid.AllowUserToResizeRows = false;
            this.dtgvUnpaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUnpaid.Location = new System.Drawing.Point(6, 6);
            this.dtgvUnpaid.Name = "dtgvUnpaid";
            this.dtgvUnpaid.RowHeadersWidth = 51;
            this.dtgvUnpaid.RowTemplate.Height = 24;
            this.dtgvUnpaid.Size = new System.Drawing.Size(820, 469);
            this.dtgvUnpaid.TabIndex = 0;
            // 
            // tabAccountant
            // 
            this.tabAccountant.Controls.Add(this.tabUpdateBill);
            this.tabAccountant.Controls.Add(this.tabHistoryUpdate);
            this.tabAccountant.Controls.Add(this.tabProfile);
            this.tabAccountant.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccountant.Location = new System.Drawing.Point(7, 78);
            this.tabAccountant.Name = "tabAccountant";
            this.tabAccountant.SelectedIndex = 0;
            this.tabAccountant.Size = new System.Drawing.Size(973, 521);
            this.tabAccountant.TabIndex = 29;
            this.tabAccountant.SelectedIndexChanged += new System.EventHandler(this.tabAccountant_SelectedIndexChanged);
            // 
            // tabHistoryUpdate
            // 
            this.tabHistoryUpdate.Controls.Add(this.dtgvHistory);
            this.tabHistoryUpdate.Location = new System.Drawing.Point(4, 36);
            this.tabHistoryUpdate.Name = "tabHistoryUpdate";
            this.tabHistoryUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoryUpdate.Size = new System.Drawing.Size(965, 481);
            this.tabHistoryUpdate.TabIndex = 2;
            this.tabHistoryUpdate.Text = "Lịch Sử Cập Nhật";
            this.tabHistoryUpdate.UseVisualStyleBackColor = true;
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AllowUserToAddRows = false;
            this.dtgvHistory.AllowUserToDeleteRows = false;
            this.dtgvHistory.AllowUserToResizeColumns = false;
            this.dtgvHistory.AllowUserToResizeRows = false;
            this.dtgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Location = new System.Drawing.Point(6, 6);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersWidth = 51;
            this.dtgvHistory.RowTemplate.Height = 24;
            this.dtgvHistory.Size = new System.Drawing.Size(953, 469);
            this.dtgvHistory.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(183, 8);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(234, 34);
            this.textBox7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(183, 8);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '*';
            this.textBox6.Size = new System.Drawing.Size(234, 34);
            this.textBox6.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(183, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(234, 34);
            this.textBox5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(183, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 34);
            this.textBox4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(183, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(234, 34);
            this.textBox3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(183, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 34);
            this.textBox2.TabIndex = 1;
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 611);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabAccountant);
            this.Controls.Add(this.lbTitle);
            this.Name = "Accountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Tiêm Chủng - Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accountant_FormClosing);
            this.Load += new System.EventHandler(this.Accountant_Load);
            this.Shown += new System.EventHandler(this.Accountant_Shown);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabUpdateBill.ResumeLayout(false);
            this.tabUpdateBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUnpaid)).EndInit();
            this.tabAccountant.ResumeLayout(false);
            this.tabHistoryUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TextBox txbIDUser;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TabPage tabUpdateBill;
        private System.Windows.Forms.TabControl tabAccountant;
        private System.Windows.Forms.TabPage tabHistoryUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dtgvUnpaid;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dtgvHistory;
    }
}