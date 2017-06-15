namespace Tech_Inspection
{
    partial class GAIInspectors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GAIInspectors));
            this.insp = new System.Windows.Forms.DataGridView();
            this.inspectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectGAI_Insp = new Tech_Inspection.lrywxtro_Tech_InspectGAI_Insp();
            this.idGAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.cbGAI = new System.Windows.Forms.ComboBox();
            this.gAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnInsp = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btGAI = new System.Windows.Forms.Button();
            this.btUpl = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectRanks = new Tech_Inspection.lrywxtro_Tech_InspectRanks();
            this.tbGAI = new System.Windows.Forms.TextBox();
            this.tbRank = new System.Windows.Forms.TextBox();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdr = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.ranksTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectRanksTableAdapters.RanksTableAdapter();
            this.gAITableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectGAI_InspTableAdapters.GAITableAdapter();
            this.bithdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorsTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectGAI_InspTableAdapters.InspectorsTableAdapter();
            this.Id_inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bith_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGAIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.insp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectGAI_Insp)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnInsp)).BeginInit();
            this.bnInsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectRanks)).BeginInit();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insp
            // 
            this.insp.AllowUserToResizeRows = false;
            this.insp.AutoGenerateColumns = false;
            this.insp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.insp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_inspector,
            this.Surname,
            this.Name,
            this.Mid_name,
            this.Id_rank,
            this.Bith_date,
            this.idGAIDataGridViewTextBoxColumn1});
            this.insp.DataSource = this.inspectorsBindingSource;
            this.insp.Location = new System.Drawing.Point(3, 3);
            this.insp.MultiSelect = false;
            this.insp.Name = "insp";
            this.insp.RowHeadersVisible = false;
            this.insp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.insp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.insp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.insp.Size = new System.Drawing.Size(512, 201);
            this.insp.TabIndex = 0;
            this.insp.SelectionChanged += new System.EventHandler(this.insp_SelectionChanged);
            // 
            // inspectorsBindingSource
            // 
            this.inspectorsBindingSource.DataMember = "Inspectors";
            this.inspectorsBindingSource.DataSource = this.lrywxtro_Tech_InspectGAI_Insp;
            // 
            // lrywxtro_Tech_InspectGAI_Insp
            // 
            this.lrywxtro_Tech_InspectGAI_Insp.DataSetName = "lrywxtro_Tech_InspectGAI_Insp";
            this.lrywxtro_Tech_InspectGAI_Insp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idGAIDataGridViewTextBoxColumn
            // 
            this.idGAIDataGridViewTextBoxColumn.DataPropertyName = "Id_GAI";
            this.idGAIDataGridViewTextBoxColumn.FillWeight = 57.44501F;
            this.idGAIDataGridViewTextBoxColumn.HeaderText = "ГАИ";
            this.idGAIDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idGAIDataGridViewTextBoxColumn.Name = "idGAIDataGridViewTextBoxColumn";
            this.idGAIDataGridViewTextBoxColumn.Width = 509;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbDate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cbGAI);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bnInsp);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btGAI);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btUpl);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.save);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cbRank);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbGAI);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbRank);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbMiddle);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbSurname);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label9);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label8);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.insp);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbAdr);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbTel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.exit);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(652, 333);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(652, 333);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // tbDate
            // 
            this.tbDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inspectorsBindingSource, "Bith_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDate.Location = new System.Drawing.Point(369, 278);
            this.tbDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.tbDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(144, 20);
            this.tbDate.TabIndex = 20;
            this.tbDate.Value = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            this.tbDate.ValueChanged += new System.EventHandler(this.tbDate_ValueChanged);
            // 
            // cbGAI
            // 
            this.cbGAI.DataSource = this.gAIBindingSource;
            this.cbGAI.DisplayMember = "Address";
            this.cbGAI.FormattingEnabled = true;
            this.cbGAI.Location = new System.Drawing.Point(369, 303);
            this.cbGAI.Name = "cbGAI";
            this.cbGAI.Size = new System.Drawing.Size(142, 21);
            this.cbGAI.TabIndex = 21;
            this.cbGAI.ValueMember = "Id_GAI";
            this.cbGAI.SelectedValueChanged += new System.EventHandler(this.cbGAI_SelectedValueChanged);
            // 
            // gAIBindingSource
            // 
            this.gAIBindingSource.DataMember = "GAI";
            this.gAIBindingSource.DataSource = this.lrywxtro_Tech_InspectGAI_Insp;
            // 
            // bnInsp
            // 
            this.bnInsp.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnInsp.BindingSource = this.inspectorsBindingSource;
            this.bnInsp.CountItem = this.bindingNavigatorCountItem;
            this.bnInsp.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnInsp.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnInsp.Location = new System.Drawing.Point(3, 207);
            this.bnInsp.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInsp.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInsp.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInsp.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInsp.Name = "bnInsp";
            this.bnInsp.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInsp.Size = new System.Drawing.Size(255, 25);
            this.bnInsp.TabIndex = 28;
            this.bnInsp.Text = "bindingNavigator1";
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
            // btGAI
            // 
            this.btGAI.Location = new System.Drawing.Point(549, 145);
            this.btGAI.Name = "btGAI";
            this.btGAI.Size = new System.Drawing.Size(75, 23);
            this.btGAI.TabIndex = 25;
            this.btGAI.Text = "ГАИ...";
            this.btGAI.UseVisualStyleBackColor = true;
            this.btGAI.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btUpl
            // 
            this.btUpl.Location = new System.Drawing.Point(565, 274);
            this.btUpl.Name = "btUpl";
            this.btUpl.Size = new System.Drawing.Size(75, 23);
            this.btUpl.TabIndex = 24;
            this.btUpl.Text = "Обновить";
            this.btUpl.UseVisualStyleBackColor = true;
            this.btUpl.Click += new System.EventHandler(this.btUpl_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(565, 245);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 23;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cbRank
            // 
            this.cbRank.DataSource = this.ranksBindingSource;
            this.cbRank.DisplayMember = "Rank_name";
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Location = new System.Drawing.Point(369, 250);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(142, 21);
            this.cbRank.TabIndex = 19;
            this.cbRank.ValueMember = "Id_Rank";
            this.cbRank.SelectedValueChanged += new System.EventHandler(this.cbRank_SelectedValueChanged);
            // 
            // ranksBindingSource
            // 
            this.ranksBindingSource.DataMember = "Ranks";
            this.ranksBindingSource.DataSource = this.lrywxtro_Tech_InspectRanks;
            // 
            // lrywxtro_Tech_InspectRanks
            // 
            this.lrywxtro_Tech_InspectRanks.DataSetName = "lrywxtro_Tech_InspectRanks";
            this.lrywxtro_Tech_InspectRanks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGAI
            // 
            this.tbGAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inspectorsBindingSource, "Id_GAI", true));
            this.tbGAI.Location = new System.Drawing.Point(368, 304);
            this.tbGAI.Name = "tbGAI";
            this.tbGAI.Size = new System.Drawing.Size(142, 20);
            this.tbGAI.TabIndex = 21;
            // 
            // tbRank
            // 
            this.tbRank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inspectorsBindingSource, "Id_rank", true));
            this.tbRank.Location = new System.Drawing.Point(371, 250);
            this.tbRank.Name = "tbRank";
            this.tbRank.Size = new System.Drawing.Size(113, 20);
            this.tbRank.TabIndex = 19;
            // 
            // tbMiddle
            // 
            this.tbMiddle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inspectorsBindingSource, "Mid_name", true));
            this.tbMiddle.Location = new System.Drawing.Point(106, 302);
            this.tbMiddle.MaxLength = 25;
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Size = new System.Drawing.Size(119, 20);
            this.tbMiddle.TabIndex = 18;
            // 
            // tbSurname
            // 
            this.tbSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inspectorsBindingSource, "Surname", true));
            this.tbSurname.Location = new System.Drawing.Point(106, 250);
            this.tbSurname.MaxLength = 25;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(119, 20);
            this.tbSurname.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inspectorsBindingSource, "Name", true));
            this.tbName.Location = new System.Drawing.Point(106, 276);
            this.tbName.MaxLength = 25;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 20);
            this.tbName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Место работы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Дата рождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Звание:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Телефон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Место работы:";
            // 
            // tbAdr
            // 
            this.tbAdr.Location = new System.Drawing.Point(518, 107);
            this.tbAdr.Name = "tbAdr";
            this.tbAdr.ReadOnly = true;
            this.tbAdr.Size = new System.Drawing.Size(129, 20);
            this.tbAdr.TabIndex = 6;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(518, 60);
            this.tbTel.Name = "tbTel";
            this.tbTel.ReadOnly = true;
            this.tbTel.Size = new System.Drawing.Size(129, 20);
            this.tbTel.TabIndex = 5;
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(565, 302);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Закрыть";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.AutoScroll = true;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStripContainer1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(652, 333);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(652, 358);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer2_TopToolStripPanel_Click);
            // 
            // ranksTableAdapter
            // 
            this.ranksTableAdapter.ClearBeforeFill = true;
            // 
            // gAITableAdapter
            // 
            this.gAITableAdapter.ClearBeforeFill = true;
            // 
            // bithdateDataGridViewTextBoxColumn
            // 
            this.bithdateDataGridViewTextBoxColumn.DataPropertyName = "Bith_date";
            this.bithdateDataGridViewTextBoxColumn.FillWeight = 57.44501F;
            this.bithdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bithdateDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.bithdateDataGridViewTextBoxColumn.Name = "bithdateDataGridViewTextBoxColumn";
            this.bithdateDataGridViewTextBoxColumn.Width = 275;
            // 
            // idrankDataGridViewTextBoxColumn
            // 
            this.idrankDataGridViewTextBoxColumn.DataPropertyName = "Id_rank";
            this.idrankDataGridViewTextBoxColumn.FillWeight = 57.44501F;
            this.idrankDataGridViewTextBoxColumn.HeaderText = "Звание";
            this.idrankDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idrankDataGridViewTextBoxColumn.Name = "idrankDataGridViewTextBoxColumn";
            this.idrankDataGridViewTextBoxColumn.Width = 156;
            // 
            // midnameDataGridViewTextBoxColumn
            // 
            this.midnameDataGridViewTextBoxColumn.DataPropertyName = "Mid_name";
            this.midnameDataGridViewTextBoxColumn.FillWeight = 57.44501F;
            this.midnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.midnameDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.midnameDataGridViewTextBoxColumn.Name = "midnameDataGridViewTextBoxColumn";
            this.midnameDataGridViewTextBoxColumn.Width = 134;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 57.44501F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 107;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 355.33F;
            this.surnameDataGridViewTextBoxColumn.Frozen = true;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // idinspectorDataGridViewTextBoxColumn
            // 
            this.idinspectorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idinspectorDataGridViewTextBoxColumn.DataPropertyName = "Id_inspector";
            this.idinspectorDataGridViewTextBoxColumn.FillWeight = 57.44501F;
            this.idinspectorDataGridViewTextBoxColumn.Frozen = true;
            this.idinspectorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idinspectorDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idinspectorDataGridViewTextBoxColumn.Name = "idinspectorDataGridViewTextBoxColumn";
            this.idinspectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idinspectorDataGridViewTextBoxColumn.Width = 40;
            // 
            // inspectorsTableAdapter
            // 
            this.inspectorsTableAdapter.ClearBeforeFill = true;
            // 
            // Id_inspector
            // 
            this.Id_inspector.DataPropertyName = "Id_inspector";
            this.Id_inspector.FillWeight = 61.12375F;
            this.Id_inspector.HeaderText = "ID";
            this.Id_inspector.MinimumWidth = 30;
            this.Id_inspector.Name = "Id_inspector";
            this.Id_inspector.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.FillWeight = 355.33F;
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 100;
            this.Surname.Name = "Surname";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 56.70926F;
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 90;
            this.Name.Name = "Name";
            // 
            // Mid_name
            // 
            this.Mid_name.DataPropertyName = "Mid_name";
            this.Mid_name.FillWeight = 56.70926F;
            this.Mid_name.HeaderText = "Отчество";
            this.Mid_name.MinimumWidth = 90;
            this.Mid_name.Name = "Mid_name";
            // 
            // Id_rank
            // 
            this.Id_rank.DataPropertyName = "Id_rank";
            this.Id_rank.FillWeight = 56.70926F;
            this.Id_rank.HeaderText = "Звание";
            this.Id_rank.MinimumWidth = 60;
            this.Id_rank.Name = "Id_rank";
            // 
            // Bith_date
            // 
            this.Bith_date.DataPropertyName = "Bith_date";
            this.Bith_date.FillWeight = 56.70926F;
            this.Bith_date.HeaderText = "Дата рождения";
            this.Bith_date.MinimumWidth = 90;
            this.Bith_date.Name = "Bith_date";
            // 
            // idGAIDataGridViewTextBoxColumn1
            // 
            this.idGAIDataGridViewTextBoxColumn1.DataPropertyName = "Id_GAI";
            this.idGAIDataGridViewTextBoxColumn1.FillWeight = 56.70926F;
            this.idGAIDataGridViewTextBoxColumn1.HeaderText = "ГАИ";
            this.idGAIDataGridViewTextBoxColumn1.MinimumWidth = 70;
            this.idGAIDataGridViewTextBoxColumn1.Name = "idGAIDataGridViewTextBoxColumn1";
            // 
            // GAIInspectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(652, 358);
            this.Controls.Add(this.toolStripContainer2);
         //   this.Name = "GAIInspectors";
            this.Text = "Инспектора ГАИ";
            this.Load += new System.EventHandler(this.Inspectors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectGAI_Insp)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnInsp)).EndInit();
            this.bnInsp.ResumeLayout(false);
            this.bnInsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectRanks)).EndInit();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView insp;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdr;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGAI;
        private System.Windows.Forms.TextBox tbRank;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button btUpl;
        private System.Windows.Forms.Button btGAI;
        private System.Windows.Forms.BindingNavigator bnInsp;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idGAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbGAI;
        private lrywxtro_Tech_InspectGAI_Insp lrywxtro_Tech_InspectGAI_Insp;
        private lrywxtro_Tech_InspectRanks lrywxtro_Tech_InspectRanks;
        private System.Windows.Forms.BindingSource ranksBindingSource;
        private lrywxtro_Tech_InspectRanksTableAdapters.RanksTableAdapter ranksTableAdapter;
        private System.Windows.Forms.BindingSource gAIBindingSource;
        private lrywxtro_Tech_InspectGAI_InspTableAdapters.GAITableAdapter gAITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inspectorsBindingSource;
        private lrywxtro_Tech_InspectGAI_InspTableAdapters.InspectorsTableAdapter inspectorsTableAdapter;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bith_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGAIDataGridViewTextBoxColumn1;

    }
}

