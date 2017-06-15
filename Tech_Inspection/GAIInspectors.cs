using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.Common;
using System.Threading;
using System.Configuration;

namespace Tech_Inspection
{
    public partial class GAIInspectors : Form
    {
        public GAIInspectors()
        {
            InitializeComponent();
        }
        bool isAdded = false;
        private void Inspectors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectGAI_Insp.Inspectors' table. You can move, or remove it, as needed.
            this.inspectorsTableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.Inspectors);
        //    this.inspectorsTableAdapter1.Fill(this.lrywxtro_Tech_InspectGAI_Insp.Inspectors);
            
            this.gAITableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.GAI);
            this.ranksTableAdapter.Fill(this.lrywxtro_Tech_InspectRanks.Ranks);

            setCurGAI();
            cbRank.SelectedItem = tbRank.Text;
            cbRank.SelectedValue = tbRank.Text;
            cbGAI.SelectedItem = tbGAI.Text;
            cbGAI.SelectedValue = tbGAI.Text;
        }

        public void setCurGAI()
        {
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            //string stringConnect = @"server=localhost;user id=root;password=12345;database=abc";
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
         //   con.ConnectionString = conString.ConnectionString;//...

            if (insp.SelectedRows.Count == 0) return;//
            string queryString = @"SELECT * FROM GAI WHERE Id_GAI=" + insp[6, insp.SelectedRows[0].Index].Value + ";";

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = conString.ConnectionString;
                MySqlCommand com = new MySqlCommand(queryString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                            bs.DataSource = dt;
                        }
                        tbTel.Text = dt.Rows[0][1].ToString();
                        tbAdr.Text = dt.Rows[0][2].ToString();
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
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insp_SelectionChanged(object sender, EventArgs e)
        {
            if (isAdded) { isAdded = false; save_Click(this, new EventArgs()); } //
            if (tbRank.Text.Length!=0)
            {
                setCurGAI();
                cbRank.SelectedItem = tbRank.Text;
                cbRank.SelectedValue = tbRank.Text;
                cbGAI.SelectedItem = tbGAI.Text;
                cbGAI.SelectedValue = tbGAI.Text;
            }
        }

        private void cbRank_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRank.SelectedValue!=null)
                tbRank.Text = cbRank.SelectedValue.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                this.inspectorsTableAdapter.Update(lrywxtro_Tech_InspectGAI_Insp.Inspectors);
                btUpl_Click(this, new EventArgs());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btUpl_Click(object sender, EventArgs e)
        {
            this.inspectorsTableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.Inspectors);
            this.gAITableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.GAI);
            this.ranksTableAdapter.Fill(this.lrywxtro_Tech_InspectRanks.Ranks);
            
            if (insp.SelectedRows.Count>0)
            {
                tbRank.Text = insp[4, insp.SelectedRows[0].Index].Value.ToString();
                tbGAI.Text = insp[6, insp.SelectedRows[0].Index].Value.ToString();
                cbRank.SelectedItem = tbRank.Text;
                cbRank.SelectedValue = tbRank.Text;
                cbGAI.SelectedItem = tbGAI.Text;
                cbGAI.SelectedValue = tbGAI.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // btGAI
        {
            (new GAI()).Show();
        }

        private void cbGAI_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbGAI.SelectedValue != null)
                tbGAI.Text = cbGAI.SelectedValue.ToString();
        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tbDate_ValueChanged(object sender, EventArgs e)
        {
            if (System.DateTime.Now.Year - 18 < tbDate.Value.Year)
            {
                MessageBox.Show("Дата рождения не корректна");
                tbDate.Focus();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
       //     save_Click(this, new EventArgs());
      //      insp.Rows[insp.Rows.Count - 1].Selected = true;
            isAdded = true;
            tbSurname.Text = "";
            tbName.Text = "";
            tbMiddle.Text = "";
            tbDate.Value = Convert.ToDateTime("01.01.1985");
            cbGAI.Text = "";
            cbRank.Text = "";
            tbSurname.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            save_Click(this, new EventArgs()); 
        }
    }
}
