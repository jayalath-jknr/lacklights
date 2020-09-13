namespace LaklightsPayroll
{
    partial class FrmHome
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.EmpGrid = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(331, 387);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(81, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Employee";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // EmpGrid
            // 
            this.EmpGrid.AutoSize = true;
            this.EmpGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmpGrid.Depth = 0;
            this.EmpGrid.Location = new System.Drawing.Point(331, 333);
            this.EmpGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EmpGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.Primary = false;
            this.EmpGrid.Size = new System.Drawing.Size(115, 36);
            this.EmpGrid.TabIndex = 1;
            this.EmpGrid.Text = "Employee grid";
            this.EmpGrid.UseVisualStyleBackColor = true;
            this.EmpGrid.Click += new System.EventHandler(this.EmpGrid_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 543);
            this.Controls.Add(this.EmpGrid);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "FrmHome";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton EmpGrid;
    }
}

