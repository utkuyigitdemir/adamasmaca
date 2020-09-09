using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace adam_asmaca
{
    public partial class frmSehirler : Form
    {
        public frmSehirler()
        {
            InitializeComponent();
        }


        // ______________  Genel Tanımlar _______________________
        Label[] lbldizi = new Label[8];
        //
        string[] harvler = new string[8];
        //
        string strGizliHarf1;
        string strGizliHarf2;
        string strGizliHarf3;
        string strGizliHarf4;
        string strGizliHarf5;
        string strGizliHarf6;
        string strGizliHarf7;
        string strGizliHarf8;
        int ressayi;
        int skor;
        List<string> sehirlist = new List<string>();
        int kalansehir;
        int randsehir;
        int kaybetme;
        //
        // ________________________________________________________




        private void lblKlavyeTusA_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;

        }


        private void lblKlavyeTusA_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Black;
            this.Cursor = Cursors.Arrow;

        }


        private void lblKlavyeTusA_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.DarkRed;

        }


        private void lblKlavyeTusA_MouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
           //lbl.ForeColor = Color.Red;
            lbl.ForeColor = Color.Black;

        }


        public void Kazanmazamani()
        {
            if (skor == 20)
            {
                harfleriKapat();
                //
                kazanma kazanmaa = new kazanma();
                kazanmaa.Show();
                this.Hide();

            }

        }



        
        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
       



        public void tuslariAc()
        {
            //
            harfleriKapat();
            //
            //
            Wait(1000);
            //
            //
            for (int i = 0; i < Controls.Count; i++)
            {
                Control ctrl = Controls[i];

                if (ctrl.GetType() == typeof(Label) && (ctrl.Name.Length > 12))
                {
                    if (ctrl.Name.Substring(0, 12) == "lblKlavyeTus")
                    {
                        ctrl.ForeColor = Color.Black;
                        ctrl.Enabled = true;                       
                        ctrl.Refresh();
                    }
                }
            }
            //
            label40.Text = "6";
            skor++;
            label42.Text = skor.ToString();
            if (skor != 20 && kaybetme==0)
            {
                Atama();
            }
            

        }





        public void harfleriKapat()
        {

            for (int i = 0; i < Controls.Count; i++)
            {
                Control ctrl = Controls[i];

                if (ctrl.GetType() == typeof(Label) && (ctrl.Name.Length > 12))
                {
                    if (ctrl.Name.Substring(0, 12) == "lblKlavyeTus")
                    {
                        ctrl.ForeColor = Color.Black;
                        ctrl.Enabled = false;
                        ctrl.Refresh();
                    }
                }
            }
        }





        public void Kazaninca()
        {
            if (ressayi == 8)
            {
                if ((label31.Text != "") && (label32.Text != "") && (label33.Text != "") && (label34.Text != "") && (label35.Text != "") && (label36.Text != "") && (label37.Text != "") && (label38.Text != ""))
                {
                    tuslariAc();
                }
            }
            else if (ressayi == 7)
            {
                if ((label31.Text != "") && (label32.Text != "") && (label33.Text != "") && (label34.Text != "") && (label35.Text != "") && (label36.Text != "") && (label37.Text != ""))
                {
                    tuslariAc();
                }
            }
            else if (ressayi == 6)
            {
                if ((label31.Text != "") && (label32.Text != "") && (label33.Text != "") && (label34.Text != "") && (label35.Text != "") && (label36.Text != ""))
                {
                    tuslariAc();
                }
            }
            else if (ressayi == 5)
            {
                if ((label31.Text != "") && (label32.Text != "") && (label33.Text != "") && (label34.Text != "") && (label35.Text != ""))
                {
                    tuslariAc();
                }
            }
        }


        public void Kaybedince()
        {
            int kalanhak = Convert.ToInt32(label40.Text);
            if (kalanhak == 6)
            {
                kafa.Hide();
                vucut.Hide();
                sagkol.Hide();
                solkol.Hide();
                sagbacak.Hide();
                solbacak.Hide();
                
            }
            else if (kalanhak == 5)
            {
                kafa.Show();
                vucut.Hide();
                sagkol.Hide();
                solkol.Hide();
                sagbacak.Hide();
                solbacak.Hide();
                
            }
            else if (kalanhak == 4)
            {
                kafa.Show();
                vucut.Show();
                sagkol.Hide();
                solkol.Hide();
                sagbacak.Hide();
                solbacak.Hide();
            }
            else if (kalanhak == 3)
            {
                kafa.Show();
                vucut.Show();
                sagkol.Show();
                solkol.Hide();
                sagbacak.Hide();
                solbacak.Hide();
            }
            else if (kalanhak == 2)
            {
                kafa.Show();
                vucut.Show();
                sagkol.Show();
                solkol.Show();
                sagbacak.Hide();
                solbacak.Hide();
            }
            else if (kalanhak == 1)
            {
                kafa.Show();
                vucut.Show();
                sagkol.Show();
                solkol.Show();
                sagbacak.Show();
                solbacak.Hide();
            }
            else if (kalanhak == 0)
            {
                kafa.Show();
                vucut.Show();
                sagkol.Show();
                solkol.Show();
                sagbacak.Show();
                solbacak.Show();
                kaybetme++;
                //
                harfleriKapat();
                //
                Wait(1000);
                kelimeyiGoster();
                Wait(3000);
                //
                kaybetme kaybetme1 = new kaybetme();
                kaybetme1.Show();
                this.Hide();
            }


        }



        public void Atama()
        {
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
            label37.Text = "";
            label38.Text = "";
            pictureBox0.Show();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();



            string gelensehir = "";
            int sayma = 0;

            int sayac = 0;
            foreach (var elm in harvler)
            {
                harvler[sayac] = "";
                sayac++;
            }



            Random sehirrand = new Random();
            randsehir = sehirrand.Next(0, kalansehir);
            if (kalansehir != 0)
            {
                gelensehir = sehirlist[randsehir];

            }

            sehirlist.Remove(gelensehir);
            kalansehir--;
            foreach (var item in gelensehir)
            {
                harvler[sayma] = item.ToString();
                sayma++;
            }

            strGizliHarf1 = harvler[0];
            strGizliHarf2 = harvler[1];
            strGizliHarf3 = harvler[2];
            strGizliHarf4 = harvler[3];
            strGizliHarf5 = harvler[4];
            strGizliHarf6 = harvler[5];
            strGizliHarf7 = harvler[6];
            strGizliHarf8 = harvler[7];

            if (gelensehir.Length == 8)
            {
                ressayi = 8;
                pictureBox0.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();
                pictureBox7.Show();
            }
            else if (gelensehir.Length == 7)
            {
                pictureBox0.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();
                pictureBox7.Hide();
                ressayi = 7;

            }
            else if (gelensehir.Length == 6)
            {
                pictureBox0.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();

                pictureBox7.Hide();
                pictureBox6.Hide();
                ressayi = 6;
            }
            else if (gelensehir.Length == 5)
            {
                pictureBox0.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox7.Hide();
                pictureBox6.Hide();
                pictureBox5.Hide();
                ressayi = 5;

                

            }
        }

        
        

        private void sehirler_Load(object sender, EventArgs e)
        {

            daragaci.Show();
            kafa.Hide();
            vucut.Hide();
            sagkol.Hide();
            solkol.Hide();
            sagbacak.Hide();
            solbacak.Hide();
            skor = 0; ;
            kalansehir = 20;
            kaybetme = 0;

            if (Globals.glblKategori=="sehirler")
            {
                sehirlist.Add("BAYBURT");
                sehirlist.Add("İZMİR");
                sehirlist.Add("SİVAS");
                sehirlist.Add("ANKARA");
                sehirlist.Add("İSTANBUL");
                sehirlist.Add("ÇORUM");
                sehirlist.Add("YOZGAT");
                sehirlist.Add("ÇANKIRI");
                sehirlist.Add("ELAZIĞ");
                sehirlist.Add("ERZURUM");
                sehirlist.Add("HAKKARİ");
                sehirlist.Add("BURDUR");
                sehirlist.Add("DÜZCE");
                sehirlist.Add("ANTALYA");
                sehirlist.Add("MUĞLA");
                sehirlist.Add("ADANA");
                sehirlist.Add("HATAY");
                sehirlist.Add("SAMSUN");
                sehirlist.Add("SİNOP");
                sehirlist.Add("TRABZON");
                lblKategori.Text = "iller";
            }
            else if (Globals.glblKategori == "ulkeler")
            {
                sehirlist.Add("FRANSA");
                sehirlist.Add("ALMANYA");
                sehirlist.Add("İSVİÇRE");
                sehirlist.Add("TÜRKİYE");
                sehirlist.Add("İSVEÇ");
                sehirlist.Add("NORVEÇ");
                sehirlist.Add("ESTONYA");
                sehirlist.Add("SURİYE");
                sehirlist.Add("KANADA");
                sehirlist.Add("RUSYA");
                sehirlist.Add("LİBYA");
                sehirlist.Add("MISIR");
                sehirlist.Add("İTALYA");
                sehirlist.Add("KARADAĞ");
                sehirlist.Add("BELÇİKA");
                sehirlist.Add("ANDORRA");
                sehirlist.Add("VATİKAN");
                sehirlist.Add("İSPANYA");
                sehirlist.Add("BREZİLYA");
                sehirlist.Add("CEZAYİR");
                lblKategori.Text = "Ülkeler";
            }
            else if (Globals.glblKategori == "tdk")
            {

            }
            Atama();
        }


        public void harfleriKotrolEt(string gelenHarf, object gelenNesne)
        {
            string harf = gelenHarf;
            //
            Label lbl = gelenNesne as Label;
            

            if ((harf == strGizliHarf1) || (harf == strGizliHarf2) || (harf == strGizliHarf3) || (harf == strGizliHarf4) || (harf == strGizliHarf5) || (harf == strGizliHarf6) || (harf == strGizliHarf7) || (harf == strGizliHarf8))
            {

                if (harf == strGizliHarf1)
                {
                    label31.Text = harf;
                    
                }
                if (harf == strGizliHarf2)
                {
                    label32.Text = harf;

                }
                if (harf == strGizliHarf3)
                {
                    label33.Text = harf;

                }
                if (harf == strGizliHarf4)
                {
                    label34.Text = harf;

                }
                if (harf == strGizliHarf5)
                {
                    label35.Text = harf;

                }
                if (harf == strGizliHarf6)
                {
                    label36.Text = harf;

                }
                if (harf == strGizliHarf7)
                {
                    label37.Text = harf;

                }
                if (harf == strGizliHarf8)
                {
                    label38.Text = harf;

                }
            }
            else
            {
                int kalanhak = Convert.ToInt32(label40.Text);
                kalanhak--;
                label40.Text = kalanhak.ToString();
                //
            }

            lbl.Enabled = false;

            Kazaninca();
            Kazanmazamani();
            Kaybedince();
        }

      

        public void kelimeyiGoster()
        {
            label31.Text = strGizliHarf1;
            label32.Text = strGizliHarf2;
            label33.Text = strGizliHarf3;
            label34.Text = strGizliHarf4;
            label35.Text = strGizliHarf5;
            label36.Text = strGizliHarf6;
            label37.Text = strGizliHarf7;
            label38.Text = strGizliHarf8;

        }




        private void lblKlavyeTusA_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusA.Text, lblKlavyeTusA);
        }

        private void lblKlavyeTusB_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusB.Text, lblKlavyeTusB);

        }

        private void lblKlavyeTusC_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusC.Text, lblKlavyeTusC);

        }

        private void lblKlavyeTusCH_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusCH.Text, lblKlavyeTusCH);

        }

        private void lblKlavyeTusD_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusD.Text, lblKlavyeTusD);

        }

        private void lblKlavyeTusE_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusE.Text, lblKlavyeTusE);

        }

        private void lblKlavyeTusF_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusF.Text, lblKlavyeTusF);
        }

        private void lblKlavyeTusG_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusG.Text, lblKlavyeTusG);

        }

        private void lblKlavyeTusGH_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusGH.Text, lblKlavyeTusGH);

        }

        private void lblKlavyeTusH_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusH.Text, lblKlavyeTusH);

        }

        private void lblKlavyeTusI_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusI.Text, lblKlavyeTusI);

        }

        private void lblKlavyeTusIH_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusIH.Text, lblKlavyeTusIH);

        }

        private void lblKlavyeTusJ_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusJ.Text, lblKlavyeTusJ);


        }

        private void lblKlavyeTusK_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusK.Text, lblKlavyeTusK);

        }

        private void lblKlavyeTusL_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusL.Text, lblKlavyeTusL);


        }

        private void lblKlavyeTusM_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusM.Text, lblKlavyeTusM);

        }

        private void lblKlavyeTusN_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusN.Text, lblKlavyeTusN);


        }

        private void lblKlavyeTusO_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusO.Text, lblKlavyeTusO);

        }

        private void lblKlavyeTusOH_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusOH.Text, lblKlavyeTusOH);

        }

        private void lblKlavyeTusP_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusP.Text, lblKlavyeTusP);


        }

        private void lblKlavyeTusR_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusR.Text, lblKlavyeTusR);

        }

        private void lblKlavyeTusS_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusS.Text, lblKlavyeTusS);

        }

        private void lblKlavyeTusSH_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusSH.Text, lblKlavyeTusSH);

        }

        private void lblKlavyeTusT_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusT.Text, lblKlavyeTusT);

        }

        private void lblKlavyeTusU_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusU.Text, lblKlavyeTusU);

        }

        private void lblKlavyeTusUH_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusUH.Text, lblKlavyeTusUH);

        }

        private void lblKlavyeTusV_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusV.Text, lblKlavyeTusV);


        }

        private void lblKlavyeTusY_Click(object sender, EventArgs e)
        {

            harfleriKotrolEt(lblKlavyeTusY.Text, lblKlavyeTusY);

        }

        private void lblKlavyeTusZ_Click(object sender, EventArgs e)
        {
            harfleriKotrolEt(lblKlavyeTusZ.Text, lblKlavyeTusZ);


        }


        private void lblAnaMenuyeGit_Click(object sender, EventArgs e)
        {

            Form AnaForm = new frmAnaMenu();
            AnaForm.Show();
            this.Close();
        }

       



        

    }
    
       
}
