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
    public partial class Inspections : Form
    {
        public Inspections()
        {
            InitializeComponent();
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//...
        }
        MySqlConnection con = new MySqlConnection();
        private void Inspections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectBooks.Defects' table. You can move, or remove it, as needed.
            this.defectsTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Defects);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectDataSet1.inspectors_all' table. You can move, or remove it, as needed.
            this.inspectors_allTableAdapter.Fill(this.lrywxtro_Tech_InspectDataSet1.inspectors_all);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectDataSet.tech_inps_all' table. You can move, or remove it, as needed.
            this.tech_inps_allTableAdapter.Fill(this.lrywxtro_Tech_InspectDataSet.tech_inps_all);
            // TODO: This line of code loads data into the 'tech_InspectDataSet.Defects' table. You can move, or remove it, as needed.
            this.autosTableAdapter.Fill(this.tech_InspectDataSet.Autos);    
            cbInsp.SelectedItem = tbInsp[2, tbInsp.SelectedRows[0].Index].Value; // tbInspID.Text;
            cbInsp.SelectedValue = tbInsp[2, tbInsp.SelectedRows[0].Index].Value; // tbInspID.Text;
            cbAuto.SelectedItem = tbInsp[4, tbInsp.SelectedRows[0].Index].Value; // tbAutoID.Text;
            cbAuto.SelectedValue = tbInsp[4, tbInsp.SelectedRows[0].Index].Value; // tbAutoID.Text

          //  getDefects();
        }

        private void tbInsp_SelectionChanged(object sender, EventArgs e)
        {
            if (tbInspID.Text.Length != 0 && tbAutoID.Text.Length!=0)
            {
                cbInsp.SelectedItem = tbInspID.Text;
                cbInsp.SelectedValue = tbInspID.Text;
                cbAuto.SelectedItem = tbAutoID.Text;
                cbAuto.SelectedValue = tbAutoID.Text;
            }
            getDefects();
        }

        private void cbInsp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbInsp.SelectedValue != null && tbInspID.Text.Length!=0 &&
                tbInsp.SelectedRows.Count>0)
            {          
                tbInsp[3, tbInsp.SelectedRows[0].Index].Value = cbInsp.Text;
                tbInspID.Text = cbInsp.SelectedValue.ToString();
                tbInsp[2, tbInsp.SelectedRows[0].Index].Value = tbInspID.Text;
            }  
        }

        private void cbAuto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbAuto.SelectedValue != null && tbAutoID.Text.Length!=0 &&
                tbInsp.SelectedRows.Count > 0)
            {
                tbInsp[5, tbInsp.SelectedRows[0].Index].Value = cbAuto.Text;
                tbAutoID.Text = cbAuto.SelectedValue.ToString();
                tbInsp[4, tbInsp.SelectedRows[0].Index].Value = tbAutoID.Text;
            }
        }

        public string getDateFormat(string s)
        {
            string[] str = s.Split('.');
            return (str[2]+"-"+str[1]+"-"+str[0]);
        }

        public void changeInspector()
        {
            string cost = Convert.ToDouble(tbCost.Text).ToString();
            cost = cost.Replace(',','.');
            string command = "UPDATE Inspections SET Id_inspector=" + tbInspID.Text +
                ", Date='"+getDateFormat(tbDate.Text)+
                "', Id_auto="+tbAutoID.Text+", Cost="+cost+
                " WHERE Id_inspection=" +
                 tbInsp[0, tbInsp.SelectedRows[0].Index].Value.ToString() + ";";

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
            }
        }

        bool checkTI()
        {
            double cost;
            if (tbDate.Value > System.DateTime.Now || tbDate.Value < Convert.ToDateTime("01.01.1950"))
            {
                MessageBox.Show("Дата техосмотра задана не корректно");
                tbDate.Focus();
                return false;
            }
            if (!Double.TryParse(tbCost.Text, out cost) || cost < 0)
            {
                MessageBox.Show("Стоимость техосмотра задана не корректно");
                tbCost.Focus();
                return false;
            }
            return true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!checkTI()) return;
            try
            {
                changeInspector();
             //   tbInsp.Refresh();
                btUpd_Click(this, new EventArgs());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }  
        }

        private void btAddAuto_Click(object sender, EventArgs e)
        {
            if (!checkTI()) return;
            string command = "INSERT INTO Inspections(Date, Id_inspector, Id_auto, Cost)" +
                "VALUES ('" + getDateFormat(tbDate.Text) + "'," + tbInspID.Text + "," +
                tbAutoID.Text + "," + Convert.ToDouble(tbCost.Text) + ");";
            MySqlCommand com = new MySqlCommand(command, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            //    tbInsp.Rows[0].Selected = true;
                btUpd_Click(this, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            //
          //  tbInsp.Rows[tbInsp.Rows.Count - 1].Selected = true;
            
        }
        public DataTable dt; 
        private void getDefects()
        {
            dt = new DataTable();
            if (tbInsp.SelectedRows.Count > 0)
            {
                string command = "SELECT Reports.Id_report, Defects.Id_name" +
                                " FROM Defects, Reports " +
                                "WHERE Defects.Id_defect=Reports.Id_defect " +
                                "and Reports.Id_inspection="+
                                tbInsp[0, tbInsp.SelectedRows[0].Index].Value.ToString() + ";";

                MySqlCommand com = new MySqlCommand(command, con);  

                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Clear();
                            lbDef.Items.Clear();
                            dt.Load(dr);

                            for (int i = 0; i < dt.Rows.Count; i++)
                                lbDef.Items.Add(dt.Rows[i][1]);
                        }
                        else
                        {
                            lbDef.Items.Clear();
                            lbDef.Items.Add("Нарушений не обнаружено");
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
        }

        private void bnInsp_RefreshItems(object sender, EventArgs e)
        {
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            try
            {
                this.autosTableAdapter.Fill(this.tech_InspectDataSet.Autos);
                this.inspectors_allTableAdapter.Fill(this.lrywxtro_Tech_InspectDataSet1.inspectors_all);
                this.tech_inps_allTableAdapter.Fill(this.lrywxtro_Tech_InspectDataSet.tech_inps_all);
                this.defectsTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Defects);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelAuto_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM Inspections WHERE Id_inspection="+
                tbInsp[0, tbInsp.SelectedRows[0].Index].Value.ToString()+";";

            MySqlCommand com = new MySqlCommand(command, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                btUpd_Click(this, new EventArgs());
        //        tbInsp.Rows[0].Selected = true;
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

        private void btDelDef_Click(object sender, EventArgs e)
        {
            if (lbDef.SelectedItem != null && lbDef.Items[lbDef.SelectedIndex].ToString()!="Нарушений не обнаружено")
            {
                string id = this.dt.Rows[lbDef.SelectedIndex][0].ToString();
                string command = "DELETE FROM Reports WHERE Id_report=" +
                                id + ";";

                MySqlCommand com = new MySqlCommand(command, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    getDefects();
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

        bool checkUnicDefect(string defect)
        {
            bool pr = true;
            int i = 0;
            while (i < lbDef.Items.Count && pr)
                if (defect == lbDef.Items[i].ToString())
                    pr = false;
                else i++;
            return pr;
        }

        private void btAddDef_Click(object sender, EventArgs e)
        {
            if (!checkUnicDefect(cbDef.Text))
            {
                MessageBox.Show("Этот пункт уже есть в списке неисправностей");
                return;
            }
            if(lbDef.Items[0].ToString()=="Нарушений не обнаружено")
            {
                lbDef.Items.RemoveAt(0);
            }
                int idDef = Convert.ToInt32(cbDef.SelectedValue);
                string command = "INSERT INTO Reports(Id_inspection, Id_defect)" +
                "VALUES (" + tbInsp[0, tbInsp.SelectedRows[0].Index].Value.ToString() +
                "," + idDef.ToString() + ");";

                MySqlCommand com = new MySqlCommand(command, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    getDefects();
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbDate.Value = System.DateTime.Now;
        }
    }
}
