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
using System.Configuration;

namespace Tech_Inspection
{
    public partial class AddOwner : Form
    {
        public AddOwner()
        {
            InitializeComponent();
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//
        }
        MySqlConnection con = new MySqlConnection();
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getDateFormat(string s)
        {
            string[] str = s.Split('.');
            return (str[2] + "-" + str[1] + "-" + str[0]);
        }

        bool checkOwner()
        {
            if (tbSurname.Text.Length == 0 || tbName.Text.Length == 0 || tbMiddle.Text.Length == 0 ||
                tbAddr.Text.Length == 0)
            {
                MessageBox.Show("Заполнены не все поля");
                return false;
            }
            if (dtDate.Value.Year+18 > System.DateTime.Now.Year
                || dtDate.Value.Year + 95 < System.DateTime.Now.Year)
            {
                MessageBox.Show("Дата рождения задана не корректно");
                dtDate.Focus();
                return false;
            }
           return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!checkOwner()) return;
            string command = "INSERT INTO Owners(Surname, Name, Mid_name, "+
                            "Bith_date, Tel_number, Address)" +
                "VALUES ('" + tbSurname.Text + "','" + tbName.Text + "','" +
                 tbMiddle.Text + "','" + getDateFormat(dtDate.Text) + "','" + tbTel.Text +"','"+ 
                 tbAddr.Text +  "');";

            MySqlCommand com = new MySqlCommand(command, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
                this.Close();
            }
        }
    }
}
