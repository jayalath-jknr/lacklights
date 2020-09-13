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
    public partial class FrmSal : MaterialSkin.Controls.MaterialForm
    {
        public FrmSal()
        {
            InitializeComponent();
             var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void FrmSal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollDbDataSet.Employee);
            // TODO: This line of code loads data into the 'payrollDbDataSet.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.payrollDbDataSet.salary);

        }

        private void salaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payrollDbDataSet);

        }
    }
}
