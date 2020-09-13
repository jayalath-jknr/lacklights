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
    public partial class FrmHome : MaterialSkin.Controls.MaterialForm
    {
        public FrmHome()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FrmEmp_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            FrmEmpDetails f1 = new FrmEmpDetails();
            f1.Show();
        }

        private void EmpGrid_Click(object sender, EventArgs e)
        {
           // this.Hide();
            GridEmp f1 = new GridEmp();
            f1.Show();
        }
    }
}
