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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//
        }
        MySqlConnection con = new MySqlConnection();
        private void Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tech_InspectDataSet7.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.tech_InspectDataSet7.Workers);
           // if (cbWorkers.Text.Length > 0) getCurWorkerRights(cbWorkers.Text);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void setCurWorkerRights(string log)
        {
            bool pr = false;
            int i = 0;
            while (!pr && i < this.tech_InspectDataSet7.Workers.Rows.Count)
            {
                if (this.tech_InspectDataSet7.Workers.Rows[i][1].ToString() == log)
                {
                    switch (this.tech_InspectDataSet7.Workers.Rows[i][3].ToString())
                    {
                        case "Гость": rbGuest.Checked = true; break;
                        case "Отдел кадров": rbPers.Checked = true; break;
                        case "Инспекция ТО": rbTI.Checked = true; break;
                        case "Регистратура": rbReg.Checked = true;  break;
                        case "Управляющий": rbMan.Checked = true;  break;
                    }
                    pr = true;
                }
                else i++;
            }
        }

        private void cbWorkers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbWorkers.Text.Length > 0) setCurWorkerRights(cbWorkers.Text);
        }

        string getCheckedRight()
        {
            if (rbGuest.Checked) return "Гость";
            else if (rbMan.Checked) return "Управляющий";
            else if (rbPers.Checked) return "Отдел кадров";
            else if (rbReg.Checked) return "Регистратура";
            else return "Инспекция ТО";
        }

        string getRights(string log)
        {
            int i = 0;
            while (i < this.tech_InspectDataSet7.Workers.Rows.Count)
            {
                if (this.tech_InspectDataSet7.Workers.Rows[i][1].ToString() == log)
                {
                    return this.tech_InspectDataSet7.Workers.Rows[i][3].ToString();
                }
                else i++;
            }
            return "notFind";
        }

        private void btSaveRights_Click(object sender, EventArgs e)
        {

            string right = getCheckedRight();
            if (getRights(this.cbWorkers.Text) == "Управляющий" && Program.curUser!="Admin")
            {
                MessageBox.Show("Только админ может изменить права управляющего");
                return;
            }
            if (cbWorkers.Text == "Admin")
            {
                MessageBox.Show("Нельзя изменить права админа");
                return;
            }
            if (cbWorkers.Text.Length > 0)
            {
                string command = "UPDATE Workers SET Rights='" + right +
                    "' WHERE Id_worker=" + cbWorkers.SelectedValue.ToString() + ";";

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
      }

        private void btDel_Click(object sender, EventArgs e)
        {
       /*     if (cbWorkers.Text == Program.curUser)// ...
            {
                MessageBox.Show("Вы не можете удалить активного пользователя");
                return;
            }  */ 
            if (cbWorkers.Text == "Admin")
            {
                MessageBox.Show("Невозможно удалить админа");
                return;
            }
            //get rights of deleted user
            if (getRights(cbWorkDel.Text) == "Управляющий" && Program.curUser != "Admin")
            {
                MessageBox.Show("Только админ может удалить управляющего");
                return;
            }
            if (this.cbWorkDel.Text.Length > 0)
            {
                string command = "DELETE FROM Workers " +
                    " WHERE Id_worker=" + this.cbWorkDel.SelectedValue.ToString() + ";";

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

        int getWorkerId(string log)
        {
            bool pr = false;
            int i = 0;
            while (!pr && i < this.tech_InspectDataSet7.Workers.Rows.Count)
            {
                if (this.tech_InspectDataSet7.Workers.Rows[i][1].ToString() == log)
                {
                    pr = true;
                }
                else i++;
            }
            return Convert.ToInt32(this.tech_InspectDataSet7.Workers.Rows[i][0]);
        }

        private void btSavePass_Click(object sender, EventArgs e)
        {
            if (cbWorkers.Text.Length > 0)
            {
                string command = "UPDATE Workers SET Pass='" + GetHashString(this.tbNewPass.Text) +
                    "' WHERE Id_worker=" + getWorkerId(Program.curUser) + ";";

                MySqlCommand com = new MySqlCommand(command, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    workersTableAdapter.Fill(this.tech_InspectDataSet7.Workers);
                    MessageBox.Show("Пароль был изменен");
                    tbNewPass.Text = "";
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
        }
   }
}

