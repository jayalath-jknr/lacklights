namespace LaklightsPayroll
{
    partial class FrmSal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSal));
            System.Windows.Forms.Label sal_working_hoursLabel;
            System.Windows.Forms.Label oT_HoursLabel;
            System.Windows.Forms.Label sal_comissionsLabel;
            System.Windows.Forms.Label sal_loanLabel;
            System.Windows.Forms.Label sal_deductionsLabel;
            this.payrollDbDataSet = new LaklightsPayroll.PayrollDbDataSet();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTableAdapter = new LaklightsPayroll.PayrollDbDataSetTableAdapters.salaryTableAdapter();
            this.tableAdapterManager = new LaklightsPayroll.PayrollDbDataSetTableAdapters.TableAdapterManager();
            this.salaryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.salaryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.payslip_IdTextBox = new System.Windows.Forms.TextBox();
            this.emp_IdComboBox = new System.Windows.Forms.ComboBox();
            this.from_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sal_working_hoursTextBox = new System.Windows.Forms.TextBox();
            this.oT_HoursTextBox = new System.Windows.Forms.TextBox();
            this.sal_comissionsTextBox = new System.Windows.Forms.TextBox();
            this.sal_loanTextBox = new System.Windows.Forms.TextBox();
            this.sal_deductionsTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new LaklightsPayroll.PayrollDbDataSetTableAdapters.EmployeeTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPayslip = new MaterialSkin.Controls.MaterialLabel();
            this.lblempId = new MaterialSkin.Controls.MaterialLabel();
            this.lblfrom = new MaterialSkin.Controls.MaterialLabel();
            this.lblto = new MaterialSkin.Controls.MaterialLabel();
            this.WorkingHours = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            sal_working_hoursLabel = new System.Windows.Forms.Label();
            oT_HoursLabel = new System.Windows.Forms.Label();
            sal_comissionsLabel = new System.Windows.Forms.Label();
            sal_loanLabel = new System.Windows.Forms.Label();
            sal_deductionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingNavigator)).BeginInit();
            this.salaryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // payrollDbDataSet
            // 
            this.payrollDbDataSet.DataSetName = "PayrollDbDataSet";
            this.payrollDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "salary";
            this.salaryBindingSource.DataSource = this.payrollDbDataSet;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.LeavesTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.salaryTableAdapter = this.salaryTableAdapter;
            this.tableAdapterManager.TitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LaklightsPayroll.PayrollDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkedhoursTableAdapter = null;
            // 
            // salaryBindingNavigator
            // 
            this.salaryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salaryBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.salaryBindingNavigator.BindingSource = this.salaryBindingSource;
            this.salaryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salaryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salaryBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.salaryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salaryBindingNavigatorSaveItem});
            this.salaryBindingNavigator.Location = new System.Drawing.Point(9, 63);
            this.salaryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salaryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salaryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salaryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salaryBindingNavigator.Name = "salaryBindingNavigator";
            this.salaryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salaryBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.salaryBindingNavigator.TabIndex = 0;
            this.salaryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // salaryBindingNavigatorSaveItem
            // 
            this.salaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salaryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salaryBindingNavigatorSaveItem.Image")));
            this.salaryBindingNavigatorSaveItem.Name = "salaryBindingNavigatorSaveItem";
            this.salaryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salaryBindingNavigatorSaveItem.Text = "Save Data";
            this.salaryBindingNavigatorSaveItem.Click += new System.EventHandler(this.salaryBindingNavigatorSaveItem_Click);
            // 
            // payslip_IdTextBox
            // 
            this.payslip_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "payslip_Id", true));
            this.payslip_IdTextBox.Location = new System.Drawing.Point(342, 175);
            this.payslip_IdTextBox.Name = "payslip_IdTextBox";
            this.payslip_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.payslip_IdTextBox.TabIndex = 2;
            // 
            // emp_IdComboBox
            // 
            this.emp_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.salaryBindingSource, "emp_Id", true));
            this.emp_IdComboBox.DataSource = this.employeeBindingSource;
            this.emp_IdComboBox.DisplayMember = "emp_name_ini";
            this.emp_IdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emp_IdComboBox.FormattingEnabled = true;
            this.emp_IdComboBox.Location = new System.Drawing.Point(342, 201);
            this.emp_IdComboBox.Name = "emp_IdComboBox";
            this.emp_IdComboBox.Size = new System.Drawing.Size(200, 21);
            this.emp_IdComboBox.TabIndex = 4;
            this.emp_IdComboBox.ValueMember = "emp_Id";
            // 
            // from_DateDateTimePicker
            // 
            this.from_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salaryBindingSource, "from_Date", true));
            this.from_DateDateTimePicker.Location = new System.Drawing.Point(342, 228);
            this.from_DateDateTimePicker.Name = "from_DateDateTimePicker";
            this.from_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.from_DateDateTimePicker.TabIndex = 6;
            // 
            // to_DateDateTimePicker
            // 
            this.to_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salaryBindingSource, "to_Date", true));
            this.to_DateDateTimePicker.Location = new System.Drawing.Point(342, 254);
            this.to_DateDateTimePicker.Name = "to_DateDateTimePicker";
            this.to_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.to_DateDateTimePicker.TabIndex = 8;
            // 
            // sal_working_hoursLabel
            // 
            sal_working_hoursLabel.AutoSize = true;
            sal_working_hoursLabel.Location = new System.Drawing.Point(244, 283);
            sal_working_hoursLabel.Name = "sal_working_hoursLabel";
            sal_working_hoursLabel.Size = new System.Drawing.Size(92, 13);
            sal_working_hoursLabel.TabIndex = 9;
            sal_working_hoursLabel.Text = "sal working hours:";
            // 
            // sal_working_hoursTextBox
            // 
            this.sal_working_hoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "sal_working_hours", true));
            this.sal_working_hoursTextBox.Location = new System.Drawing.Point(342, 280);
            this.sal_working_hoursTextBox.Name = "sal_working_hoursTextBox";
            this.sal_working_hoursTextBox.Size = new System.Drawing.Size(200, 20);
            this.sal_working_hoursTextBox.TabIndex = 10;
            // 
            // oT_HoursLabel
            // 
            oT_HoursLabel.AutoSize = true;
            oT_HoursLabel.Location = new System.Drawing.Point(244, 309);
            oT_HoursLabel.Name = "oT_HoursLabel";
            oT_HoursLabel.Size = new System.Drawing.Size(56, 13);
            oT_HoursLabel.TabIndex = 11;
            oT_HoursLabel.Text = "OT Hours:";
            // 
            // oT_HoursTextBox
            // 
            this.oT_HoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "OT_Hours", true));
            this.oT_HoursTextBox.Location = new System.Drawing.Point(342, 306);
            this.oT_HoursTextBox.Name = "oT_HoursTextBox";
            this.oT_HoursTextBox.Size = new System.Drawing.Size(200, 20);
            this.oT_HoursTextBox.TabIndex = 12;
            // 
            // sal_comissionsLabel
            // 
            sal_comissionsLabel.AutoSize = true;
            sal_comissionsLabel.Location = new System.Drawing.Point(244, 335);
            sal_comissionsLabel.Name = "sal_comissionsLabel";
            sal_comissionsLabel.Size = new System.Drawing.Size(77, 13);
            sal_comissionsLabel.TabIndex = 13;
            sal_comissionsLabel.Text = "sal comissions:";
            // 
            // sal_comissionsTextBox
            // 
            this.sal_comissionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "sal_comissions", true));
            this.sal_comissionsTextBox.Location = new System.Drawing.Point(342, 332);
            this.sal_comissionsTextBox.Name = "sal_comissionsTextBox";
            this.sal_comissionsTextBox.Size = new System.Drawing.Size(200, 20);
            this.sal_comissionsTextBox.TabIndex = 14;
            // 
            // sal_loanLabel
            // 
            sal_loanLabel.AutoSize = true;
            sal_loanLabel.Location = new System.Drawing.Point(244, 361);
            sal_loanLabel.Name = "sal_loanLabel";
            sal_loanLabel.Size = new System.Drawing.Size(46, 13);
            sal_loanLabel.TabIndex = 15;
            sal_loanLabel.Text = "sal loan:";
            // 
            // sal_loanTextBox
            // 
            this.sal_loanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "sal_loan", true));
            this.sal_loanTextBox.Location = new System.Drawing.Point(342, 358);
            this.sal_loanTextBox.Name = "sal_loanTextBox";
            this.sal_loanTextBox.Size = new System.Drawing.Size(200, 20);
            this.sal_loanTextBox.TabIndex = 16;
            // 
            // sal_deductionsLabel
            // 
            sal_deductionsLabel.AutoSize = true;
            sal_deductionsLabel.Location = new System.Drawing.Point(244, 387);
            sal_deductionsLabel.Name = "sal_deductionsLabel";
            sal_deductionsLabel.Size = new System.Drawing.Size(78, 13);
            sal_deductionsLabel.TabIndex = 17;
            sal_deductionsLabel.Text = "sal deductions:";
            // 
            // sal_deductionsTextBox
            // 
            this.sal_deductionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "sal_deductions", true));
            this.sal_deductionsTextBox.Location = new System.Drawing.Point(342, 384);
            this.sal_deductionsTextBox.Name = "sal_deductionsTextBox";
            this.sal_deductionsTextBox.Size = new System.Drawing.Size(200, 20);
            this.sal_deductionsTextBox.TabIndex = 18;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.payrollDbDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 19;
            // 
            // lblPayslip
            // 
            this.lblPayslip.AutoSize = true;
            this.lblPayslip.Depth = 0;
            this.lblPayslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPayslip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPayslip.Location = new System.Drawing.Point(232, 174);
            this.lblPayslip.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPayslip.Name = "lblPayslip";
            this.lblPayslip.Size = new System.Drawing.Size(89, 18);
            this.lblPayslip.TabIndex = 20;
            this.lblPayslip.Text = "Pay Slip No.";
            // 
            // lblempId
            // 
            this.lblempId.AutoSize = true;
            this.lblempId.Depth = 0;
            this.lblempId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblempId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblempId.Location = new System.Drawing.Point(232, 204);
            this.lblempId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblempId.Name = "lblempId";
            this.lblempId.Size = new System.Drawing.Size(89, 18);
            this.lblempId.TabIndex = 21;
            this.lblempId.Text = "Employee Id";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Depth = 0;
            this.lblfrom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblfrom.Location = new System.Drawing.Point(231, 230);
            this.lblfrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(44, 19);
            this.lblfrom.TabIndex = 22;
            this.lblfrom.Text = "From";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Depth = 0;
            this.lblto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblto.Location = new System.Drawing.Point(231, 256);
            this.lblto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(27, 19);
            this.lblto.TabIndex = 23;
            this.lblto.Text = "To";
            // 
            // WorkingHours
            // 
            this.WorkingHours.AutoSize = true;
            this.WorkingHours.Depth = 0;
            this.WorkingHours.Font = new System.Drawing.Font("Roboto", 11F);
            this.WorkingHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorkingHours.Location = new System.Drawing.Point(105, 283);
            this.WorkingHours.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkingHours.Name = "WorkingHours";
            this.WorkingHours.Size = new System.Drawing.Size(106, 19);
            this.WorkingHours.TabIndex = 24;
            this.WorkingHours.Text = "Working hours";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(105, 309);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Over time";
            // 
            // FrmSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.WorkingHours);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.lblempId);
            this.Controls.Add(this.lblPayslip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.payslip_IdTextBox);
            this.Controls.Add(this.emp_IdComboBox);
            this.Controls.Add(this.from_DateDateTimePicker);
            this.Controls.Add(this.to_DateDateTimePicker);
            this.Controls.Add(sal_working_hoursLabel);
            this.Controls.Add(this.sal_working_hoursTextBox);
            this.Controls.Add(oT_HoursLabel);
            this.Controls.Add(this.oT_HoursTextBox);
            this.Controls.Add(sal_comissionsLabel);
            this.Controls.Add(this.sal_comissionsTextBox);
            this.Controls.Add(sal_loanLabel);
            this.Controls.Add(this.sal_loanTextBox);
            this.Controls.Add(sal_deductionsLabel);
            this.Controls.Add(this.sal_deductionsTextBox);
            this.Controls.Add(this.salaryBindingNavigator);
            this.Name = "FrmSal";
            this.Text = "FrmSal";
            this.Load += new System.EventHandler(this.FrmSal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingNavigator)).EndInit();
            this.salaryBindingNavigator.ResumeLayout(false);
            this.salaryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayrollDbDataSet payrollDbDataSet;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private PayrollDbDataSetTableAdapters.salaryTableAdapter salaryTableAdapter;
        private PayrollDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salaryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salaryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox payslip_IdTextBox;
        private System.Windows.Forms.ComboBox emp_IdComboBox;
        private System.Windows.Forms.DateTimePicker from_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker to_DateDateTimePicker;
        private System.Windows.Forms.TextBox sal_working_hoursTextBox;
        private System.Windows.Forms.TextBox oT_HoursTextBox;
        private System.Windows.Forms.TextBox sal_comissionsTextBox;
        private System.Windows.Forms.TextBox sal_loanTextBox;
        private System.Windows.Forms.TextBox sal_deductionsTextBox;
        private PayrollDbDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel lblPayslip;
        private MaterialSkin.Controls.MaterialLabel lblempId;
        private MaterialSkin.Controls.MaterialLabel lblfrom;
        private MaterialSkin.Controls.MaterialLabel lblto;
        private MaterialSkin.Controls.MaterialLabel WorkingHours;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}