using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tech_Inspection
{
    public partial class GAI : Form
    {
        public GAI()
        {
            InitializeComponent();
        }

        private void GAI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectGAI_Insp.Inspectors' table. You can move, or remove it, as needed.
            this.inspectorsTableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.Inspectors);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectGAI_Insp.GAI' table. You can move, or remove it, as needed.
            this.gAITableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.GAI);
            // TODO: This line of code loads data into the 'tech_InspectDataSet.Inspectors' table. You can move, or remove it, as needed.

            workers.ClearSelection();
        }

        private void workers_SelectionChanged(object sender, EventArgs e)
        {
            workers.ClearSelection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                gAITableAdapter.Update(lrywxtro_Tech_InspectGAI_Insp.GAI);
                inspectorsTableAdapter.Update(lrywxtro_Tech_InspectGAI_Insp.Inspectors);
                btUpd_Click(this, new EventArgs());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            this.inspectorsTableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.Inspectors);
            this.gAITableAdapter.Fill(this.lrywxtro_Tech_InspectGAI_Insp.GAI);
   
        }
    }
}
