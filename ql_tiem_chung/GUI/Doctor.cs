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
    public partial class Doctor : Form
    {
        private string username;

        DonDKTiemBUS donDKTiemBUS = new DonDKTiemBUS();
        TienTrinhBUS tienTrinhBUS = new TienTrinhBUS();
        public Doctor(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void tabUpdateBill_Click(object sender, EventArgs e)
        {

        }

        private void handleListExamination()
        {
            dtgvListExamination.DataSource = null;
            List<BenhNhanDTO> list = donDKTiemBUS.getListPatient("EXAMINATION");
            
            if(list.Count == 0)
            {
                MessageBox.Show("Chưa có bệnh nhân nào!", "Thông báo");
                return;
            }

            dtgvListExamination.DataSource = list;
        }

        private void handleListInjection()
        {
            dtgvListInjection.DataSource = null;
            List<BenhNhanDTO> list = donDKTiemBUS.getListPatient("INJECTION");

            if (list.Count == 0)
            {
                MessageBox.Show("Chưa có bệnh nhân nào!", "Thông báo");
                return;
            }

            dtgvListInjection.DataSource = list;
        }

        private void handleTabProfile()
        {

        }
        private void tabDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabDoctor.SelectedIndex)
            {
                case 0:
                    handleListExamination();
                    break;
                case 1:
                    handleListInjection();
                    break;
                case 2:
                    handleTabProfile();
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Doctor_Shown(object sender, EventArgs e)
        {
            handleListExamination();
        }

        private void updateExaminationProcess()
        {
            int index = dtgvListExamination.CurrentCell.RowIndex;
            int idProcess = Int32.Parse(dtgvListExamination.Rows[index].Cells[0].Value.ToString());
            string stateExamination = rbtnNone.Text;
            if (rbtnFail.Checked) { stateExamination = rbtnFail.Text; }
            if (rbtnPass.Checked) { stateExamination = rbtnPass.Text; }

            bool resultUpdate = tienTrinhBUS.updateExaminationProcess(idProcess, stateExamination, this.username);

            if (!resultUpdate)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            handleListExamination();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(dtgvListExamination.Rows.Count > 0)
            {
                if (MessageBox.Show("Đã khám cho bệnh nhân này!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    updateExaminationProcess();
                }
            }
        }

        private void updateInjectionProcess()
        {
            int index = dtgvListInjection.CurrentCell.RowIndex;
            int idProcess = Int32.Parse(dtgvListInjection.Rows[index].Cells[0].Value.ToString());
            string stateInjection = rbtnPending.Text;
            if (rbtnDone.Checked) { stateInjection = rbtnDone.Text; }

            bool resultUpdate = tienTrinhBUS.updateInjectionProcess(idProcess, stateInjection, this.username);

            if (!resultUpdate)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            handleListInjection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgvListInjection.Rows.Count > 0)
            {
                if (MessageBox.Show("Đã tiêm cho bệnh nhân này!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    updateInjectionProcess();
                }
            }
        }
    }
}
