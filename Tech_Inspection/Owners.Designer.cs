namespace Tech_Inspection
{
    partial class Owners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owners));
            this.tbOwners = new System.Windows.Forms.DataGridView();
            this.idownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectOwner = new Tech_Inspection.lrywxtro_Tech_InspectOwner();
            this.tech_InspectDataSet = new Tech_Inspection.Tech_InspectDataSet();
            this.tbAutos = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bnAutos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btSave = new System.Windows.Forms.Button();
            this.btUpd = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter = new Tech_Inspection.Tech_InspectDataSetTableAdapters.ModelsTableAdapter();
            this.btSaveAuto = new System.Windows.Forms.Button();
            this.btDelAuto = new System.Windows.Forms.Button();
            this.btAddAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.ownersTableAdapter1 = new Tech_Inspection.lrywxtro_Tech_InspectOwnerTableAdapters.OwnersTableAdapter();
            this.btAddOwner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnAutos)).BeginInit();
            this.bnAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOwners
            // 
            this.tbOwners.AllowUserToAddRows = false;
            this.tbOwners.AllowUserToResizeRows = false;
            this.tbOwners.AutoGenerateColumns = false;
            this.tbOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idownerDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.midnameDataGridViewTextBoxColumn,
            this.bithdateDataGridViewTextBoxColumn,
            this.telnumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.tbOwners.DataSource = this.ownersBindingSource1;
            this.tbOwners.Location = new System.Drawing.Point(2, 24);
            this.tbOwners.MultiSelect = false;
            this.tbOwners.Name = "tbOwners";
            this.tbOwners.RowHeadersVisible = false;
            this.tbOwners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbOwners.Size = new System.Drawing.Size(713, 150);
            this.tbOwners.TabIndex = 0;
            this.tbOwners.SelectionChanged += new System.EventHandler(this.tbOwners_SelectionChanged);
            // 
            // idownerDataGridViewTextBoxColumn
            // 
            this.idownerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idownerDataGridViewTextBoxColumn.DataPropertyName = "Id_owner";
            this.idownerDataGridViewTextBoxColumn.FillWeight = 41.116F;
            this.idownerDataGridViewTextBoxColumn.Frozen = true;
            this.idownerDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idownerDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idownerDataGridViewTextBoxColumn.Name = "idownerDataGridViewTextBoxColumn";
            this.idownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idownerDataGridViewTextBoxColumn.Width = 40;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 132.8646F;
            this.surnameDataGridViewTextBoxColumn.Frozen = true;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 105.1784F;
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // midnameDataGridViewTextBoxColumn
            // 
            this.midnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.midnameDataGridViewTextBoxColumn.DataPropertyName = "Mid_name";
            this.midnameDataGridViewTextBoxColumn.FillWeight = 124.4422F;
            this.midnameDataGridViewTextBoxColumn.Frozen = true;
            this.midnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.midnameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.midnameDataGridViewTextBoxColumn.Name = "midnameDataGridViewTextBoxColumn";
            // 
            // bithdateDataGridViewTextBoxColumn
            // 
            this.bithdateDataGridViewTextBoxColumn.DataPropertyName = "Bith_date";
            this.bithdateDataGridViewTextBoxColumn.FillWeight = 99.39643F;
            this.bithdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bithdateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.bithdateDataGridViewTextBoxColumn.Name = "bithdateDataGridViewTextBoxColumn";
            // 
            // telnumberDataGridViewTextBoxColumn
            // 
            this.telnumberDataGridViewTextBoxColumn.DataPropertyName = "Tel_number";
            this.telnumberDataGridViewTextBoxColumn.FillWeight = 98.76889F;
            this.telnumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telnumberDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.telnumberDataGridViewTextBoxColumn.Name = "telnumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 98.23348F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // ownersBindingSource1
            // 
            this.ownersBindingSource1.DataMember = "Owners";
            this.ownersBindingSource1.DataSource = this.lrywxtro_Tech_InspectOwner;
            // 
            // lrywxtro_Tech_InspectOwner
            // 
            this.lrywxtro_Tech_InspectOwner.DataSetName = "lrywxtro_Tech_InspectOwner";
            this.lrywxtro_Tech_InspectOwner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tech_InspectDataSet
            // 
            this.tech_InspectDataSet.DataSetName = "Tech_InspectDataSet";
            this.tech_InspectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAutos
            // 
            this.tbAutos.AllowUserToDeleteRows = false;
            this.tbAutos.AllowUserToResizeRows = false;
            this.tbAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbAutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbAutos.Location = new System.Drawing.Point(2, 202);
            this.tbAutos.MultiSelect = false;
            this.tbAutos.Name = "tbAutos";
            this.tbAutos.ReadOnly = true;
            this.tbAutos.RowHeadersVisible = false;
            this.tbAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbAutos.Size = new System.Drawing.Size(408, 150);
            this.tbAutos.TabIndex = 1;
            this.tbAutos.SelectionChanged += new System.EventHandler(this.tbAutos_SelectionChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.ownersBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(717, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bnAutos
            // 
            this.bnAutos.AddNewItem = null;
            this.bnAutos.CountItem = this.bindingNavigatorCountItem1;
            this.bnAutos.DeleteItem = null;
            this.bnAutos.Dock = System.Windows.Forms.DockStyle.None;
            this.bnAutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.bnAutos.Location = new System.Drawing.Point(2, 174);
            this.bnAutos.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bnAutos.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bnAutos.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bnAutos.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bnAutos.Name = "bnAutos";
            this.bnAutos.PositionItem = this.bindingNavigatorPositionItem1;
            this.bnAutos.Size = new System.Drawing.Size(209, 25);
            this.bnAutos.TabIndex = 3;
            this.bnAutos.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(562, 176);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(640, 176);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(75, 23);
            this.btUpd.TabIndex = 5;
            this.btUpd.Text = "Обновить";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(518, 217);
            this.tbNum.MaxLength = 10;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 6;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(518, 285);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 8;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(518, 319);
            this.tbCost.MaxLength = 15;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 20);
            this.tbCost.TabIndex = 9;
            // 
            // cbModels
            // 
            this.cbModels.DataSource = this.modelsBindingSource;
            this.cbModels.DisplayMember = "Model_name";
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(518, 250);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(100, 21);
            this.cbModels.TabIndex = 10;
            this.cbModels.ValueMember = "Model_name";
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.tech_InspectDataSet;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // btSaveAuto
            // 
            this.btSaveAuto.Location = new System.Drawing.Point(638, 217);
            this.btSaveAuto.Name = "btSaveAuto";
            this.btSaveAuto.Size = new System.Drawing.Size(75, 23);
            this.btSaveAuto.TabIndex = 11;
            this.btSaveAuto.Text = "Сохранить";
            this.btSaveAuto.UseVisualStyleBackColor = true;
            this.btSaveAuto.Click += new System.EventHandler(this.btSaveAuto_Click);
            // 
            // btDelAuto
            // 
            this.btDelAuto.Location = new System.Drawing.Point(638, 243);
            this.btDelAuto.Name = "btDelAuto";
            this.btDelAuto.Size = new System.Drawing.Size(75, 23);
            this.btDelAuto.TabIndex = 12;
            this.btDelAuto.Text = "Удалить";
            this.btDelAuto.UseVisualStyleBackColor = true;
            this.btDelAuto.Click += new System.EventHandler(this.btDelAuto_Click);
            // 
            // btAddAuto
            // 
            this.btAddAuto.Location = new System.Drawing.Point(638, 269);
            this.btAddAuto.Name = "btAddAuto";
            this.btAddAuto.Size = new System.Drawing.Size(75, 23);
            this.btAddAuto.TabIndex = 13;
            this.btAddAuto.Text = "Добавить";
            this.btAddAuto.UseVisualStyleBackColor = true;
            this.btAddAuto.Click += new System.EventHandler(this.btAddAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Стоимость";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(638, 316);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 18;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ownersTableAdapter1
            // 
            this.ownersTableAdapter1.ClearBeforeFill = true;
            // 
            // btAddOwner
            // 
            this.btAddOwner.Location = new System.Drawing.Point(484, 176);
            this.btAddOwner.Name = "btAddOwner";
            this.btAddOwner.Size = new System.Drawing.Size(75, 23);
            this.btAddOwner.TabIndex = 19;
            this.btAddOwner.Text = "Добавить...";
            this.btAddOwner.UseVisualStyleBackColor = true;
            this.btAddOwner.Click += new System.EventHandler(this.btAddOwner_Click);
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(717, 353);
            this.Controls.Add(this.btAddOwner);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddAuto);
            this.Controls.Add(this.btDelAuto);
            this.Controls.Add(this.btSaveAuto);
            this.Controls.Add(this.cbModels);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.bnAutos);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tbAutos);
            this.Controls.Add(this.tbOwners);
            this.Name = "Owners";
            this.Text = "Автомобили и их владельцы";
            this.Activated += new System.EventHandler(this.Owners_Activated);
            this.Load += new System.EventHandler(this.Owners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnAutos)).EndInit();
            this.bnAutos.ResumeLayout(false);
            this.bnAutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbOwners;
        private System.Windows.Forms.DataGridView tbAutos;
        private Tech_InspectDataSet tech_InspectDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.BindingNavigator bnAutos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.ComboBox cbModels;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private Tech_InspectDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.Button btSaveAuto;
        private System.Windows.Forms.Button btDelAuto;
        private System.Windows.Forms.Button btAddAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btClose;
        private lrywxtro_Tech_InspectOwner lrywxtro_Tech_InspectOwner;
        private lrywxtro_Tech_InspectOwnerTableAdapters.OwnersTableAdapter ownersTableAdapter1;
        private System.Windows.Forms.BindingSource ownersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAddOwner;
    }
}