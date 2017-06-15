using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySql.Data;
using System.Security.Cryptography;
using System.Configuration;

namespace Tech_Inspection
{
    public partial class UserControl : Form
    {
        public UserControl()
        {
            InitializeComponent();
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//
        }
        MySqlConnection con = new MySqlConnection();
        private void UserControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tech_InspectDataSet7.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.tech_InspectDataSet7.Workers);
            if (Program.curUser == null) 
            {
                lbStatus.Text = "Вы не авторизированы";
                llExit.Visible = false;
                llAdminCab.Visible = false;
            }
            else 
            {
                llExit.Visible = true;
                lbStatus.Text = "Вы зашли в систему как " + Program.curUser + " (" + Program.curUserR + ")";
            }
            if (Program.curUserR == "Управляющий")
            {
                llAdminCab.Visible = true;
            }
            else { llAdminCab.Visible = false; }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider(); 
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty; 
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
            return hash;
        }

        bool checkUnickLogin(string log)
        {
            bool pr = true;
            int i = 0;
            while (pr && i < this.tech_InspectDataSet7.Workers.Rows.Count)
            {
                if (this.tech_InspectDataSet7.Workers.Rows[i][1].ToString() == log) pr = false;
                else i++;
            }
            return pr;
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            if (tbNewLogin.Text.Length > 0 && tbNewPass.Text.Length > 0)
            { 
                if (checkUnickLogin(tbNewLogin.Text))
                {
                    string command = "INSERT INTO Workers(Login, Pass) VALUES('" +
                        tbNewLogin.Text + "','" + GetHashString(tbNewPass.Text) + "');";

                    MySqlCommand com = new MySqlCommand(command, con);
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        workersTableAdapter.Fill(this.tech_InspectDataSet7.Workers);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Dispose();
                    }
                }
                else { MessageBox.Show("Такой логин уже используется"); }
            }
            else { MessageBox.Show("Логин или пароль не корректны"); }
            tbNewLogin.Text = "";
            tbNewPass.Text = "";
        }

        bool checkPass(string log, string pass)
        {
            bool pr = false;
            int i = 0;
            while (!pr && i < this.tech_InspectDataSet7.Workers.Rows.Count)
            {
                if (this.tech_InspectDataSet7.Workers.Rows[i][1].ToString() == log)
                {
                    if (this.tech_InspectDataSet7.Workers.Rows[i][2].ToString() == pass)
                    {
                        Program.curUser = this.tech_InspectDataSet7.Workers.Rows[i][1].ToString();
                        Program.curUserR = this.tech_InspectDataSet7.Workers.Rows[i][3].ToString();
                        pr = true;
                    }
                    else return false;
                }
                else i++;
            }
            return pr;
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Length > 0)
            {
                if (checkPass(cbLogin.Text.ToString(), GetHashString(tbPass.Text)))
                {
                    lbStatus.Text = "Вы зашли в систему как "+Program.curUser+" ("+Program.curUserR+")";
                    if (Program.curUserR == "Управляющий")
                    {
                        llAdminCab.Visible = true;
                    }
                    llExit.Visible = true;

                }
                else { MessageBox.Show("Неверный пароль"); }
            }
            else { MessageBox.Show("Введите пароль"); }
            tbPass.Text = "";
        }

        private void llExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbStatus.Text = "Вы не авторизированы";
            llExit.Visible = false;
            llAdminCab.Visible = false;
            Program.curUserR = null;
            Program.curUser = null;
        }

        private void llAdminCab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            (new Manage()).Show();
        }
    }
}
