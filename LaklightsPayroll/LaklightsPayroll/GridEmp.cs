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
    public partial class GridEmp : MaterialSkin.Controls.MaterialForm
    {
        public GridEmp()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payrollDbDataSet);

        }

        private void FrmSal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollDbDataSet.Employee);

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
           
                bindingNavigatorAddNewItem.PerformClick();
           

           /* 
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

                 }
            }*/

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
    }
    
}
