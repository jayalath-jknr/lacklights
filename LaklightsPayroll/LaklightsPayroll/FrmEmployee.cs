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
    public partial class FrmEmployee : MaterialSkin.Controls.MaterialForm
    {
        public FrmEmployee()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.payrollDbDataSet);

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDbDataSet.Departments' table. You can move, or remove it, as needed.
          //  this.departmentsTableAdapter.Fill(this.payrollDbDataSet.Departments);
            // TODO: This line of code loads data into the 'payrollDbDataSet.Position' table. You can move, or remove it, as needed.
          //  this.positionTableAdapter.Fill(this.payrollDbDataSet.Position);
            // TODO: This line of code loads data into the 'payrollDbDataSet.Employee' table. You can move, or remove it, as needed.
          //  this.employeeTableAdapter.Fill(this.payrollDbDataSet.Employee);

        }
    }
}
