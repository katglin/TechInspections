namespace Tech_Inspection
{
    partial class GAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GAI));
            this.gai_list = new System.Windows.Forms.DataGridView();
            this.idGAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectGAI_Insp = new Tech_Inspection.lrywxtro_Tech_InspectGAI_Insp();
            this.workers = new System.Windows.Forms.DataGridView();
            this.idinspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorsibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbAdr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btUpd = new System.Windows.Forms.Button();
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
            this.bnGAI = new System.Windows.Forms.BindingNavigator(this.components);
            this.gAITableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectGAI_InspTableAdapters.GAITableAdapter();
            this.inspectorsTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectGAI_InspTableAdapters.InspectorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gai_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectGAI_Insp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnGAI)).BeginInit();
            this.bnGAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // gai_list
            // 
            this.gai_list.AllowUserToResizeRows = false;
            this.gai_list.AutoGenerateColumns = false;
            this.gai_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gai_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gai_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGAIDataGridViewTextBoxColumn,
            this.telnumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.gai_list.DataSource = this.gAIBindingSource;
            this.gai_list.Location = new System.Drawing.Point(6, 28);
            this.gai_list.MultiSelect = false;
            this.gai_list.Name = "gai_list";
            this.gai_list.RowHeadersVisible = false;
            this.gai_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gai_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gai_list.Size = new System.Drawing.Size(431, 150);
            this.gai_list.TabIndex = 0;
            // 
            // idGAIDataGridViewTextBoxColumn
            // 
            this.idGAIDataGridViewTextBoxColumn.DataPropertyName = "Id_GAI";
            this.idGAIDataGridViewTextBoxColumn.FillWeight = 58.60106F;
            this.idGAIDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idGAIDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idGAIDataGridViewTextBoxColumn.Name = "idGAIDataGridViewTextBoxColumn";
            this.idGAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telnumberDataGridViewTextBoxColumn
            // 
            this.telnumberDataGridViewTextBoxColumn.DataPropertyName = "Tel_number";
            this.telnumberDataGridViewTextBoxColumn.FillWeight = 131.7542F;
            this.telnumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telnumberDataGridViewTextBoxColumn.MinimumWidth = 85;
            this.telnumberDataGridViewTextBoxColumn.Name = "telnumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 109.6447F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // gAIBindingSource
            // 
            this.gAIBindingSource.DataMember = "GAI";
            this.gAIBindingSource.DataSource = this.lrywxtro_Tech_InspectGAI_Insp;
            // 
            // lrywxtro_Tech_InspectGAI_Insp
            // 
            this.lrywxtro_Tech_InspectGAI_Insp.DataSetName = "lrywxtro_Tech_InspectGAI_Insp";
            this.lrywxtro_Tech_InspectGAI_Insp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workers
            // 
            this.workers.AllowUserToAddRows = false;
            this.workers.AllowUserToDeleteRows = false;
            this.workers.AllowUserToResizeRows = false;
            this.workers.AutoGenerateColumns = false;
            this.workers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinspectorDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.midnameDataGridViewTextBoxColumn,
            this.idrankDataGridViewTextBoxColumn,
            this.bithdateDataGridViewTextBoxColumn});
            this.workers.DataSource = this.inspectorsibfk1BindingSource;
            this.workers.Location = new System.Drawing.Point(8, 204);
            this.workers.MultiSelect = false;
            this.workers.Name = "workers";
            this.workers.ReadOnly = true;
            this.workers.RowHeadersVisible = false;
            this.workers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workers.ShowCellToolTips = false;
            this.workers.ShowEditingIcon = false;
            this.workers.Size = new System.Drawing.Size(649, 136);
            this.workers.TabIndex = 1;
            this.workers.SelectionChanged += new System.EventHandler(this.workers_SelectionChanged);
            // 
            // idinspectorDataGridViewTextBoxColumn
            // 
            this.idinspectorDataGridViewTextBoxColumn.DataPropertyName = "Id_inspector";
            this.idinspectorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idinspectorDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.idinspectorDataGridViewTextBoxColumn.Name = "idinspectorDataGridViewTextBoxColumn";
            this.idinspectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // midnameDataGridViewTextBoxColumn
            // 
            this.midnameDataGridViewTextBoxColumn.DataPropertyName = "Mid_name";
            this.midnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.midnameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.midnameDataGridViewTextBoxColumn.Name = "midnameDataGridViewTextBoxColumn";
            this.midnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idrankDataGridViewTextBoxColumn
            // 
            this.idrankDataGridViewTextBoxColumn.DataPropertyName = "Id_rank";
            this.idrankDataGridViewTextBoxColumn.HeaderText = "Звание";
            this.idrankDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.idrankDataGridViewTextBoxColumn.Name = "idrankDataGridViewTextBoxColumn";
            this.idrankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bithdateDataGridViewTextBoxColumn
            // 
            this.bithdateDataGridViewTextBoxColumn.DataPropertyName = "Bith_date";
            this.bithdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bithdateDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.bithdateDataGridViewTextBoxColumn.Name = "bithdateDataGridViewTextBoxColumn";
            this.bithdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorsibfk1BindingSource
            // 
            this.inspectorsibfk1BindingSource.DataMember = "Inspectors_ibfk_1";
            this.inspectorsibfk1BindingSource.DataSource = this.gAIBindingSource;
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Location = new System.Drawing.Point(582, 349);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сотрудники отделения ГАИ:";
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.save.Location = new System.Drawing.Point(399, 349);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tbTel
            // 
            this.tbTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAIBindingSource, "Tel_number", true));
            this.tbTel.Location = new System.Drawing.Point(465, 58);
            this.tbTel.MaxLength = 25;
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(148, 20);
            this.tbTel.TabIndex = 6;
            // 
            // tbAdr
            // 
            this.tbAdr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAIBindingSource, "Address", true));
            this.tbAdr.Location = new System.Drawing.Point(465, 104);
            this.tbAdr.MaxLength = 100;
            this.tbAdr.Name = "tbAdr";
            this.tbAdr.Size = new System.Drawing.Size(148, 20);
            this.tbAdr.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес:";
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(492, 349);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(75, 23);
            this.btUpd.TabIndex = 10;
            this.btUpd.Text = "Обновить";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
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
            // bnGAI
            // 
            this.bnGAI.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnGAI.BindingSource = this.gAIBindingSource;
            this.bnGAI.CountItem = this.bindingNavigatorCountItem;
            this.bnGAI.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnGAI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnGAI.Location = new System.Drawing.Point(0, 0);
            this.bnGAI.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnGAI.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnGAI.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnGAI.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnGAI.Name = "bnGAI";
            this.bnGAI.PositionItem = this.bindingNavigatorPositionItem;
            this.bnGAI.Size = new System.Drawing.Size(664, 25);
            this.bnGAI.TabIndex = 11;
            this.bnGAI.Text = "bindingNavigator1";
            // 
            // gAITableAdapter
            // 
            this.gAITableAdapter.ClearBeforeFill = true;
            // 
            // inspectorsTableAdapter
            // 
            this.inspectorsTableAdapter.ClearBeforeFill = true;
            // 
            // GAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(664, 377);
            this.Controls.Add(this.bnGAI);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdr);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.workers);
            this.Controls.Add(this.gai_list);
            this.Name = "GAI";
            this.Text = "ГАИ";
            this.Load += new System.EventHandler(this.GAI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gai_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectGAI_Insp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnGAI)).EndInit();
            this.bnGAI.ResumeLayout(false);
            this.bnGAI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gai_list;
        private System.Windows.Forms.DataGridView workers;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbAdr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bnGAI;
        private lrywxtro_Tech_InspectGAI_Insp lrywxtro_Tech_InspectGAI_Insp;
        private System.Windows.Forms.BindingSource gAIBindingSource;
        private lrywxtro_Tech_InspectGAI_InspTableAdapters.GAITableAdapter gAITableAdapter;
        private System.Windows.Forms.BindingSource inspectorsibfk1BindingSource;
        private lrywxtro_Tech_InspectGAI_InspTableAdapters.InspectorsTableAdapter inspectorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithdateDataGridViewTextBoxColumn;
    }
}