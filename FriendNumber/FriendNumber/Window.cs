/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:ÖDEV 2
**				ÖĞRENCİ ADI............:Hasan Semih AKTAŞ
**				ÖĞRENCİ NUMARASI.......:B191210037
**                         DERSİN ALINDIĞI GRUP...:B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b191210037_soru2
{
    class Pencerem : Form
    {
        public Pencerem()
        {
            this.Text = "b191210037_soru2";

            Width = 220;
            Height = 250;

            labelX = new Label();
            labelX.Top = 23;
            labelX.Left = 50;
            labelX.Width = 50;
            labelX.Text = "X";

            labelY = new Label();
            labelY.Top = 60;
            labelY.Left = 50;
            labelY.Width = 50;
            labelY.Text = "Y";

            txtX = new TextBox();
            txtX.Top = 20;
            txtX.Left = 100;
            txtX.Width = 50;

            txtY = new TextBox();
            txtY.Top = 60;
            txtY.Left = 100;
            txtY.Width = 50;

            btnArkadas = new Button();
            btnArkadas.Text = "Arkadas Mı?";
            btnArkadas.Top = 100;
            btnArkadas.Left = 50;
            btnArkadas.Width = 100;

            btnSon = new Button();
            btnSon.Text = "SON";
            btnSon.Top = 140;
            btnSon.Left = 50;
            btnSon.Width = 100;

            Controls.Add(txtX);
            Controls.Add(txtY);
            Controls.Add(btnArkadas);
            Controls.Add(labelX);
            Controls.Add(labelY);
            Controls.Add(btnSon);

            btnArkadas.Click += BtnArkadas_Click;
            btnSon.Click += BtnSon_Click;

        }

        private TextBox txtX;
        private TextBox txtY;
        private Label labelX;
        private Label labelY;
        private Button btnArkadas;
        private Button btnSon;
        private Label lblX2;
        private Label lblY2;
        private ListBox lstX;
        private ListBox lstY;
        private Label lblSonuc;
        private Label lblSonucX;
        private Label lblSonucY;
        private Label lblArkadas;
        int sayac = 1;
        void BtnArkadas_Click(object sender, EventArgs e)
        {

            if (sayac == 1)
            {
                if (txtX.Text != string.Empty && txtY.Text != string.Empty)
                { 
                    Width = 400;
                    Height = 300;

                    lblX2 = new Label();
                    lblX2.Top = 20;
                    lblX2.Left = 200;
                    lblX2.Width = 50;
                    lblX2.Text = "X";
                    Controls.Add(lblX2);

                    lblY2 = new Label();
                    lblY2.Top = 20;
                    lblY2.Left = 260;
                    lblY2.Width = 50;
                    lblY2.Text = "Y";
                    Controls.Add(lblY2);

                    lstX = new ListBox();
                    lstX.Top = 45;
                    lstX.Left = 180;
                    lstX.Width = 50;
                    lstX.Height = 130;
                    Controls.Add(lstX);

                    lstY = new ListBox();
                    lstY.Top = 45;
                    lstY.Left = 240;
                    lstY.Width = 50;
                    lstY.Height = 130;
                    Controls.Add(lstY);

                    int xSayısı = 0;
                 
                    xSayısı = Convert.ToInt32(txtX.Text);

                    int sonuc1 = 0;

                    for (int çarpan = 1; çarpan < xSayısı; çarpan++)
                    {
                       if (xSayısı % çarpan == 0)
                       {
                                lstX.Items.Add(çarpan);
                                sonuc1 += çarpan;

                       }
                    }
                    int ySayısı = Convert.ToInt32(txtY.Text);
                    int sonuc2 = 0;
                    for (int çarpan = 1; çarpan < ySayısı; çarpan++)
                    {
                        if (ySayısı % çarpan == 0)
                        {
                                lstY.Items.Add(çarpan);
                                sonuc2 += çarpan;

                        }
                    }

                    lblSonuc = new Label();
                    lblSonuc.Top = 180;
                    lblSonuc.Left = 110;
                    lblSonuc.Width = 65;
                    lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblSonuc.Text = "Sonuclar";
                    Controls.Add(lblSonuc);

                    lblSonucX = new Label();
                    lblSonucX.Top = 180;
                    lblSonucX.Left = 180;
                    lblSonucX.Width = 50;
                    lblSonucX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblSonucX.Text = Convert.ToString(sonuc1);
                    Controls.Add(lblSonucX);

                    lblSonucY = new Label();
                    lblSonucY.Top = 180;
                    lblSonucY.Left = 240;
                    lblSonucY.Width = 50;
                    lblSonucY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblSonucY.Text = Convert.ToString(sonuc2);
                    Controls.Add(lblSonucY);

                    lblArkadas = new Label();
                    lblArkadas.Top = 210;
                    lblArkadas.Left = 110;
                    lblArkadas.Width = 140;
                    lblArkadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    if (xSayısı == sonuc2 && ySayısı == sonuc1)
                    {
                        lblArkadas.Text = "Bu iki sayı arkadaş";
                    }
                    else
                    {
                        lblArkadas.Text = "Bu iki sayı arkadaş değil";
                    }
                    Controls.Add(lblArkadas);
                    sayac++;

                }
                else
                {
                    MessageBox.Show("Lutfen Boş Bırakmayınız");
                    sayac = 1;
                }
            }
            else
            {
                lstX.Items.Clear();
                lstY.Items.Clear();
                int xSayısı = Convert.ToInt32(txtX.Text);
                int sonuc1 = 0;
                for (int çarpan = 1; çarpan < xSayısı; çarpan++)
                {
                    if (xSayısı % çarpan == 0)
                    {
                        lstX.Items.Add(çarpan);
                        sonuc1 += çarpan;
                    }
                }
                int ySayısı = Convert.ToInt32(txtY.Text);
                int sonuc2 = 0;
                for (int çarpan = 1; çarpan < ySayısı; çarpan++)
                {
                    if (ySayısı % çarpan == 0)
                    {
                        lstY.Items.Add(çarpan);
                        sonuc2 += çarpan;

                    }
                }
                lblSonuc.Text = "Sonuclar";
                lblSonucX.Text = Convert.ToString(sonuc1);
                lblSonucY.Text = Convert.ToString(sonuc2);
                if (xSayısı == sonuc2 && ySayısı == sonuc1)
                {
                    lblArkadas.Text = "Bu iki sayı arkadaş";
                }
                else
                {
                    lblArkadas.Text = "Bu iki sayı arkadaş değil";
                }
                sayac++;
            }
        }
        void BtnSon_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
