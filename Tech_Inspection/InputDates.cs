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
    public partial class InputDates : Form
    {
        public InputDates()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime dt1 = Convert.ToDateTime(tbDate1.Text);
                DateTime dt2 = Convert.ToDateTime(tbDate2.Text);

                Program.qu.getDataPeriod(dt1.ToShortDateString(), dt2.ToShortDateString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
