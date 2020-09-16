namespace LaklightsPayroll
{
    partial class FrmEmpDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpDetails));
            this.payrollDbDataSet = new LaklightsPayroll.PayrollDbDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new LaklightsPayroll.PayrollDbDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new LaklightsPayroll.PayrollDbDataSetTableAdapters.TableAdapterManager();
            this.departmentsTableAdapter = new LaklightsPayroll.PayrollDbDataSetTableAdapters.DepartmentsTableAdapter();
            this.positionTableAdapter = new LaklightsPayroll.PayrollDbDataSetTableAdapters.PositionTableAdapter();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.emp_name_iniTextBox = new System.Windows.Forms.TextBox();
            this.emp_fnameTextBox = new System.Windows.Forms.TextBox();
            this.emp_lnameTextBox = new System.Windows.Forms.TextBox();
            this.emp_addressTextBox = new System.Windows.Forms.TextBox();
            this.emp_DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emp_emailTextBox = new System.Windows.Forms.TextBox();
            this.emp_TelnoTextBox = new System.Windows.Forms.TextBox();
            this.position_IdComboBox = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_idTextBox = new System.Windows.Forms.TextBox();
            this.hire_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dep_idComboBox = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_photoPictureBox = new System.Windows.Forms.PictureBox();
            this.emp_IdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.empId = new MaterialSkin.Controls.MaterialLabel();
            this.lblininame = new MaterialSkin.Controls.MaterialLabel();
            this.lblFname = new MaterialSkin.Controls.MaterialLabel();
            this.lblDob = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_lname = new MaterialSkin.Controls.MaterialLabel();
            this.lblemail = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelno = new MaterialSkin.Controls.MaterialLabel();
            this.lblposition = new MaterialSkin.Controls.MaterialLabel();
            this.lblmanager = new MaterialSkin.Controls.MaterialLabel();
            this.lblHireDate = new MaterialSkin.Controls.MaterialLabel();
            this.lbldep = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmployee = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnnew = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnsave = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btnsearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnview = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_photoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollDbDataSet
            // 
            this.payrollDbDataSet.DataSetName = "PayrollDbDataSet";
            this.payrollDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.LeavesTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.salaryTableAdapter = null;
            this.tableAdapterManager.TitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LaklightsPayroll.PayrollDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkedhoursTableAdapter = null;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem,
            this.toolStripBack,
            this.toolStripBtnSearch});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 64);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(324, 25);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripBack
            // 
            this.toolStripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBack.Image")));
            this.toolStripBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBack.Name = "toolStripBack";
            this.toolStripBack.Size = new System.Drawing.Size(23, 22);
            this.toolStripBack.Text = "toolStripButton1";
            this.toolStripBack.ToolTipText = "Cancel Update";
            this.toolStripBack.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripBtnSearch
            // 
            this.toolStripBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSearch.Image")));
            this.toolStripBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSearch.Name = "toolStripBtnSearch";
            this.toolStripBtnSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnSearch.Text = "toolStripButton1";
            this.toolStripBtnSearch.Click += new System.EventHandler(this.toolStripBtnSearch_Click);
            // 
            // emp_name_iniTextBox
            // 
            this.emp_name_iniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_name_ini", true));
            this.emp_name_iniTextBox.Location = new System.Drawing.Point(251, 157);
            this.emp_name_iniTextBox.Name = "emp_name_iniTextBox";
            this.emp_name_iniTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_name_iniTextBox.TabIndex = 4;
            // 
            // emp_fnameTextBox
            // 
            this.emp_fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_fname", true));
            this.emp_fnameTextBox.Location = new System.Drawing.Point(251, 183);
            this.emp_fnameTextBox.Name = "emp_fnameTextBox";
            this.emp_fnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_fnameTextBox.TabIndex = 6;
            // 
            // emp_lnameTextBox
            // 
            this.emp_lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_lname", true));
            this.emp_lnameTextBox.Location = new System.Drawing.Point(251, 209);
            this.emp_lnameTextBox.Name = "emp_lnameTextBox";
            this.emp_lnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_lnameTextBox.TabIndex = 8;
            // 
            // emp_addressTextBox
            // 
            this.emp_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_address", true));
            this.emp_addressTextBox.Location = new System.Drawing.Point(251, 235);
            this.emp_addressTextBox.Name = "emp_addressTextBox";
            this.emp_addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_addressTextBox.TabIndex = 10;
            // 
            // emp_DOBDateTimePicker
            // 
            this.emp_DOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "emp_DOB", true));
            this.emp_DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emp_DOBDateTimePicker.Location = new System.Drawing.Point(251, 261);
            this.emp_DOBDateTimePicker.Name = "emp_DOBDateTimePicker";
            this.emp_DOBDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.emp_DOBDateTimePicker.TabIndex = 12;
            // 
            // emp_emailTextBox
            // 
            this.emp_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_email", true));
            this.emp_emailTextBox.Location = new System.Drawing.Point(159, 26);
            this.emp_emailTextBox.Name = "emp_emailTextBox";
            this.emp_emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_emailTextBox.TabIndex = 14;
            // 
            // emp_TelnoTextBox
            // 
            this.emp_TelnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_Telno", true));
            this.emp_TelnoTextBox.Location = new System.Drawing.Point(159, 52);
            this.emp_TelnoTextBox.Name = "emp_TelnoTextBox";
            this.emp_TelnoTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_TelnoTextBox.TabIndex = 16;
            // 
            // position_IdComboBox
            // 
            this.position_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "position_Id", true));
            this.position_IdComboBox.DataSource = this.positionBindingSource;
            this.position_IdComboBox.DisplayMember = "position";
            this.position_IdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position_IdComboBox.FormattingEnabled = true;
            this.position_IdComboBox.Location = new System.Drawing.Point(142, 31);
            this.position_IdComboBox.Name = "position_IdComboBox";
            this.position_IdComboBox.Size = new System.Drawing.Size(200, 21);
            this.position_IdComboBox.TabIndex = 18;
            this.position_IdComboBox.ValueMember = "position_Id";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.payrollDbDataSet;
            // 
            // manager_idTextBox
            // 
            this.manager_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "manager_id", true));
            this.manager_idTextBox.Location = new System.Drawing.Point(142, 58);
            this.manager_idTextBox.Name = "manager_idTextBox";
            this.manager_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.manager_idTextBox.TabIndex = 20;
            // 
            // hire_dateDateTimePicker
            // 
            this.hire_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "hire_date", true));
            this.hire_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hire_dateDateTimePicker.Location = new System.Drawing.Point(142, 84);
            this.hire_dateDateTimePicker.Name = "hire_dateDateTimePicker";
            this.hire_dateDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.hire_dateDateTimePicker.TabIndex = 22;
            // 
            // dep_idComboBox
            // 
            this.dep_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "dep_id", true));
            this.dep_idComboBox.DataSource = this.departmentsBindingSource;
            this.dep_idComboBox.DisplayMember = "dep_name";
            this.dep_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dep_idComboBox.FormattingEnabled = true;
            this.dep_idComboBox.Location = new System.Drawing.Point(142, 110);
            this.dep_idComboBox.Name = "dep_idComboBox";
            this.dep_idComboBox.Size = new System.Drawing.Size(200, 21);
            this.dep_idComboBox.TabIndex = 24;
            this.dep_idComboBox.ValueMember = "dep_Id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.payrollDbDataSet;
            // 
            // emp_photoPictureBox
            // 
            this.emp_photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeeBindingSource, "emp_photo", true));
            this.emp_photoPictureBox.Location = new System.Drawing.Point(27, 52);
            this.emp_photoPictureBox.Name = "emp_photoPictureBox";
            this.emp_photoPictureBox.Size = new System.Drawing.Size(200, 50);
            this.emp_photoPictureBox.TabIndex = 26;
            this.emp_photoPictureBox.TabStop = false;
            // 
            // emp_IdMaskedTextBox
            // 
            this.emp_IdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "emp_Id", true));
            this.emp_IdMaskedTextBox.Location = new System.Drawing.Point(251, 131);
            this.emp_IdMaskedTextBox.Name = "emp_IdMaskedTextBox";
            this.emp_IdMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.emp_IdMaskedTextBox.TabIndex = 27;
            this.emp_IdMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.emp_IdMaskedTextBox_MaskInputRejected);
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Depth = 0;
            this.empId.Font = new System.Drawing.Font("Roboto", 11F);
            this.empId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.empId.Location = new System.Drawing.Point(22, 130);
            this.empId.MouseState = MaterialSkin.MouseState.HOVER;
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(221, 19);
            this.empId.TabIndex = 28;
            this.empId.Text = "Employee Identification number";
            // 
            // lblininame
            // 
            this.lblininame.AutoSize = true;
            this.lblininame.Depth = 0;
            this.lblininame.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblininame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblininame.Location = new System.Drawing.Point(22, 156);
            this.lblininame.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblininame.Name = "lblininame";
            this.lblininame.Size = new System.Drawing.Size(130, 19);
            this.lblininame.TabIndex = 29;
            this.lblininame.Text = "Name with initials";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Depth = 0;
            this.lblFname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFname.Location = new System.Drawing.Point(22, 184);
            this.lblFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(83, 19);
            this.lblFname.TabIndex = 30;
            this.lblFname.Text = "First Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Depth = 0;
            this.lblDob.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDob.Location = new System.Drawing.Point(23, 263);
            this.lblDob.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(92, 19);
            this.lblDob.TabIndex = 33;
            this.lblDob.Text = "Date of birth";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(23, 236);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 19);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Address";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Depth = 0;
            this.lbl_lname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_lname.Location = new System.Drawing.Point(23, 210);
            this.lbl_lname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(82, 19);
            this.lbl_lname.TabIndex = 31;
            this.lbl_lname.Text = "Last Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Depth = 0;
            this.lblemail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblemail.Location = new System.Drawing.Point(23, 27);
            this.lblemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 19);
            this.lblemail.TabIndex = 34;
            this.lblemail.Text = "E-Mail";
            // 
            // lblTelno
            // 
            this.lblTelno.AutoSize = true;
            this.lblTelno.Depth = 0;
            this.lblTelno.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelno.Location = new System.Drawing.Point(22, 51);
            this.lblTelno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelno.Name = "lblTelno";
            this.lblTelno.Size = new System.Drawing.Size(133, 19);
            this.lblTelno.TabIndex = 35;
            this.lblTelno.Text = "Telephone number";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Depth = 0;
            this.lblposition.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblposition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblposition.Location = new System.Drawing.Point(48, 28);
            this.lblposition.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(65, 19);
            this.lblposition.TabIndex = 36;
            this.lblposition.Text = "Position";
            // 
            // lblmanager
            // 
            this.lblmanager.AutoSize = true;
            this.lblmanager.Depth = 0;
            this.lblmanager.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblmanager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblmanager.Location = new System.Drawing.Point(48, 55);
            this.lblmanager.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblmanager.Name = "lblmanager";
            this.lblmanager.Size = new System.Drawing.Size(67, 19);
            this.lblmanager.TabIndex = 37;
            this.lblmanager.Text = "Manager";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Depth = 0;
            this.lblHireDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHireDate.Location = new System.Drawing.Point(48, 82);
            this.lblHireDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(80, 19);
            this.lblHireDate.TabIndex = 38;
            this.lblHireDate.Text = "Hired Date";
            // 
            // lbldep
            // 
            this.lbldep.AutoSize = true;
            this.lbldep.Depth = 0;
            this.lbldep.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbldep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldep.Location = new System.Drawing.Point(47, 109);
            this.lbldep.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldep.Name = "lbldep";
            this.lbldep.Size = new System.Drawing.Size(87, 19);
            this.lbldep.TabIndex = 39;
            this.lbldep.Text = "Department";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Depth = 0;
            this.lblEmployee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmployee.Location = new System.Drawing.Point(276, 63);
            this.lblEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(75, 19);
            this.lblEmployee.TabIndex = 40;
            this.lblEmployee.Text = "Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empId);
            this.groupBox1.Controls.Add(this.lblEmployee);
            this.groupBox1.Controls.Add(this.emp_IdMaskedTextBox);
            this.groupBox1.Controls.Add(this.lblininame);
            this.groupBox1.Controls.Add(this.emp_DOBDateTimePicker);
            this.groupBox1.Controls.Add(this.emp_addressTextBox);
            this.groupBox1.Controls.Add(this.emp_lnameTextBox);
            this.groupBox1.Controls.Add(this.emp_fnameTextBox);
            this.groupBox1.Controls.Add(this.emp_name_iniTextBox);
            this.groupBox1.Controls.Add(this.lblDob);
            this.groupBox1.Controls.Add(this.lblFname);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lbl_lname);
            this.groupBox1.Controls.Add(this.emp_photoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(64, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 301);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblemail);
            this.groupBox2.Controls.Add(this.emp_TelnoTextBox);
            this.groupBox2.Controls.Add(this.emp_emailTextBox);
            this.groupBox2.Controls.Add(this.lblTelno);
            this.groupBox2.Location = new System.Drawing.Point(559, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 97);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblposition);
            this.groupBox3.Controls.Add(this.dep_idComboBox);
            this.groupBox3.Controls.Add(this.hire_dateDateTimePicker);
            this.groupBox3.Controls.Add(this.lbldep);
            this.groupBox3.Controls.Add(this.manager_idTextBox);
            this.groupBox3.Controls.Add(this.lblHireDate);
            this.groupBox3.Controls.Add(this.position_IdComboBox);
            this.groupBox3.Controls.Add(this.lblmanager);
            this.groupBox3.Location = new System.Drawing.Point(559, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 158);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Department Details";
            // 
            // btnnew
            // 
            this.btnnew.AutoSize = true;
            this.btnnew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnnew.Depth = 0;
            this.btnnew.Location = new System.Drawing.Point(484, 515);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnnew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnew.Name = "btnnew";
            this.btnnew.Primary = false;
            this.btnnew.Size = new System.Drawing.Size(42, 36);
            this.btnnew.TabIndex = 44;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(568, 515);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = false;
            this.btnDelete.Size = new System.Drawing.Size(60, 36);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.Depth = 0;
            this.btnsave.Location = new System.Drawing.Point(668, 515);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsave.Name = "btnsave";
            this.btnsave.Primary = false;
            this.btnsave.Size = new System.Drawing.Size(46, 36);
            this.btnsave.TabIndex = 46;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Btnsearch
            // 
            this.Btnsearch.AutoSize = true;
            this.Btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btnsearch.Depth = 0;
            this.Btnsearch.Location = new System.Drawing.Point(763, 515);
            this.Btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btnsearch.Name = "Btnsearch";
            this.Btnsearch.Primary = false;
            this.Btnsearch.Size = new System.Drawing.Size(64, 36);
            this.Btnsearch.TabIndex = 47;
            this.Btnsearch.Text = "Search";
            this.Btnsearch.UseVisualStyleBackColor = true;
            this.Btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // btnview
            // 
            this.btnview.AutoSize = true;
            this.btnview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnview.Depth = 0;
            this.btnview.Location = new System.Drawing.Point(840, 515);
            this.btnview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnview.Name = "btnview";
            this.btnview.Primary = false;
            this.btnview.Size = new System.Drawing.Size(45, 36);
            this.btnview.TabIndex = 48;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(903, 515);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(47, 36);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmEmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 578);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.Btnsearch);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "FrmEmpDetails";
            this.Text = "Employee Details Form";
            this.Load += new System.EventHandler(this.FrmEmpDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_photoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayrollDbDataSet payrollDbDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PayrollDbDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private PayrollDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox emp_name_iniTextBox;
        private System.Windows.Forms.TextBox emp_fnameTextBox;
        private System.Windows.Forms.TextBox emp_lnameTextBox;
        private System.Windows.Forms.TextBox emp_addressTextBox;
        private System.Windows.Forms.DateTimePicker emp_DOBDateTimePicker;
        private System.Windows.Forms.TextBox emp_emailTextBox;
        private System.Windows.Forms.TextBox emp_TelnoTextBox;
        private System.Windows.Forms.ComboBox position_IdComboBox;
        private System.Windows.Forms.TextBox manager_idTextBox;
        private System.Windows.Forms.DateTimePicker hire_dateDateTimePicker;
        private System.Windows.Forms.ComboBox dep_idComboBox;
        private System.Windows.Forms.PictureBox emp_photoPictureBox;
        private System.Windows.Forms.MaskedTextBox emp_IdMaskedTextBox;
        private PayrollDbDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private PayrollDbDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private MaterialSkin.Controls.MaterialLabel empId;
        private MaterialSkin.Controls.MaterialLabel lblininame;
        private MaterialSkin.Controls.MaterialLabel lblFname;
        private MaterialSkin.Controls.MaterialLabel lblDob;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lbl_lname;
        private MaterialSkin.Controls.MaterialLabel lblemail;
        private MaterialSkin.Controls.MaterialLabel lblTelno;
        private MaterialSkin.Controls.MaterialLabel lblposition;
        private MaterialSkin.Controls.MaterialLabel lblmanager;
        private MaterialSkin.Controls.MaterialLabel lblHireDate;
        private MaterialSkin.Controls.MaterialLabel lbldep;
        private MaterialSkin.Controls.MaterialLabel lblEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialFlatButton btnnew;
        private MaterialSkin.Controls.MaterialFlatButton btnDelete;
        private MaterialSkin.Controls.MaterialFlatButton btnsave;
        private System.Windows.Forms.ToolStripButton toolStripBack;
        private MaterialSkin.Controls.MaterialFlatButton Btnsearch;
        private MaterialSkin.Controls.MaterialFlatButton btnview;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
    }
}