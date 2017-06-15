namespace Tech_Inspection
{
    partial class StartWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWork));
            this.label1 = new System.Windows.Forms.Label();
            this.btInsp = new System.Windows.Forms.Button();
            this.btAut = new System.Windows.Forms.Button();
            this.btTI = new System.Windows.Forms.Button();
            this.btHb = new System.Windows.Forms.Button();
            this.btQuer = new System.Windows.Forms.Button();
            this.btManag = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.llUserRec = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(128, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Техосмотры";
            // 
            // btInsp
            // 
            this.btInsp.Location = new System.Drawing.Point(42, 118);
            this.btInsp.Name = "btInsp";
            this.btInsp.Size = new System.Drawing.Size(118, 32);
            this.btInsp.TabIndex = 2;
            this.btInsp.Text = "Инспектора";
            this.btInsp.UseVisualStyleBackColor = true;
            this.btInsp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAut
            // 
            this.btAut.Location = new System.Drawing.Point(42, 165);
            this.btAut.Name = "btAut";
            this.btAut.Size = new System.Drawing.Size(118, 32);
            this.btAut.TabIndex = 3;
            this.btAut.Text = "Автовладельцы";
            this.btAut.UseVisualStyleBackColor = true;
            this.btAut.Click += new System.EventHandler(this.button2_Click);
            // 
            // btTI
            // 
            this.btTI.Location = new System.Drawing.Point(42, 211);
            this.btTI.Name = "btTI";
            this.btTI.Size = new System.Drawing.Size(118, 32);
            this.btTI.TabIndex = 4;
            this.btTI.Text = "Техосмотры";
            this.btTI.UseVisualStyleBackColor = true;
            this.btTI.Click += new System.EventHandler(this.button3_Click);
            // 
            // btHb
            // 
            this.btHb.Location = new System.Drawing.Point(193, 118);
            this.btHb.Name = "btHb";
            this.btHb.Size = new System.Drawing.Size(120, 32);
            this.btHb.TabIndex = 5;
            this.btHb.Text = "Справочники";
            this.btHb.UseVisualStyleBackColor = true;
            this.btHb.Click += new System.EventHandler(this.button4_Click);
            // 
            // btQuer
            // 
            this.btQuer.Location = new System.Drawing.Point(193, 165);
            this.btQuer.Name = "btQuer";
            this.btQuer.Size = new System.Drawing.Size(120, 32);
            this.btQuer.TabIndex = 6;
            this.btQuer.Text = "Запросы";
            this.btQuer.UseVisualStyleBackColor = true;
            this.btQuer.Click += new System.EventHandler(this.button5_Click);
            // 
            // btManag
            // 
            this.btManag.Location = new System.Drawing.Point(193, 211);
            this.btManag.Name = "btManag";
            this.btManag.Size = new System.Drawing.Size(120, 32);
            this.btManag.TabIndex = 7;
            this.btManag.Text = "Управление";
            this.btManag.UseVisualStyleBackColor = true;
            this.btManag.Click += new System.EventHandler(this.btManag_Click);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(309, 258);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(70, 23);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Выход";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button7_Click);
            // 
            // llUserRec
            // 
            this.llUserRec.AutoSize = true;
            this.llUserRec.Location = new System.Drawing.Point(291, 87);
            this.llUserRec.Name = "llUserRec";
            this.llUserRec.Size = new System.Drawing.Size(88, 13);
            this.llUserRec.TabIndex = 9;
            this.llUserRec.TabStop = true;
            this.llUserRec.Text = "Учетная запись";
            this.llUserRec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUserRec_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartWork
            // 
            this.AcceptButton = this.llUserRec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(391, 290);
            this.Controls.Add(this.llUserRec);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btManag);
            this.Controls.Add(this.btQuer);
            this.Controls.Add(this.btHb);
            this.Controls.Add(this.btTI);
            this.Controls.Add(this.btAut);
            this.Controls.Add(this.btInsp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartWork";
            this.Text = "Техосмотры";
            this.Activated += new System.EventHandler(this.StartWork_Activated);
            this.Load += new System.EventHandler(this.StartWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInsp;
        private System.Windows.Forms.Button btAut;
        private System.Windows.Forms.Button btTI;
        private System.Windows.Forms.Button btHb;
        private System.Windows.Forms.Button btQuer;
        private System.Windows.Forms.Button btManag;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel llUserRec;
    }
}