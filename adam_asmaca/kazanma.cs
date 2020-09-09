using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca
{
    public partial class kazanma : Form
    {
        public kazanma()
        {
            InitializeComponent();
        }

        private void lblKlavyeTusB_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;

        }

        private void lblKlavyeTusB_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;


        }

        private void lblKlavyeTusB_MouseDown(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.DarkRed;

        }

        private void lblKlavyeTusB_MouseUp(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Black;

        }

        private void lblKlavyeTusB_Click(object sender, EventArgs e)
        {
            frmAnaMenu form11 = new frmAnaMenu();
            form11.Show();
            this.Close();
        }

        private void kazanma_Load(object sender, EventArgs e)
        {

        }
    }
}
