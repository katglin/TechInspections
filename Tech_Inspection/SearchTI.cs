using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Tech_Inspection
{
    public partial class SearchTI : Form
    {
        public SearchTI()
        {
            InitializeComponent();
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//
        }

        MySqlConnection con = new MySqlConnection();
        DataTable dt = new DataTable();

        private void SearchTI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectOwner.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.lrywxtro_Tech_InspectOwner.Owners);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectGAI_Insp.Inspectors' table. You can move, or remove it, as needed.
            this.inspectorsTableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.Inspectors);

        }

        private void btByInsp_Click(object sender, EventArgs e)
        {
            if (tbInspSurn.Text.Length == 0) { MessageBox.Show("Укажите фамилию инспектора"); return; }
            string command = "TI_ByInsp";
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = command;
            com.Parameters.AddWithValue("@inspSur", tbInspSurn.Text);
            try
            {
                con.Open();
                using (MySqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dt.Clear();
                        dt.Load(dr);

                        this.tblTI.DataSource = null;
                        this.tblTI.Rows.Clear();
                        this.tblTI.DataSource = dt;

                        tblTI.Columns[0].HeaderText = "ID";
                        tblTI.Columns[1].HeaderText = "Номер";
                        tblTI.Columns[2].HeaderText = "Владелец";
                        tblTI.Columns[3].HeaderText = "Дата";
                      //  tblTI.Columns[4].HeaderText = "ID инспектора";
                        tblTI.Columns[4].Visible = false;
                        tblTI.Columns[5].HeaderText = "Инспектор";
                        tblTI.Columns[6].HeaderText = "Стоимость";

                        this.tblTI.Show();
                    }
                    else
                    {
                        MessageBox.Show("Инспектора с такой фамилией не проводити техосмотры"); 
                    }
                }
                con.Close();
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

        private void btByOwn_Click(object sender, EventArgs e)
        {
            if (tbOwnSur.Text.Length == 0) { MessageBox.Show("Укажите фамилию владельца"); return; }
            string command = "TI_ByOwner";
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = command;
            com.Parameters.AddWithValue("@autoOwner", tbOwnSur.Text);
            try
            {
                con.Open();
                using (MySqlDataReader dr = com.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dt.Clear();
                        dt.Load(dr);

                        this.tblTI.DataSource = null;
                        this.tblTI.Rows.Clear();
                        this.tblTI.DataSource = dt;

                        tblTI.Columns[0].HeaderText = "ID";
                        tblTI.Columns[1].HeaderText = "Номер";
                        tblTI.Columns[2].HeaderText = "Владелец";
                        tblTI.Columns[3].HeaderText = "Дата";
                     //   tblTI.Columns[4].HeaderText = "ID инспектора";
                        tblTI.Columns[4].Visible = false;
                        tblTI.Columns[5].HeaderText = "Инспектор";
                        tblTI.Columns[6].HeaderText = "Стоимость";

                        this.tblTI.Show();
                    }
                    else
                    {
                        MessageBox.Show("Автовладелец с такой фамилией не проходил техосмотры");
                    }
                }
                con.Close();
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
