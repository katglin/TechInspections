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
using System.Data.OleDb;
using System.Configuration;



namespace Tech_Inspection
{
    public partial class Owners : Form
    {
  //      DataSet dsAutos = new DataSet();

        public Owners()
        {
            InitializeComponent();
            ConnectionStringSettings conString;
            conString = ConfigurationManager.ConnectionStrings["Tech_Inspection.Properties.Settings.Tech_InspectConnectionString"];
            con.ConnectionString = conString.ConnectionString;//
        }

        private void Owners_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectOwner.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter1.Fill(this.lrywxtro_Tech_InspectOwner.Owners);
            // TODO: This line of code loads data into the 'tech_InspectDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.tech_InspectDataSet.Models);
            // TODO: This line of code loads data into the 'tech_InspectDataSet.Owners' table. You can move, or remove it, as needed.
       //     this.ownersTableAdapter.Fill(this.tech_InspectDataSet.Owners);
            getAutos();
        }

        public DataSet dsAutos = new DataSet();
        BindingSource bs = new BindingSource();
        MySqlDataAdapter AutosdataAdapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlConnection con = new MySqlConnection();//
        public void getAutos()
        {
            if (tbOwners.SelectedRows.Count > 0)
            {
                //    DataSet dsAutos = new DataSet();
                string command = "SELECT Id_auto AS ID, Auto_number AS Number, Models.Model_name AS Model, " +
                                "Year AS Year, Cost AS Cost FROM Autos, Models " +
                                "WHERE Models.Id_model=Autos.Id_model " +
                                "and Autos.Id_owner=" + tbOwners[0, tbOwners.SelectedRows[0].Index].Value + ";";

                
                MySqlCommand com = new MySqlCommand(command, con);
            //    com.Parameters.Add("@Auto_number", MySqlDbType.VarChar, 10, tbAutos);   
                AutosdataAdapter.SelectCommand = com; 
                    
                AutosdataAdapter.Fill(dsAutos); //
                    try
                    {
                        con.Open();
                        using (MySqlDataReader dr = com.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                dt.Clear();
                                dt.Load(dr);

                                dsAutos.Tables.Clear();
                                dsAutos.Tables.Add(dt);
                                bs.DataSource = dsAutos.Tables[0];

                                tbAutos.DataSource = bs;

                                tbAutos.Columns[0].ReadOnly = true;
                                bnAutos.BindingSource = bs;

                            }
                            else
                            {
                                tbAutos.DataSource = null;
                                tbAutos.Rows.Clear();    
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

        private void tbOwners_SelectionChanged(object sender, EventArgs e)
        {
            if (tbOwners.SelectedRows.Count > 0)
            {
                getAutos();
                setCurAuto();
            }
        }

        public void setCurAuto()
        {
            if (tbAutos.SelectedRows.Count > 0)
            {
                tbNum.Text = tbAutos[1, tbAutos.SelectedRows[0].Index].Value.ToString();     
                tbYear.Text = tbAutos[3, tbAutos.SelectedRows[0].Index].Value.ToString(); 
                tbCost.Text = tbAutos[4, tbAutos.SelectedRows[0].Index].Value.ToString();
                cbModels.SelectedValue = tbAutos[2, tbAutos.SelectedRows[0].Index].Value.ToString();
            }
            else 
            {
                tbNum.Text = "";
                tbYear.Text = "";
                tbCost.Text = "";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.ownersTableAdapter1.Update(this.lrywxtro_Tech_InspectOwner.Owners);
            SqlDataAdapter da = new SqlDataAdapter();
            //--
            btUpd_Click(this, new EventArgs());
        }
        private void btUpd_Click(object sender, EventArgs e)
        {
            this.ownersTableAdapter1.Fill(this.lrywxtro_Tech_InspectOwner.Owners);
            tbOwners.Rows[0].Selected = true;
            this.modelsTableAdapter.Fill(this.tech_InspectDataSet.Models);
            getAutos();
            setCurAuto();
        }

        private void tbAutos_SelectionChanged(object sender, EventArgs e)
        {
            setCurAuto();
        }
                
        public static int getModelID(string model, DataTable dt)
        {
            int id = 0;

       //     tech_InspectDataSet.Models.Rows.Count 

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (model == dt.Rows[i][1].ToString())
                {
                    return Convert.ToInt32(dt.Rows[i][0]);
                }
            }
            return id;  
        }

        bool checkAuto()
        {
            double cost;
            int year;
            if (!Double.TryParse(tbCost.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Не корректно задана стоимость");
                tbCost.Focus();
                return false;
            }
            if (!Int32.TryParse(tbYear.Text, out year) || year<1950 || year>System.DateTime.Now.Year)
            {
                MessageBox.Show("Не корректно задан год выпуска");
                tbYear.Focus();
                return false;
            }
            return true;
        }

        private void btSaveAuto_Click(object sender, EventArgs e)
        {
            int modelID = Owners.getModelID(cbModels.SelectedValue.ToString(), tech_InspectDataSet.Models);

            if (!checkAuto()) return; 

            string command = "UPDATE Autos SET Auto_number='" +
                tbNum.Text + "',Id_model=" + modelID.ToString() + ",Year=" + tbYear.Text +
                ",Cost=" + ((tbCost.Text.ToString()).Replace(',', '.')) + ",Id_owner=" + tbOwners[0, tbOwners.SelectedRows[0].Index].Value.ToString() +
                " WHERE Id_Auto=" + tbAutos[0, tbAutos.SelectedRows[0].Index].Value.ToString() + ";";

            MySqlCommand com = new MySqlCommand(command, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                getAutos();
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

        private void btAddAuto_Click(object sender, EventArgs e)
        {
            int modelID = Owners.getModelID(cbModels.SelectedValue.ToString(), tech_InspectDataSet.Models);
            if (!checkAuto()) return;
            string command = "INSERT INTO Autos(Auto_number, Id_model, Year, Cost, Id_owner)" +
                "VALUES ('" + tbNum.Text + "'," + modelID.ToString() + "," + tbYear.Text +
                "," + ((tbCost.Text.ToString()).Replace(',', '.')) + "," + 
                tbOwners[0, tbOwners.SelectedRows[0].Index].Value.ToString() + ");";

            MySqlCommand com = new MySqlCommand(command, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
               getAutos();
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

        private void btDelAuto_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM Autos WHERE Id_Auto=" + 
                    tbAutos[0, tbAutos.SelectedRows[0].Index].Value.ToString() + ";";

            MySqlCommand com = new MySqlCommand(command, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                getAutos();
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

        private void btAddOwner_Click(object sender, EventArgs e)
        {
            (new AddOwner()).Show();
        }

        private void Owners_Activated(object sender, EventArgs e)
        {
            btSave_Click(this, new EventArgs());
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            btSave_Click(this, new EventArgs());
        }
    }
}
