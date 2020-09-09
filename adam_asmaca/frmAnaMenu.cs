using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace adam_asmaca
{

   

    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }


        Form sehirler2 = new frmSehirler();


        private void lblKapat_MouseEnter(object sender, EventArgs e)
        {
            lblKapat.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;

        }

        private void lblKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;

        }

       

        private void lblOyunuBaslat_MouseEnter(object sender, EventArgs e)
        {
            lblOyunuBaslat.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void lblOyunuBaslat_MouseLeave(object sender, EventArgs e)
        {
            lblOyunuBaslat.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        

        public void lblOyunuBaslat_Click(object sender, EventArgs e)
        {
            if (chkKentler.Checked==true)
            {
                Globals.glblKategori = "sehirler";
            }
            else if (chkUlkeler.Checked == true)
            {
                Globals.glblKategori = "ulkeler";
            }
            else if (chkTDK.Checked == true)
            {
                Globals.glblKategori = "tdk";
            }
            //
            sehirler2.Show();
            this.Hide();

        }

        

        private void chkKentler_MouseEnter(object sender, EventArgs e)
        {
            chkKentler.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;


        }

        private void chkKentler_MouseLeave(object sender, EventArgs e)
        {
            chkKentler.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;

        }

        private void chkUlkeler_MouseEnter(object sender, EventArgs e)
        {
            chkUlkeler.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;


        }

        private void chkUlkeler_MouseLeave(object sender, EventArgs e)
        {
            chkUlkeler.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;

        }

        private void chkTDK_MouseEnter(object sender, EventArgs e)
        {
            chkTDK.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;


        }

        private void chkTDK_MouseLeave(object sender, EventArgs e)
        {
            chkTDK.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;

        }

        private void chkUlkeler_Click(object sender, EventArgs e)
        {
            lblOyunuBaslat.Enabled = true;
            chkKentler.Checked = false;
            chkTDK.Checked = false;
            if (chkUlkeler.Checked == false && chkKentler.Checked == false && chkTDK.Checked == false)
            {
                lblOyunuBaslat.Enabled = false;

            }
        }

        private void chkKentler_Click(object sender, EventArgs e)
        {
            lblOyunuBaslat.Enabled = true;
            chkUlkeler.Checked = false;
            chkTDK.Checked = false;
            if (chkUlkeler.Checked == false && chkKentler.Checked == false && chkTDK.Checked == false)
            {
                lblOyunuBaslat.Enabled = false;
            }
        }

        private void chkTDK_Click(object sender, EventArgs e)
        {
            lblOyunuBaslat.Enabled = true;
            chkUlkeler.Checked = false;
            chkKentler.Checked = false;
            if (chkUlkeler.Checked == false && chkKentler.Checked == false && chkTDK.Checked == false)
            {
                lblOyunuBaslat.Enabled = false;
            }
        }

        private void lblOyunuBaslat_MouseDown(object sender, MouseEventArgs e)
        {
            
            lblOyunuBaslat.ForeColor = Color.DarkRed;
        }

        private void lblOyunuBaslat_MouseUp(object sender, MouseEventArgs e)
        {
            
            lblOyunuBaslat.ForeColor = Color.Red;
        }

        private void chkKentler_MouseDown(object sender, MouseEventArgs e)
        {
            
            chkKentler.ForeColor = Color.DarkRed;
        }

        private void chkKentler_MouseUp(object sender, MouseEventArgs e)
        {
            
            chkKentler.ForeColor = Color.Red;
        }

        private void chkTDK_MouseDown(object sender, MouseEventArgs e)
        {

            chkTDK.ForeColor = Color.DarkRed;
        }

        private void chkTDK_MouseUp(object sender, MouseEventArgs e)
        {

            chkTDK.ForeColor = Color.Red;
        }

        private void chkUlkeler_MouseDown(object sender, MouseEventArgs e)
        {
            
            chkUlkeler.ForeColor = Color.DarkRed;
        }

        private void chkUlkeler_MouseUp(object sender, MouseEventArgs e)
        {
            
            chkUlkeler.ForeColor = Color.Red;
        }


        private void lblKapat_MouseDown(object sender, MouseEventArgs e)
        {
            
            lblKapat.ForeColor = Color.DarkRed;
        }

        private void lblKapat_MouseUp(object sender, MouseEventArgs e)
        {
            
            lblKapat.ForeColor = Color.Red;
        }

        
    }



    public static class Globals
    {
        public static String glblKategori = " "; // Modifiable

    }


}
