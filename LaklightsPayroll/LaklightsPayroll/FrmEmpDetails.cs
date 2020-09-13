using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace LaklightsPayroll
{
    public partial class FrmEmpDetails : MaterialSkin.Controls.MaterialForm
    {
        public FrmEmpDetails()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           // this.Validate();
           // this.employeeBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.payrollDbDataSet);

        }

        private void FrmEmpDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDbDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.payrollDbDataSet.Departments);
            // TODO: This line of code loads data into the 'payrollDbDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.payrollDbDataSet.Position);
            // TODO: This line of code loads data into the 'payrollDbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollDbDataSet.Employee);
            // TODO: This line of code loads data into the 'payrollDbDataSet.Employee' table. You can move, or remove it, as needed.
            // this.employeeTableAdapter.Fill(this.payrollDbDataSet.Employee);

        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payrollDbDataSet);

        }

        private void emp_IdLabel1_Click(object sender, EventArgs e)
        {

        }

        private void emp_IdMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Incompatiable Types");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            employeeBindingNavigatorSaveItem.PerformClick();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            employeeBindingSource.CancelEdit();
        }

        private void toolStripBtnSearch_Click(object sender, EventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(sarch.Text))
                {

                    employeeBindingSource.Filter = string.Format(" emp_id ='{0}' or emp_lname LIKE '*{1}*' OR emp_email = '{2} or emp_address like'*{3}*' ",
                        txtid.Text, txtlname.Text, txtemil.Text, txtaddress.Text);

                }
                else
                {
                    employeeBindingSource.Filter = string.Empty;
                }

            }*/
        }

        private void btnview_Click(object sender, EventArgs e)
        {
           // this.Hide();
            GridEmp f1 = new GridEmp();
            f1.Show();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
