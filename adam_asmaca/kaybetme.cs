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
    public partial class kaybetme : Form
    {
        public kaybetme()
        {
            InitializeComponent();
        }


      


        private void lblYenidenOynat_Click(object sender, EventArgs e)
        {
            frmAnaMenu form111 = new frmAnaMenu();
            form111.Show();
            this.Close();
        }




        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.DarkRed;
        }

        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Red;
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;

        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;

        }



        private void lblKapat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void kaybetme_Load(object sender, EventArgs e)
        {

        }
    }
}
