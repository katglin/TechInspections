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
    public partial class HelpBooks : Form
    {
        public HelpBooks()
        {
            InitializeComponent();
        }

        private void HelpBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectBooks.Defects' table. You can move, or remove it, as needed.
            this.defectsTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Defects);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectBooks.Ranks' table. You can move, or remove it, as needed.
            this.ranksTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Ranks);
            // TODO: This line of code loads data into the 'lrywxtro_Tech_InspectBooks.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Models);
            // TODO: This line of code loads data into the 'tech_InspectDataSet.Defects' table. You can move, or remove it, as needed.
         
            if (Program.curUserR == "Регистратура")
            {
                tabHelp.SelectedIndex = 0;
            }
            else if (Program.curUserR == "Инспекция ТО")
            {
                tabHelp.SelectedIndex = 2;
            }
            else if (Program.curUserR == "Отдел кадров")
            {
                tabHelp.SelectedIndex = 1;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {  
            this.modelsTableAdapter1.Update(lrywxtro_Tech_InspectBooks.Models);
            this.ranksTableAdapter1.Update(lrywxtro_Tech_InspectBooks.Ranks);
            this.defectsTableAdapter1.Update(lrywxtro_Tech_InspectBooks.Defects);
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            this.defectsTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Defects);
            this.ranksTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Ranks);
            this.modelsTableAdapter1.Fill(this.lrywxtro_Tech_InspectBooks.Models);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.curUserR == "Регистратура")
            {
                tabHelp.SelectedIndex = 0;
            }
            else if (Program.curUserR == "Инспекция ТО")
            {
                tabHelp.SelectedIndex = 2;
            }
            else if (Program.curUserR == "Отдел кадров")
            {
                tabHelp.SelectedIndex = 1;
            }
        }
    }
}
