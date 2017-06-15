namespace Tech_Inspection
{
    partial class Inspections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspections));
            this.tbInsp = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idautoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techinpsallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectDataSet = new Tech_Inspection.lrywxtro_Tech_InspectDataSet();
            this.bnInsp = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbDef = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.cbInsp = new System.Windows.Forms.ComboBox();
            this.inspectorsallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectDataSet1 = new Tech_Inspection.lrywxtro_Tech_InspectDataSet1();
            this.tech_InspectDataSet = new Tech_Inspection.Tech_InspectDataSet();
            this.cbAuto = new System.Windows.Forms.ComboBox();
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autosTableAdapter = new Tech_Inspection.Tech_InspectDataSetTableAdapters.AutosTableAdapter();
            this.tbInspID = new System.Windows.Forms.TextBox();
            this.tbAutoID = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btAddAuto = new System.Windows.Forms.Button();
            this.btDelAuto = new System.Windows.Forms.Button();
            this.btUpd = new System.Windows.Forms.Button();
            this.cbDef = new System.Windows.Forms.ComboBox();
            this.defectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectBooks = new Tech_Inspection.lrywxtro_Tech_InspectBooks();
            this.btAddDef = new System.Windows.Forms.Button();
            this.btDelDef = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.tech_inps_allTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectDataSetTableAdapters.tech_inps_allTableAdapter();
            this.inspectors_allTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectDataSet1TableAdapters.inspectors_allTableAdapter();
            this.defectsTableAdapter1 = new Tech_Inspection.lrywxtro_Tech_InspectBooksTableAdapters.DefectsTableAdapter();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tbInsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinpsallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnInsp)).BeginInit();
            this.bnInsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInsp
            // 
            this.tbInsp.AllowUserToResizeRows = false;
            this.tbInsp.AutoGenerateColumns = false;
            this.tbInsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbInsp.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tbInsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbInsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.inspIDDataGridViewTextBoxColumn,
            this.inspNameDataGridViewTextBoxColumn,
            this.idautoDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.tbInsp.DataSource = this.techinpsallBindingSource;
            this.tbInsp.Location = new System.Drawing.Point(2, 25);
            this.tbInsp.MultiSelect = false;
            this.tbInsp.Name = "tbInsp";
            this.tbInsp.ReadOnly = true;
            this.tbInsp.RowHeadersVisible = false;
            this.tbInsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbInsp.Size = new System.Drawing.Size(511, 163);
            this.tbInsp.TabIndex = 0;
            this.tbInsp.SelectionChanged += new System.EventHandler(this.tbInsp_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 57.38248F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 203.0457F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspIDDataGridViewTextBoxColumn
            // 
            this.inspIDDataGridViewTextBoxColumn.DataPropertyName = "InspID";
            this.inspIDDataGridViewTextBoxColumn.HeaderText = "InspID";
            this.inspIDDataGridViewTextBoxColumn.Name = "inspIDDataGridViewTextBoxColumn";
            this.inspIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inspIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // inspNameDataGridViewTextBoxColumn
            // 
            this.inspNameDataGridViewTextBoxColumn.DataPropertyName = "InspName";
            this.inspNameDataGridViewTextBoxColumn.FillWeight = 79.85728F;
            this.inspNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.inspNameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.inspNameDataGridViewTextBoxColumn.Name = "inspNameDataGridViewTextBoxColumn";
            this.inspNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idautoDataGridViewTextBoxColumn
            // 
            this.idautoDataGridViewTextBoxColumn.DataPropertyName = "Id_auto";
            this.idautoDataGridViewTextBoxColumn.HeaderText = "Id_auto";
            this.idautoDataGridViewTextBoxColumn.Name = "idautoDataGridViewTextBoxColumn";
            this.idautoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idautoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idautoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.FillWeight = 79.85728F;
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер авто";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.FillWeight = 79.85728F;
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techinpsallBindingSource
            // 
            this.techinpsallBindingSource.DataMember = "tech_inps_all";
            this.techinpsallBindingSource.DataSource = this.lrywxtro_Tech_InspectDataSet;
            // 
            // lrywxtro_Tech_InspectDataSet
            // 
            this.lrywxtro_Tech_InspectDataSet.DataSetName = "lrywxtro_Tech_InspectDataSet";
            this.lrywxtro_Tech_InspectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnInsp
            // 
            this.bnInsp.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnInsp.BindingSource = this.techinpsallBindingSource;
            this.bnInsp.CountItem = this.bindingNavigatorCountItem;
            this.bnInsp.DeleteItem = null;
            this.bnInsp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bnInsp.Location = new System.Drawing.Point(0, 0);
            this.bnInsp.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInsp.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInsp.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInsp.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInsp.Name = "bnInsp";
            this.bnInsp.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInsp.Size = new System.Drawing.Size(721, 25);
            this.bnInsp.TabIndex = 1;
            this.bnInsp.Text = "bindingNavigator1";
            this.bnInsp.RefreshItems += new System.EventHandler(this.bnInsp_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // lbDef
            // 
            this.lbDef.FormattingEnabled = true;
            this.lbDef.Location = new System.Drawing.Point(519, 28);
            this.lbDef.Name = "lbDef";
            this.lbDef.Size = new System.Drawing.Size(196, 160);
            this.lbDef.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Инспектор:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авто:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоимость:";
            // 
            // tbCost
            // 
            this.tbCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techinpsallBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbCost.Location = new System.Drawing.Point(127, 235);
            this.tbCost.MaxLength = 15;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(107, 20);
            this.tbCost.TabIndex = 10;
            // 
            // cbInsp
            // 
            this.cbInsp.DataSource = this.inspectorsallBindingSource;
            this.cbInsp.DisplayMember = "FIO";
            this.cbInsp.FormattingEnabled = true;
            this.cbInsp.Location = new System.Drawing.Point(326, 237);
            this.cbInsp.Name = "cbInsp";
            this.cbInsp.Size = new System.Drawing.Size(121, 21);
            this.cbInsp.TabIndex = 11;
            this.cbInsp.ValueMember = "ID";
            this.cbInsp.SelectedValueChanged += new System.EventHandler(this.cbInsp_SelectedValueChanged);
            // 
            // inspectorsallBindingSource
            // 
            this.inspectorsallBindingSource.DataMember = "inspectors_all";
            this.inspectorsallBindingSource.DataSource = this.lrywxtro_Tech_InspectDataSet1;
            // 
            // lrywxtro_Tech_InspectDataSet1
            // 
            this.lrywxtro_Tech_InspectDataSet1.DataSetName = "lrywxtro_Tech_InspectDataSet1";
            this.lrywxtro_Tech_InspectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tech_InspectDataSet
            // 
            this.tech_InspectDataSet.DataSetName = "Tech_InspectDataSet";
            this.tech_InspectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbAuto
            // 
            this.cbAuto.DataSource = this.autosBindingSource;
            this.cbAuto.DisplayMember = "Auto_number";
            this.cbAuto.FormattingEnabled = true;
            this.cbAuto.Location = new System.Drawing.Point(325, 202);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(121, 21);
            this.cbAuto.TabIndex = 12;
            this.cbAuto.ValueMember = "Id_Auto";
            this.cbAuto.SelectedValueChanged += new System.EventHandler(this.cbAuto_SelectedValueChanged);
            // 
            // autosBindingSource
            // 
            this.autosBindingSource.DataMember = "Autos";
            this.autosBindingSource.DataSource = this.tech_InspectDataSet;
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // tbInspID
            // 
            this.tbInspID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techinpsallBindingSource, "InspID", true));
            this.tbInspID.Location = new System.Drawing.Point(328, 238);
            this.tbInspID.Name = "tbInspID";
            this.tbInspID.Size = new System.Drawing.Size(100, 20);
            this.tbInspID.TabIndex = 13;
            // 
            // tbAutoID
            // 
            this.tbAutoID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techinpsallBindingSource, "Id_auto", true));
            this.tbAutoID.Location = new System.Drawing.Point(328, 203);
            this.tbAutoID.Name = "tbAutoID";
            this.tbAutoID.Size = new System.Drawing.Size(100, 20);
            this.tbAutoID.TabIndex = 14;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(268, 280);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAddAuto
            // 
            this.btAddAuto.Location = new System.Drawing.Point(55, 280);
            this.btAddAuto.Name = "btAddAuto";
            this.btAddAuto.Size = new System.Drawing.Size(75, 23);
            this.btAddAuto.TabIndex = 18;
            this.btAddAuto.Text = "Добавить";
            this.btAddAuto.UseVisualStyleBackColor = true;
            this.btAddAuto.Click += new System.EventHandler(this.btAddAuto_Click);
            // 
            // btDelAuto
            // 
            this.btDelAuto.Location = new System.Drawing.Point(160, 280);
            this.btDelAuto.Name = "btDelAuto";
            this.btDelAuto.Size = new System.Drawing.Size(75, 23);
            this.btDelAuto.TabIndex = 17;
            this.btDelAuto.Text = "Удалить";
            this.btDelAuto.UseVisualStyleBackColor = true;
            this.btDelAuto.Click += new System.EventHandler(this.btDelAuto_Click);
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(377, 280);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(75, 23);
            this.btUpd.TabIndex = 19;
            this.btUpd.Text = "Обновить";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // cbDef
            // 
            this.cbDef.DataSource = this.defectsBindingSource1;
            this.cbDef.DisplayMember = "Id_name";
            this.cbDef.FormattingEnabled = true;
            this.cbDef.Location = new System.Drawing.Point(522, 235);
            this.cbDef.Name = "cbDef";
            this.cbDef.Size = new System.Drawing.Size(190, 21);
            this.cbDef.TabIndex = 20;
            this.cbDef.ValueMember = "Id_defect";
            // 
            // defectsBindingSource1
            // 
            this.defectsBindingSource1.DataMember = "Defects";
            this.defectsBindingSource1.DataSource = this.lrywxtro_Tech_InspectBooks;
            // 
            // lrywxtro_Tech_InspectBooks
            // 
            this.lrywxtro_Tech_InspectBooks.DataSetName = "lrywxtro_Tech_InspectBooks";
            this.lrywxtro_Tech_InspectBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btAddDef
            // 
            this.btAddDef.Location = new System.Drawing.Point(640, 202);
            this.btAddDef.Name = "btAddDef";
            this.btAddDef.Size = new System.Drawing.Size(75, 23);
            this.btAddDef.TabIndex = 21;
            this.btAddDef.Text = "Добавить";
            this.btAddDef.UseVisualStyleBackColor = true;
            this.btAddDef.Click += new System.EventHandler(this.btAddDef_Click);
            // 
            // btDelDef
            // 
            this.btDelDef.Location = new System.Drawing.Point(519, 202);
            this.btDelDef.Name = "btDelDef";
            this.btDelDef.Size = new System.Drawing.Size(75, 23);
            this.btDelDef.TabIndex = 22;
            this.btDelDef.Text = "Убрать";
            this.btDelDef.UseVisualStyleBackColor = true;
            this.btDelDef.Click += new System.EventHandler(this.btDelDef_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Неисправности:";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(634, 280);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 24;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tech_inps_allTableAdapter
            // 
            this.tech_inps_allTableAdapter.ClearBeforeFill = true;
            // 
            // inspectors_allTableAdapter
            // 
            this.inspectors_allTableAdapter.ClearBeforeFill = true;
            // 
            // defectsTableAdapter1
            // 
            this.defectsTableAdapter1.ClearBeforeFill = true;
            // 
            // tbDate
            // 
            this.tbDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.techinpsallBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDate.Location = new System.Drawing.Point(127, 204);
            this.tbDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.tbDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(108, 20);
            this.tbDate.TabIndex = 25;
            // 
            // Inspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(721, 313);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btDelDef);
            this.Controls.Add(this.btAddDef);
            this.Controls.Add(this.cbDef);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.cbInsp);
            this.Controls.Add(this.btAddAuto);
            this.Controls.Add(this.btDelAuto);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbAutoID);
            this.Controls.Add(this.tbInspID);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDef);
            this.Controls.Add(this.bnInsp);
            this.Controls.Add(this.tbInsp);
            this.Name = "Inspections";
            this.Text = "Техосмотры";
            this.Load += new System.EventHandler(this.Inspections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbInsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinpsallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnInsp)).EndInit();
            this.bnInsp.ResumeLayout(false);
            this.bnInsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbInsp;
        private System.Windows.Forms.BindingNavigator bnInsp;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ListBox lbDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.ComboBox cbInsp;
        private System.Windows.Forms.ComboBox cbAuto;
        private Tech_InspectDataSet tech_InspectDataSet;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private Tech_InspectDataSetTableAdapters.AutosTableAdapter autosTableAdapter;
        private System.Windows.Forms.TextBox tbInspID;
        private System.Windows.Forms.TextBox tbAutoID;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAddAuto;
        private System.Windows.Forms.Button btDelAuto;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.ComboBox cbDef;
        private System.Windows.Forms.Button btAddDef;
        private System.Windows.Forms.Button btDelDef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClose;
        private lrywxtro_Tech_InspectDataSet lrywxtro_Tech_InspectDataSet;
        private System.Windows.Forms.BindingSource techinpsallBindingSource;
        private lrywxtro_Tech_InspectDataSetTableAdapters.tech_inps_allTableAdapter tech_inps_allTableAdapter;
        private lrywxtro_Tech_InspectDataSet1 lrywxtro_Tech_InspectDataSet1;
        private System.Windows.Forms.BindingSource inspectorsallBindingSource;
        private lrywxtro_Tech_InspectDataSet1TableAdapters.inspectors_allTableAdapter inspectors_allTableAdapter;
        private lrywxtro_Tech_InspectBooks lrywxtro_Tech_InspectBooks;
        private lrywxtro_Tech_InspectBooksTableAdapters.DefectsTableAdapter defectsTableAdapter1;
        private System.Windows.Forms.BindingSource defectsBindingSource1;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}