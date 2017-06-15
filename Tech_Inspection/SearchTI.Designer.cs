namespace Tech_Inspection
{
    partial class SearchTI
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
            this.tblTI = new System.Windows.Forms.DataGridView();
            this.gbInsp = new System.Windows.Forms.GroupBox();
            this.tbInspSurn = new System.Windows.Forms.ComboBox();
            this.inspectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectGAI_Insp = new Tech_Inspection.lrywxtro_Tech_InspectGAI_Insp();
            this.btByInsp = new System.Windows.Forms.Button();
            this.gbOwner = new System.Windows.Forms.GroupBox();
            this.tbOwnSur = new System.Windows.Forms.ComboBox();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrywxtro_Tech_InspectOwner = new Tech_Inspection.lrywxtro_Tech_InspectOwner();
            this.btByOwn = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.inspectorsTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectGAI_InspTableAdapters.InspectorsTableAdapter();
            this.ownersTableAdapter = new Tech_Inspection.lrywxtro_Tech_InspectOwnerTableAdapters.OwnersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblTI)).BeginInit();
            this.gbInsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectGAI_Insp)).BeginInit();
            this.gbOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTI
            // 
            this.tblTI.AllowUserToAddRows = false;
            this.tblTI.AllowUserToDeleteRows = false;
            this.tblTI.AllowUserToResizeRows = false;
            this.tblTI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTI.Location = new System.Drawing.Point(2, 71);
            this.tblTI.Name = "tblTI";
            this.tblTI.ReadOnly = true;
            this.tblTI.RowHeadersVisible = false;
            this.tblTI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTI.Size = new System.Drawing.Size(615, 210);
            this.tblTI.TabIndex = 0;
            // 
            // gbInsp
            // 
            this.gbInsp.Controls.Add(this.tbInspSurn);
            this.gbInsp.Controls.Add(this.btByInsp);
            this.gbInsp.Location = new System.Drawing.Point(23, 7);
            this.gbInsp.Name = "gbInsp";
            this.gbInsp.Size = new System.Drawing.Size(267, 58);
            this.gbInsp.TabIndex = 1;
            this.gbInsp.TabStop = false;
            this.gbInsp.Text = "По инспектору";
            // 
            // tbInspSurn
            // 
            this.tbInspSurn.DataSource = this.inspectorsBindingSource;
            this.tbInspSurn.DisplayMember = "Surname";
            this.tbInspSurn.FormattingEnabled = true;
            this.tbInspSurn.Location = new System.Drawing.Point(6, 21);
            this.tbInspSurn.Name = "tbInspSurn";
            this.tbInspSurn.Size = new System.Drawing.Size(168, 21);
            this.tbInspSurn.TabIndex = 2;
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
            // btByInsp
            // 
            this.btByInsp.Location = new System.Drawing.Point(181, 19);
            this.btByInsp.Name = "btByInsp";
            this.btByInsp.Size = new System.Drawing.Size(75, 23);
            this.btByInsp.TabIndex = 1;
            this.btByInsp.Text = "Найти";
            this.btByInsp.UseVisualStyleBackColor = true;
            this.btByInsp.Click += new System.EventHandler(this.btByInsp_Click);
            // 
            // gbOwner
            // 
            this.gbOwner.Controls.Add(this.tbOwnSur);
            this.gbOwner.Controls.Add(this.btByOwn);
            this.gbOwner.Location = new System.Drawing.Point(336, 7);
            this.gbOwner.Name = "gbOwner";
            this.gbOwner.Size = new System.Drawing.Size(262, 58);
            this.gbOwner.TabIndex = 2;
            this.gbOwner.TabStop = false;
            this.gbOwner.Text = "По владельцу";
            // 
            // tbOwnSur
            // 
            this.tbOwnSur.DataSource = this.ownersBindingSource;
            this.tbOwnSur.DisplayMember = "Surname";
            this.tbOwnSur.FormattingEnabled = true;
            this.tbOwnSur.Location = new System.Drawing.Point(7, 20);
            this.tbOwnSur.Name = "tbOwnSur";
            this.tbOwnSur.Size = new System.Drawing.Size(163, 21);
            this.tbOwnSur.TabIndex = 1;
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.lrywxtro_Tech_InspectOwner;
            // 
            // lrywxtro_Tech_InspectOwner
            // 
            this.lrywxtro_Tech_InspectOwner.DataSetName = "lrywxtro_Tech_InspectOwner";
            this.lrywxtro_Tech_InspectOwner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btByOwn
            // 
            this.btByOwn.Location = new System.Drawing.Point(176, 19);
            this.btByOwn.Name = "btByOwn";
            this.btByOwn.Size = new System.Drawing.Size(75, 23);
            this.btByOwn.TabIndex = 0;
            this.btByOwn.Text = "Найти";
            this.btByOwn.UseVisualStyleBackColor = true;
            this.btByOwn.Click += new System.EventHandler(this.btByOwn_Click);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(534, 288);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // inspectorsTableAdapter
            // 
            this.inspectorsTableAdapter.ClearBeforeFill = true;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(619, 320);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.gbOwner);
            this.Controls.Add(this.gbInsp);
            this.Controls.Add(this.tblTI);
            this.Name = "SearchTI";
            this.Text = "Найти ТО";
            this.Load += new System.EventHandler(this.SearchTI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTI)).EndInit();
            this.gbInsp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectGAI_Insp)).EndInit();
            this.gbOwner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrywxtro_Tech_InspectOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTI;
        private System.Windows.Forms.GroupBox gbInsp;
        private System.Windows.Forms.GroupBox gbOwner;
        private System.Windows.Forms.Button btByInsp;
        private System.Windows.Forms.Button btByOwn;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox tbInspSurn;
        private lrywxtro_Tech_InspectGAI_Insp lrywxtro_Tech_InspectGAI_Insp;
        private System.Windows.Forms.BindingSource inspectorsBindingSource;
        private lrywxtro_Tech_InspectGAI_InspTableAdapters.InspectorsTableAdapter inspectorsTableAdapter;
        private System.Windows.Forms.ComboBox tbOwnSur;
        private lrywxtro_Tech_InspectOwner lrywxtro_Tech_InspectOwner;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private lrywxtro_Tech_InspectOwnerTableAdapters.OwnersTableAdapter ownersTableAdapter;
    }
}