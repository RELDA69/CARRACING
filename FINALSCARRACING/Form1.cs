using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALSCARRACING
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CAR_RACING carrace = new CAR_RACING();
            carrace.ShowDialog();
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            pnlHelp.BringToFront();
        }

        private void bttnHelpBack_Click(object sender, EventArgs e)
        {
            pnlHelp.SendToBack();
        }
    }
}
