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
    public partial class StartWork : Form
    {
        public StartWork()
        {
            InitializeComponent(); 
        }

        void blocAll()
        {
            btInsp.Enabled = false;
            btAut.Enabled = false;
            btTI.Enabled = false;
            btHb.Enabled = false;
            btManag.Enabled = false;
            btQuer.Enabled = false;
        }

        void unblocAll()
        {
            btInsp.Enabled = true;
            btAut.Enabled = true;
            btTI.Enabled = true;
            btHb.Enabled = true;
            btManag.Enabled = true;
            btQuer.Enabled = true;
        }

        void checkRights()
        {
            if (Program.curUser == null)
            {
                blocAll();
            }
            else if (Program.curUserR=="Гость")
            {
                blocAll();
                btQuer.Enabled = true;
            }
            else if (Program.curUserR == "Управляющий")
            {
                unblocAll();
            }
            else if (Program.curUserR == "Отдел кадров")
            {
                btInsp.Enabled = true;
                btAut.Enabled = false;
                btTI.Enabled = false;
                btHb.Enabled = true;
                btManag.Enabled = false;
                btQuer.Enabled = true;
            }
            else if (Program.curUserR == "Инспекция ТО")
            {
                btInsp.Enabled = false;
                btAut.Enabled = false;
                btTI.Enabled = true;
                btHb.Enabled = true;
                btManag.Enabled = false;
                btQuer.Enabled = true;
            }
            else if (Program.curUserR == "Регистратура")
            {
                btInsp.Enabled = false;
                btAut.Enabled = true;
                btTI.Enabled = false;
                btHb.Enabled = true;
                btManag.Enabled = false;
                btQuer.Enabled = true;
            }
        }

        private void StartWork_Load(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GAIInspectors()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Owners()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Inspections()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new HelpBooks()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.qu = new Queries();
            Program.qu.Show();
        }

        private void llUserRec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new UserControl()).Show();
        }

        private void StartWork_Activated(object sender, EventArgs e)
        {
            checkRights();  //...
        }

        private void btManag_Click(object sender, EventArgs e)
        {
            (new Manage()).Show();
        }

        private void StartWork_HelpButtonClicked(object sender, CancelEventArgs e)
        {
          //  Help.ShowHelp(this, "Help.chm",  HelpNavigator.TableOfContents);
        }
    }
}
