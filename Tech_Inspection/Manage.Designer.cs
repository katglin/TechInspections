namespace Tech_Inspection
{
    partial class Manage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSaveRights = new System.Windows.Forms.Button();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbTI = new System.Windows.Forms.RadioButton();
            this.rbReg = new System.Windows.Forms.RadioButton();
            this.rbPers = new System.Windows.Forms.RadioButton();
            this.rbGuest = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWorkers = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_InspectDataSet7 = new Tech_Inspection.Tech_InspectDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.workersTableAdapter = new Tech_Inspection.Tech_InspectDataSet7TableAdapters.WorkersTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbWorkDel = new System.Windows.Forms.ComboBox();
            this.btDel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.btSavePass = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet7)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSaveRights);
            this.groupBox1.Controls.Add(this.rbMan);
            this.groupBox1.Controls.Add(this.rbTI);
            this.groupBox1.Controls.Add(this.rbReg);
            this.groupBox1.Controls.Add(this.rbPers);
            this.groupBox1.Controls.Add(this.rbGuest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbWorkers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение прав";
            // 
            // btSaveRights
            // 
            this.btSaveRights.Location = new System.Drawing.Point(76, 200);
            this.btSaveRights.Name = "btSaveRights";
            this.btSaveRights.Size = new System.Drawing.Size(75, 23);
            this.btSaveRights.TabIndex = 8;
            this.btSaveRights.Text = "Сохранить";
            this.btSaveRights.UseVisualStyleBackColor = true;
            this.btSaveRights.Click += new System.EventHandler(this.btSaveRights_Click);
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(87, 161);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(98, 17);
            this.rbMan.TabIndex = 7;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Управляющий";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbTI
            // 
            this.rbTI.AutoSize = true;
            this.rbTI.Location = new System.Drawing.Point(87, 138);
            this.rbTI.Name = "rbTI";
            this.rbTI.Size = new System.Drawing.Size(99, 17);
            this.rbTI.TabIndex = 6;
            this.rbTI.TabStop = true;
            this.rbTI.Text = "Инспекция ТО";
            this.rbTI.UseVisualStyleBackColor = true;
            // 
            // rbReg
            // 
            this.rbReg.AutoSize = true;
            this.rbReg.Location = new System.Drawing.Point(87, 115);
            this.rbReg.Name = "rbReg";
            this.rbReg.Size = new System.Drawing.Size(94, 17);
            this.rbReg.TabIndex = 5;
            this.rbReg.TabStop = true;
            this.rbReg.Text = "Регистратура";
            this.rbReg.UseVisualStyleBackColor = true;
            // 
            // rbPers
            // 
            this.rbPers.AutoSize = true;
            this.rbPers.Location = new System.Drawing.Point(87, 89);
            this.rbPers.Name = "rbPers";
            this.rbPers.Size = new System.Drawing.Size(95, 17);
            this.rbPers.TabIndex = 4;
            this.rbPers.TabStop = true;
            this.rbPers.Text = "Отдел кадров";
            this.rbPers.UseVisualStyleBackColor = true;
            // 
            // rbGuest
            // 
            this.rbGuest.AutoSize = true;
            this.rbGuest.Location = new System.Drawing.Point(87, 65);
            this.rbGuest.Name = "rbGuest";
            this.rbGuest.Size = new System.Drawing.Size(54, 17);
            this.rbGuest.TabIndex = 3;
            this.rbGuest.TabStop = true;
            this.rbGuest.Text = "Гость";
            this.rbGuest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Доступ";
            // 
            // cbWorkers
            // 
            this.cbWorkers.DataSource = this.workersBindingSource;
            this.cbWorkers.DisplayMember = "Login";
            this.cbWorkers.FormattingEnabled = true;
            this.cbWorkers.Location = new System.Drawing.Point(87, 27);
            this.cbWorkers.Name = "cbWorkers";
            this.cbWorkers.Size = new System.Drawing.Size(136, 21);
            this.cbWorkers.TabIndex = 1;
            this.cbWorkers.ValueMember = "Id_worker";
            this.cbWorkers.SelectedValueChanged += new System.EventHandler(this.cbWorkers_SelectedValueChanged);
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.tech_InspectDataSet7;
            // 
            // tech_InspectDataSet7
            // 
            this.tech_InspectDataSet7.DataSetName = "Tech_InspectDataSet7";
            this.tech_InspectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbWorkDel);
            this.groupBox2.Controls.Add(this.btDel);
            this.groupBox2.Location = new System.Drawing.Point(269, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление сотрудника";
            // 
            // cbWorkDel
            // 
            this.cbWorkDel.DataSource = this.workersBindingSource;
            this.cbWorkDel.DisplayMember = "Login";
            this.cbWorkDel.FormattingEnabled = true;
            this.cbWorkDel.Location = new System.Drawing.Point(30, 27);
            this.cbWorkDel.Name = "cbWorkDel";
            this.cbWorkDel.Size = new System.Drawing.Size(142, 21);
            this.cbWorkDel.TabIndex = 1;
            this.cbWorkDel.ValueMember = "Id_worker";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(67, 66);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 0;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNewPass);
            this.groupBox3.Controls.Add(this.btSavePass);
            this.groupBox3.Location = new System.Drawing.Point(269, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение пароля";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(30, 46);
            this.tbNewPass.MaxLength = 15;
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(142, 20);
            this.tbNewPass.TabIndex = 1;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // btSavePass
            // 
            this.btSavePass.Location = new System.Drawing.Point(76, 84);
            this.btSavePass.Name = "btSavePass";
            this.btSavePass.Size = new System.Drawing.Size(75, 23);
            this.btSavePass.TabIndex = 0;
            this.btSavePass.Text = "Сохранить";
            this.btSavePass.UseVisualStyleBackColor = true;
            this.btSavePass.Click += new System.EventHandler(this.btSavePass_Click);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(394, 257);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Выход";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(481, 283);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manage";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbTI;
        private System.Windows.Forms.RadioButton rbReg;
        private System.Windows.Forms.RadioButton rbPers;
        private System.Windows.Forms.RadioButton rbGuest;
        private Tech_InspectDataSet7 tech_InspectDataSet7;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private Tech_InspectDataSet7TableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Button btSaveRights;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btSavePass;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox cbWorkDel;
        private System.Windows.Forms.TextBox tbNewPass;
    }
}