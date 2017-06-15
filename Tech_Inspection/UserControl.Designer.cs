namespace Tech_Inspection
{
    partial class UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_InspectDataSet7 = new Tech_Inspection.Tech_InspectDataSet7();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNewLogin = new System.Windows.Forms.TextBox();
            this.btReg = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.llAdminCab = new System.Windows.Forms.LinkLabel();
            this.llExit = new System.Windows.Forms.LinkLabel();
            this.techInspectDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Tech_Inspection.Tech_InspectDataSet7TableAdapters.WorkersTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet7)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techInspectDataSet7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEnter);
            this.groupBox1.Controls.Add(this.cbLogin);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(65, 78);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(75, 23);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Войти";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // cbLogin
            // 
            this.cbLogin.DataSource = this.workersBindingSource;
            this.cbLogin.DisplayMember = "Login";
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(75, 20);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(127, 21);
            this.cbLogin.TabIndex = 4;
            this.cbLogin.ValueMember = "Id_worker";
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
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(75, 50);
            this.tbPass.MaxLength = 15;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(127, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNewLogin);
            this.groupBox2.Controls.Add(this.btReg);
            this.groupBox2.Controls.Add(this.tbNewPass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(246, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регистрация";
            // 
            // tbNewLogin
            // 
            this.tbNewLogin.Location = new System.Drawing.Point(75, 20);
            this.tbNewLogin.MaxLength = 15;
            this.tbNewLogin.Name = "tbNewLogin";
            this.tbNewLogin.Size = new System.Drawing.Size(127, 20);
            this.tbNewLogin.TabIndex = 6;
            // 
            // btReg
            // 
            this.btReg.Location = new System.Drawing.Point(65, 78);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(75, 23);
            this.btReg.TabIndex = 5;
            this.btReg.Text = "Добавить";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(75, 50);
            this.tbNewPass.MaxLength = 15;
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(127, 20);
            this.tbNewPass.TabIndex = 3;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Логин";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(388, 156);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(170, 140);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(128, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Вы не авторизированы!";
            // 
            // llAdminCab
            // 
            this.llAdminCab.AutoSize = true;
            this.llAdminCab.Location = new System.Drawing.Point(13, 140);
            this.llAdminCab.Name = "llAdminCab";
            this.llAdminCab.Size = new System.Drawing.Size(90, 13);
            this.llAdminCab.TabIndex = 9;
            this.llAdminCab.TabStop = true;
            this.llAdminCab.Text = "Личный кабинет";
            this.llAdminCab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdminCab_LinkClicked);
            // 
            // llExit
            // 
            this.llExit.AutoSize = true;
            this.llExit.Location = new System.Drawing.Point(13, 159);
            this.llExit.Name = "llExit";
            this.llExit.Size = new System.Drawing.Size(39, 13);
            this.llExit.TabIndex = 10;
            this.llExit.TabStop = true;
            this.llExit.Text = "Выйти";
            this.llExit.Visible = false;
            this.llExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExit_LinkClicked);
            // 
            // techInspectDataSet7BindingSource
            // 
            this.techInspectDataSet7BindingSource.DataSource = this.tech_InspectDataSet7;
            this.techInspectDataSet7BindingSource.Position = 0;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(471, 185);
            this.Controls.Add(this.llExit);
            this.Controls.Add(this.llAdminCab);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl";
            this.Text = "Учетная запись";
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_InspectDataSet7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techInspectDataSet7BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.LinkLabel llAdminCab;
        private System.Windows.Forms.LinkLabel llExit;
        private Tech_InspectDataSet7 tech_InspectDataSet7;
        private System.Windows.Forms.BindingSource techInspectDataSet7BindingSource;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private Tech_InspectDataSet7TableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.TextBox tbNewLogin;
    }
}