
namespace ql_tiem_chung.GUI
{
    partial class Doctor
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabDoctor = new System.Windows.Forms.TabControl();
            this.tabExamination = new System.Windows.Forms.TabPage();
            this.rbtnPass = new System.Windows.Forms.RadioButton();
            this.rbtnFail = new System.Windows.Forms.RadioButton();
            this.rbtnNone = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtgvListExamination = new System.Windows.Forms.DataGridView();
            this.tabInjection = new System.Windows.Forms.TabPage();
            this.rbtnDone = new System.Windows.Forms.RadioButton();
            this.rbtnPending = new System.Windows.Forms.RadioButton();
            this.btnUpdateInjection = new System.Windows.Forms.Button();
            this.dtgvListInjection = new System.Windows.Forms.DataGridView();
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabDoctor.SuspendLayout();
            this.tabExamination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListExamination)).BeginInit();
            this.tabInjection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListInjection)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(898, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 32);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabDoctor
            // 
            this.tabDoctor.Controls.Add(this.tabExamination);
            this.tabDoctor.Controls.Add(this.tabInjection);
            this.tabDoctor.Controls.Add(this.tabProfile);
            this.tabDoctor.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoctor.Location = new System.Drawing.Point(10, 74);
            this.tabDoctor.Name = "tabDoctor";
            this.tabDoctor.SelectedIndex = 0;
            this.tabDoctor.Size = new System.Drawing.Size(973, 521);
            this.tabDoctor.TabIndex = 32;
            this.tabDoctor.SelectedIndexChanged += new System.EventHandler(this.tabDoctor_SelectedIndexChanged);
            // 
            // tabExamination
            // 
            this.tabExamination.Controls.Add(this.rbtnPass);
            this.tabExamination.Controls.Add(this.rbtnFail);
            this.tabExamination.Controls.Add(this.rbtnNone);
            this.tabExamination.Controls.Add(this.btnSubmit);
            this.tabExamination.Controls.Add(this.dtgvListExamination);
            this.tabExamination.Location = new System.Drawing.Point(4, 36);
            this.tabExamination.Name = "tabExamination";
            this.tabExamination.Padding = new System.Windows.Forms.Padding(3);
            this.tabExamination.Size = new System.Drawing.Size(965, 481);
            this.tabExamination.TabIndex = 0;
            this.tabExamination.Text = "Danh Sách Khám";
            this.tabExamination.UseVisualStyleBackColor = true;
            this.tabExamination.Click += new System.EventHandler(this.tabUpdateBill_Click);
            // 
            // rbtnPass
            // 
            this.rbtnPass.AutoSize = true;
            this.rbtnPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPass.Location = new System.Drawing.Point(832, 394);
            this.rbtnPass.Name = "rbtnPass";
            this.rbtnPass.Size = new System.Drawing.Size(56, 28);
            this.rbtnPass.TabIndex = 10;
            this.rbtnPass.Text = "Đạt";
            this.rbtnPass.UseVisualStyleBackColor = true;
            // 
            // rbtnFail
            // 
            this.rbtnFail.AutoSize = true;
            this.rbtnFail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFail.Location = new System.Drawing.Point(832, 342);
            this.rbtnFail.Name = "rbtnFail";
            this.rbtnFail.Size = new System.Drawing.Size(99, 28);
            this.rbtnFail.TabIndex = 9;
            this.rbtnFail.Text = "Chưa Đạt";
            this.rbtnFail.UseVisualStyleBackColor = true;
            // 
            // rbtnNone
            // 
            this.rbtnNone.AutoSize = true;
            this.rbtnNone.Checked = true;
            this.rbtnNone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNone.Location = new System.Drawing.Point(832, 287);
            this.rbtnNone.Name = "rbtnNone";
            this.rbtnNone.Size = new System.Drawing.Size(118, 28);
            this.rbtnNone.TabIndex = 8;
            this.rbtnNone.TabStop = true;
            this.rbtnNone.Text = "Chưa Khám";
            this.rbtnNone.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(832, 443);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 32);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Cập Nhật";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtgvListExamination
            // 
            this.dtgvListExamination.AllowUserToAddRows = false;
            this.dtgvListExamination.AllowUserToDeleteRows = false;
            this.dtgvListExamination.AllowUserToResizeColumns = false;
            this.dtgvListExamination.AllowUserToResizeRows = false;
            this.dtgvListExamination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvListExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListExamination.Location = new System.Drawing.Point(6, 6);
            this.dtgvListExamination.Name = "dtgvListExamination";
            this.dtgvListExamination.RowHeadersWidth = 51;
            this.dtgvListExamination.RowTemplate.Height = 24;
            this.dtgvListExamination.Size = new System.Drawing.Size(820, 469);
            this.dtgvListExamination.TabIndex = 0;
            // 
            // tabInjection
            // 
            this.tabInjection.Controls.Add(this.rbtnDone);
            this.tabInjection.Controls.Add(this.rbtnPending);
            this.tabInjection.Controls.Add(this.btnUpdateInjection);
            this.tabInjection.Controls.Add(this.dtgvListInjection);
            this.tabInjection.Location = new System.Drawing.Point(4, 36);
            this.tabInjection.Name = "tabInjection";
            this.tabInjection.Padding = new System.Windows.Forms.Padding(3);
            this.tabInjection.Size = new System.Drawing.Size(965, 481);
            this.tabInjection.TabIndex = 2;
            this.tabInjection.Text = "Danh Sách Tiêm";
            this.tabInjection.UseVisualStyleBackColor = true;
            // 
            // rbtnDone
            // 
            this.rbtnDone.AutoSize = true;
            this.rbtnDone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDone.Location = new System.Drawing.Point(832, 394);
            this.rbtnDone.Name = "rbtnDone";
            this.rbtnDone.Size = new System.Drawing.Size(94, 28);
            this.rbtnDone.TabIndex = 15;
            this.rbtnDone.Text = "Đã Tiêm";
            this.rbtnDone.UseVisualStyleBackColor = true;
            // 
            // rbtnPending
            // 
            this.rbtnPending.AutoSize = true;
            this.rbtnPending.Checked = true;
            this.rbtnPending.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPending.Location = new System.Drawing.Point(832, 342);
            this.rbtnPending.Name = "rbtnPending";
            this.rbtnPending.Size = new System.Drawing.Size(111, 28);
            this.rbtnPending.TabIndex = 14;
            this.rbtnPending.TabStop = true;
            this.rbtnPending.Text = "Chưa Tiêm";
            this.rbtnPending.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInjection
            // 
            this.btnUpdateInjection.AutoSize = true;
            this.btnUpdateInjection.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInjection.Location = new System.Drawing.Point(832, 443);
            this.btnUpdateInjection.Name = "btnUpdateInjection";
            this.btnUpdateInjection.Size = new System.Drawing.Size(127, 32);
            this.btnUpdateInjection.TabIndex = 12;
            this.btnUpdateInjection.Text = "Cập Nhật";
            this.btnUpdateInjection.UseVisualStyleBackColor = true;
            this.btnUpdateInjection.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvListInjection
            // 
            this.dtgvListInjection.AllowUserToAddRows = false;
            this.dtgvListInjection.AllowUserToDeleteRows = false;
            this.dtgvListInjection.AllowUserToResizeColumns = false;
            this.dtgvListInjection.AllowUserToResizeRows = false;
            this.dtgvListInjection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvListInjection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListInjection.Location = new System.Drawing.Point(6, 6);
            this.dtgvListInjection.Name = "dtgvListInjection";
            this.dtgvListInjection.RowHeadersWidth = 51;
            this.dtgvListInjection.RowTemplate.Height = 24;
            this.dtgvListInjection.Size = new System.Drawing.Size(820, 469);
            this.dtgvListInjection.TabIndex = 11;
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
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(325, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(330, 35);
            this.lbTitle.TabIndex = 31;
            this.lbTitle.Text = "Hệ Thống Tiêm Chủng";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 611);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabDoctor);
            this.Controls.Add(this.lbTitle);
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Tiêm Chủng - Bác Sĩ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctor_FormClosing);
            this.Shown += new System.EventHandler(this.Doctor_Shown);
            this.tabDoctor.ResumeLayout(false);
            this.tabExamination.ResumeLayout(false);
            this.tabExamination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListExamination)).EndInit();
            this.tabInjection.ResumeLayout(false);
            this.tabInjection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListInjection)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabDoctor;
        private System.Windows.Forms.TabPage tabExamination;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dtgvListExamination;
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
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RadioButton rbtnPass;
        private System.Windows.Forms.RadioButton rbtnFail;
        private System.Windows.Forms.RadioButton rbtnNone;
        private System.Windows.Forms.TabPage tabInjection;
        private System.Windows.Forms.RadioButton rbtnDone;
        private System.Windows.Forms.RadioButton rbtnPending;
        private System.Windows.Forms.Button btnUpdateInjection;
        private System.Windows.Forms.DataGridView dtgvListInjection;
    }
}