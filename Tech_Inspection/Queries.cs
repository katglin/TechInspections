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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
            tblContact.Parent = this;
            tblContact.BringToFront();
            tblContact.Location = new Point(10,62);

            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//
        }

        MySqlConnection con = new MySqlConnection();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        private void Queries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_nViews.tech_inps_cars_cost' table. You can move, or remove it, as needed.
            this.tech_inps_cars_costTableAdapter.Fill(this.lrywxtro_nViews.tech_inps_cars_cost);
            // TODO: This line of code loads data into the 'lrywxtro_nViews.own_auto_stat' table. You can move, or remove it, as needed.
            this.own_auto_statTableAdapter.Fill(this.lrywxtro_nViews.own_auto_stat);
            // TODO: This line of code loads data into the 'lrywxtro_nViews.own_insp_last' table. You can move, or remove it, as needed.
            this.own_insp_lastTableAdapter.Fill(this.lrywxtro_nViews.own_insp_last);
            // TODO: This line of code loads data into the 'lrywxtro_nViews.own_insp_stat' table. You can move, or remove it, as needed.
            this.inspec_stat_allTableAdapter.Fill(this.lrywxtro_nViews.inspec_stat_all);
            // TODO: This line of code loads data into the 'lrywxtro_nViews.bad_result' table. You can move, or remove it, as needed.
            this.bad_resultTableAdapter.Fill(this.lrywxtro_nViews.bad_result);
            // TODO: This line of code loads data into the 'lrywxtro_nViews.gai_list_all' table. You can move, or remove it, as needed.
            this.gai_list_allTableAdapter.Fill(this.lrywxtro_nViews.gai_list_all);
            // TODO: This line of code loads data into the 'lrywxtro_nViews.good_work_result' table. You can move, or remove it, as needed.
            this.good_work_resultTableAdapter.Fill(this.lrywxtro_nViews.good_work_result);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectDataSet2.Bithdays' table. You can move, or remove it, as needed.
            this.bithdaysTableAdapter.Fill(this.lrywxtro_Tech_InspectDataSet2.Bithdays);


            hideAll();
            if (Program.curUserR == "Регистратура")
            {
                this.tabs_queries.SelectedIndex = 1;
            }
            else if (Program.curUserR == "Инспекция ТО")
            {
                this.tabs_queries.SelectedIndex = 2;
            }
            else if (Program.curUserR == "Отдел кадров")
            {
                this.tabs_queries.SelectedIndex = 0;
            }
        }

        private void hideAll()
        {
            tblInspWorkRes.Hide();
            tblIncStat.Hide();
            tblNoRes.Hide();
            tblGAI.Hide();
            tblLastTI.Hide();
            tblOwnInspStat.Hide();
            tblContact.Hide();
            tblExpCarTI.Hide();
            tblPeriod.Hide();
        }

        private void btWorkRes_Click(object sender, EventArgs e)
        {
            hideAll();
            tblInspWorkRes.Show();
        }

        private void btIncStat_Click(object sender, EventArgs e)
        {
            hideAll();
            tblIncStat.Show();
        }

        private void btNoRes_Click(object sender, EventArgs e)
        {
            hideAll();
            tblNoRes.Show();
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            this.tech_inps_cars_costTableAdapter.Fill(this.lrywxtro_nViews.tech_inps_cars_cost);
            this.own_auto_statTableAdapter.Fill(this.lrywxtro_nViews.own_auto_stat);
            this.own_insp_lastTableAdapter.Fill(this.lrywxtro_nViews.own_insp_last);
            this.inspec_stat_allTableAdapter.Fill(this.lrywxtro_nViews.inspec_stat_all);
            this.bad_resultTableAdapter.Fill(this.lrywxtro_nViews.bad_result);
            this.gai_list_allTableAdapter.Fill(this.lrywxtro_nViews.gai_list_all);
            this.good_work_resultTableAdapter.Fill(this.lrywxtro_nViews.good_work_result);
            this.bithdaysTableAdapter.Fill(this.lrywxtro_Tech_InspectDataSet2.Bithdays);
        }

        private void btRepGAI_Click(object sender, EventArgs e)
        {
            hideAll();
            tblGAI.Show();
        }

        private void btLastTI_Click(object sender, EventArgs e)
        {
            hideAll();
            tblLastTI.Show();
        }

        private void btOwnStat_Click(object sender, EventArgs e)
        {
            hideAll();
            tblOwnInspStat.Show();
        }

        private void btContact_Click(object sender, EventArgs e)
        {
            hideAll();
            tblContact.Show();
        }

        private void btExpCarTI_Click(object sender, EventArgs e)
        {
            hideAll();
            tblExpCarTI.Show();
        }

        private void btPeriod_Click(object sender, EventArgs e)
        {
            (new InputDates()).Show();
            hideAll();
         //   tblPeriod.Show();
        }

        public void getDataPeriod(string d1, string d2)
        { 
            string command = "TI_BetwDates";
            d1 = getDateFormat(d1);
            d2 = getDateFormat(d2);
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = command;
            com.Parameters.AddWithValue("@date1", d1);
       //     com.Parameters["date1"].Value = "'" + d1 + "'";
            com.Parameters.AddWithValue("@date2", d2);
       //     com.Parameters["date2"].Value = "'"+d2+"'";
            try
            {
               con.Open();
               using (MySqlDataReader dr = com.ExecuteReader())
               {
                   if (dr.HasRows)
                   {
                       dt.Clear();
                       dt.Load(dr);

                       ds.Tables.Clear();
                       ds.Tables.Add(dt);
                       bs.DataSource = ds.Tables[0];

                       this.tblPeriod.DataSource = null;
                       this.tblPeriod.Rows.Clear();
                       this.tblPeriod.DataSource = bs;

                       tblPeriod.Columns[0].HeaderText = "ID";
                       tblPeriod.Columns[1].HeaderText = "Дата";
                       tblPeriod.Columns[2].HeaderText = "Инспектор";
                       tblPeriod.Columns[3].HeaderText = "Номер";
                       tblPeriod.Columns[4].HeaderText = "Стоимость";

                       this.tblPeriod.Show();
                     //  MessageBox.Show("");
                   }
                   else
                   { 
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

        public string getDateFormat(string s)
        {
            string[] str = s.Split('.');
            return (str[2] + "-" + str[1] + "-" + str[0]);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            (new SearchTI()).Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabs_queries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.curUserR == "Регистратура")
            {
                this.tabs_queries.SelectedIndex = 1;
            }
            else if (Program.curUserR == "Инспекция ТО")
            {
                this.tabs_queries.SelectedIndex = 2;
            }
            else if (Program.curUserR == "Отдел кадров")
            {
                this.tabs_queries.SelectedIndex = 0;
            }
        }
    }
}
