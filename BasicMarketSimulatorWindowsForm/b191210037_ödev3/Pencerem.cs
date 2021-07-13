/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:ÖDEV 3
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


namespace WindowsFormsApp8
{

    class Urun
    {
        public string Ad;
        public string Marka;
        public string Model;
        public double StokAdedi;
        public double HamFiyat;
        public double SecilenAdet;
        public double KdvliFiyat;

    }
    class Buzdolabi : Urun
    {
        private double IcHacim;
        private string EnerjiSinifi;

        public Buzdolabi(string ad, string marka, string model, double hamFiyat, double IcHacim, string EnerjiSinifi, double SecilenAdet)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.HamFiyat = hamFiyat;
            this.IcHacim = IcHacim;
            this.EnerjiSinifi = EnerjiSinifi;
            this.SecilenAdet = SecilenAdet;
            Random rastgele = new Random();
            this.StokAdedi = rastgele.Next(1, 100);

        }
        public void kdvUygula()
        {
            this.KdvliFiyat = (this.HamFiyat * 0.05) + this.HamFiyat;
        }
    }

    class LedTV : Urun
    {
        private string EkranBoyutu;
        private string EkranCözünürlügü;


        public LedTV(string ad, string marka, string model, double hamFiyat, string EkranBoyutu, string EkranCözünürlügü, double SecilenAdet)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.HamFiyat = hamFiyat;
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCözünürlügü = EkranCözünürlügü;
            this.SecilenAdet = SecilenAdet;
            Random rastgele = new Random();
            this.StokAdedi = rastgele.Next(1, 100);

        }
        public void kdvUygula()
        {
            this.KdvliFiyat = (this.HamFiyat * 0.18) + this.HamFiyat;
        }

    }
    class CepTel : Urun
    {
        private double DahiliHafiza;
        private double RamKapasitesi;
        private double PilGücü;

        public CepTel(string ad, string marka, string model, double hamFiyat, double DahiliHafiza, double RamKapasitesi, double PilGücü, double SecilenAdet)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.HamFiyat = hamFiyat;
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGücü = PilGücü;
            this.SecilenAdet = SecilenAdet;
            Random rastgele = new Random();
            this.StokAdedi = rastgele.Next(1, 100);

        }
        public void kdvUygula()
        {
            this.KdvliFiyat = (this.HamFiyat * 0.20) + this.HamFiyat;
        }

    }

    class Laptop : Urun
    {
        private string EkranBoyutu;
        private string EkranCözünürlügü;
        private double DahiliHafiza;
        private double RamKapasitesi;
        private double PilGücü;
        public Laptop(string ad, string marka, string model, double hamFiyat, string EkranBoyutu, string EkranCözünürlügü, double DahiliHafiza, double RamKapasitesi, double PilGücü, double SecilenAdet)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.HamFiyat = hamFiyat;
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCözünürlügü = EkranCözünürlügü;
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGücü = PilGücü;
            this.SecilenAdet = SecilenAdet;
            Random rastgele = new Random();
            this.StokAdedi = rastgele.Next(1, 100);

        }
        public void KdvUygula()
        {
            this.KdvliFiyat = (this.HamFiyat * 0.15) + this.HamFiyat;

        }


    }

    class Pencerem : Form

    {
        Buzdolabi b = new Buzdolabi("Buzdolabi", "Arçelik", "Nofrost", 2500, 530, "A++", 0);
        LedTV l = new LedTV("LedTv", "Samsung", "Smart LedTV", 3000, "24 İnç", "1920x1080", 0);
        CepTel c = new CepTel("CepTelefonu", "Xiaomi", "Red mi note 7", 2000, 128, 8, 3500, 0);
        Laptop k = new Laptop("Laptop", "Monster", "Abra", 7500, "17 inç", "1920x1080", 1024, 16, 3500, 0);
        double ToplamUcret = 0;

        public Pencerem()
        {
            b.kdvUygula();
            l.kdvUygula();
            c.kdvUygula();
            k.KdvUygula();

            this.Width = 1000;
            this.Height = 1000;

            grup = new GroupBox();
            grup.Top = 20;
            grup.Width = 450;
            grup.Height = 620;
            grup.Text = "Ürünlere Ait Kdvsiz Fiyatlar";
            Controls.Add(grup);


            resim1 = new PictureBox();
            resim1.Width = 200;
            resim1.Height = 200;
            resim1.Left = 20;
            resim1.ImageLocation = "C:\\Users\\semih\\Desktop\\telefon.jpg";
            resim1.Top = 20;
            resim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            grup.Controls.Add(resim1);

            lbltelefon = new Label();
            lbltelefon.Text = "Fiyat:";
            lbltelefon.Left = 70;
            lbltelefon.Top = 230;
            lbltelefon.Width = 40;
            grup.Controls.Add(lbltelefon);

            lbltelefonFiyatı = new Label();
            lbltelefonFiyatı.Text = c.HamFiyat.ToString();
            lbltelefonFiyatı.Left = 120;
            lbltelefonFiyatı.Top = 230;
            lbltelefonFiyatı.Width = 40;
            grup.Controls.Add(lbltelefonFiyatı);

            lbltelefonstok = new Label();
            lbltelefonstok.Text = "Stok:";
            lbltelefonstok.Left = 70;
            lbltelefonstok.Top = 255;
            lbltelefonstok.Width = 40;
            grup.Controls.Add(lbltelefonstok);

            lbltelefonsayısı = new Label();
            lbltelefonsayısı.Text = c.StokAdedi.ToString();
            lbltelefonsayısı.Left = 120;
            lbltelefonsayısı.Top = 255;
            lbltelefonsayısı.Width = 40;
            grup.Controls.Add(lbltelefonsayısı);

            lbltelefonAlınacak = new Label();
            lbltelefonAlınacak.Text = "Adet:";
            lbltelefonAlınacak.Left = 70;
            lbltelefonAlınacak.Top = 280;
            lbltelefonAlınacak.Width = 40;
            grup.Controls.Add(lbltelefonAlınacak);


            telefonAdet = new NumericUpDown();
            telefonAdet.Value = 0;
            telefonAdet.Minimum = 0;
            telefonAdet.Maximum = Convert.ToDecimal(c.StokAdedi);
            telefonAdet.Left = 120;
            telefonAdet.Top = 278;
            telefonAdet.Width = 40;
            grup.Controls.Add(telefonAdet);


            resim2 = new PictureBox();
            resim2.Width = 200;
            resim2.Height = 200;
            resim2.Left = 240;
            resim2.ImageLocation = "C:\\Users\\semih\\Desktop\\ledtv.jpg";
            resim2.Top = 20;
            resim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            grup.Controls.Add(resim2);

            lblledtv = new Label();
            lblledtv.Text = "Fiyat:";
            lblledtv.Left = 280;
            lblledtv.Top = 230;
            lblledtv.Width = 40;
            grup.Controls.Add(lblledtv);

            lblledtvFiyatı = new Label();
            lblledtvFiyatı.Text = l.HamFiyat.ToString();
            lblledtvFiyatı.Left = 330;
            lblledtvFiyatı.Top = 230;
            lblledtvFiyatı.Width = 40;
            grup.Controls.Add(lblledtvFiyatı);

            lblledtvstok = new Label();
            lblledtvstok.Text = "Stok:";
            lblledtvstok.Left = 280;
            lblledtvstok.Top = 255;
            lblledtvstok.Width = 40;
            grup.Controls.Add(lblledtvstok);

            lblledtvsayısı = new Label();
            lblledtvsayısı.Text = l.StokAdedi.ToString();
            lblledtvsayısı.Left = 330;
            lblledtvsayısı.Top = 255;
            lblledtvsayısı.Width = 40;
            grup.Controls.Add(lblledtvsayısı);

            lblledtvAlınacak = new Label();
            lblledtvAlınacak.Text = "Adet:";
            lblledtvAlınacak.Left = 280;
            lblledtvAlınacak.Top = 280;
            lblledtvAlınacak.Width = 40;
            grup.Controls.Add(lblledtvAlınacak);

            ledtvAdet = new NumericUpDown();
            ledtvAdet.Value = 0;
            ledtvAdet.Minimum = 0;
            ledtvAdet.Maximum = Convert.ToDecimal(l.StokAdedi);
            ledtvAdet.Left = 330;
            ledtvAdet.Top = 278;
            ledtvAdet.Width = 40;
            grup.Controls.Add(ledtvAdet);

            resim3 = new PictureBox();
            resim3.Width = 200;
            resim3.Height = 200;
            resim3.Left = 20;
            resim3.ImageLocation = "C:\\Users\\semih\\Desktop\\laptop.jpg";
            resim3.Top = 320;
            resim3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            grup.Controls.Add(resim3);

            lbllaptop = new Label();
            lbllaptop.Text = "Fiyat:";
            lbllaptop.Left = 70;
            lbllaptop.Top = 530;
            lbllaptop.Width = 40;
            grup.Controls.Add(lbllaptop);

            lbllaptopFiyatı = new Label();
            lbllaptopFiyatı.Text = k.HamFiyat.ToString();
            lbllaptopFiyatı.Left = 120;
            lbllaptopFiyatı.Top = 530;
            lbllaptopFiyatı.Width = 40;
            grup.Controls.Add(lbllaptopFiyatı);

            lbllaptopstok = new Label();
            lbllaptopstok.Text = "Stok:";
            lbllaptopstok.Left = 70;
            lbllaptopstok.Top = 555;
            lbllaptopstok.Width = 40;
            grup.Controls.Add(lbllaptopstok);

            lbllaptopsayısı = new Label();
            lbllaptopsayısı.Text = k.StokAdedi.ToString();
            lbllaptopsayısı.Left = 120;
            lbllaptopsayısı.Top = 555;
            lbllaptopsayısı.Width = 40;
            grup.Controls.Add(lbllaptopsayısı);

            lbllaptopAlınacak = new Label();
            lbllaptopAlınacak.Text = "Adet:";
            lbllaptopAlınacak.Left = 70;
            lbllaptopAlınacak.Top = 580;
            lbllaptopAlınacak.Width = 40;
            grup.Controls.Add(lbllaptopAlınacak);

            laptopAdet = new NumericUpDown();
            laptopAdet.Value = 0;
            laptopAdet.Minimum = 0;
            laptopAdet.Maximum = Convert.ToDecimal(k.StokAdedi);
            laptopAdet.Left = 120;
            laptopAdet.Top = 578;
            laptopAdet.Width = 40;
            grup.Controls.Add(laptopAdet);

            resim4 = new PictureBox();
            resim4.Width = 200;
            resim4.Height = 200;
            resim4.Left = 240;
            resim4.ImageLocation = "C:\\Users\\semih\\Desktop\\buzdolabı.jpg";
            resim4.Top = 320;
            resim4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            grup.Controls.Add(resim4);

            lblbuzdolabi = new Label();
            lblbuzdolabi.Text = "Fiyat:";
            lblbuzdolabi.Left = 280;
            lblbuzdolabi.Top = 530;
            lblbuzdolabi.Width = 40;
            grup.Controls.Add(lblbuzdolabi);

            lblbuzdolabiFiyatı = new Label();
            lblbuzdolabiFiyatı.Text = b.HamFiyat.ToString();
            lblbuzdolabiFiyatı.Left = 330;
            lblbuzdolabiFiyatı.Top = 530;
            lblbuzdolabiFiyatı.Width = 40;
            grup.Controls.Add(lblbuzdolabiFiyatı);

            lblbuzdolabistok = new Label();
            lblbuzdolabistok.Text = "Stok:";
            lblbuzdolabistok.Left = 280;
            lblbuzdolabistok.Top = 555;
            lblbuzdolabistok.Width = 40;
            grup.Controls.Add(lblbuzdolabistok);

            lblbuzdolabisayısı = new Label();
            lblbuzdolabisayısı.Text = b.StokAdedi.ToString();
            lblbuzdolabisayısı.Left = 330;
            lblbuzdolabisayısı.Top = 555;
            lblbuzdolabisayısı.Width = 40;
            grup.Controls.Add(lblbuzdolabisayısı);

            lblbuzdolabiAlınacak = new Label();
            lblbuzdolabiAlınacak.Text = "Adet:";
            lblbuzdolabiAlınacak.Left = 280;
            lblbuzdolabiAlınacak.Top = 580;
            lblbuzdolabiAlınacak.Width = 40;
            grup.Controls.Add(lblbuzdolabiAlınacak);

            buzdolabiAdet = new NumericUpDown();
            buzdolabiAdet.Value = 0;
            buzdolabiAdet.Minimum = 0;
            buzdolabiAdet.Maximum = Convert.ToDecimal(b.StokAdedi);
            buzdolabiAdet.Left = 330;
            buzdolabiAdet.Top = 578;
            buzdolabiAdet.Width = 40;
            grup.Controls.Add(buzdolabiAdet);

            grpSipariş = new GroupBox();
            grpSipariş.Top = 20;
            grpSipariş.Left = 470;
            grpSipariş.Width = 450;
            grpSipariş.Height = 620;
            grpSipariş.Text = "Sipariş Özeti";
            this.Controls.Add(grpSipariş);

            lblAdet = new Label();
            lblAdet.Text = "Adet";
            lblAdet.Top = 20;
            lblAdet.Left = 35;
            lblAdet.Width = 40;
            grpSipariş.Controls.Add(lblAdet);

            lstAdet = new ListBox();
            lstAdet.Top = 45;
            lstAdet.Left = 29;
            lstAdet.Width = 40;
            lstAdet.Height = 150;
            grpSipariş.Controls.Add(lstAdet);

            lblUrun = new Label();
            lblUrun.Text = "Ürün";
            lblUrun.Top = 20;
            lblUrun.Left = 175;
            lblUrun.Width = 40;
            grpSipariş.Controls.Add(lblUrun);

            lstUrun = new ListBox();
            lstUrun.Top = 45;
            lstUrun.Left = 94;
            lstUrun.Width = 200;
            lstUrun.Height = 150;
            grpSipariş.Controls.Add(lstUrun);

            lblKdv = new Label();
            lblKdv.Text = "Kdv'li Fiyat";
            lblKdv.Top = 20;
            lblKdv.Left = 340;
            lblKdv.Width = 100;
            grpSipariş.Controls.Add(lblKdv);

            lstKdv = new ListBox();
            lstKdv.Top = 45;
            lstKdv.Left = 320;
            lstKdv.Width = 100;
            lstKdv.Height = 150;
            grpSipariş.Controls.Add(lstKdv);

            lblToplam = new Label();
            lblToplam.Text = "KDV'li Toplam Fiyat=";
            lblToplam.Top = 500;
            lblToplam.Left = 60;
            lblToplam.Width = 110;
            grpSipariş.Controls.Add(lblToplam);

            lblToplamFiyat = new Label();
            lblToplamFiyat.Top = 500;
            lblToplamFiyat.Left = 170;
            grpSipariş.Controls.Add(lblToplamFiyat);

            btnEkle = new Button();
            btnEkle.Text = "Ürünleri Sepete Ekle";
            btnEkle.Width = 150;
            btnEkle.Left = 50;
            btnEkle.Top = 640;
            this.Controls.Add(btnEkle);

            btnTemizle = new Button();
            btnTemizle.Text = "Sepeti Temizle";
            btnTemizle.Width = 150;
            btnTemizle.Left = 220;
            btnTemizle.Top = 640;
            this.Controls.Add(btnTemizle);

            btnEkle.Click += BtnEkle_Click;
            btnTemizle.Click += BtnTemizle_Click;

        }
        int sayac = 1;

        void BtnEkle_Click(object sender, EventArgs e)
        {

            double alınanTelefon = Convert.ToDouble(telefonAdet.Text);
            double alınanLedTV = Convert.ToDouble(ledtvAdet.Text);
            double alınanLaptop = Convert.ToDouble(laptopAdet.Text);
            double alınanBuzdolabi = Convert.ToDouble(buzdolabiAdet.Text);
            double ToplamAlınanTelefonFiyat;
            double ToplamAlınanLedTVFiyat;
            double ToplamAlınanLaptopFiyat;
            double ToplamAlınanBuzdolabıFiyat;


            if (sayac == 1)
            {
                if (alınanTelefon > 0)
                {
                    if (c.StokAdedi > 0)
                    {
                        string Telefon = "Telefon";
                        ToplamAlınanTelefonFiyat = c.KdvliFiyat * alınanTelefon;
                        lstAdet.Items.Add(alınanTelefon);
                        lstUrun.Items.Add(Telefon);
                        lstKdv.Items.Add(ToplamAlınanTelefonFiyat);
                        c.StokAdedi -= alınanTelefon;
                        lbltelefonsayısı.Text = c.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanTelefonFiyat;

                    }
                    else
                    {
                        MessageBox.Show("Stokta Telefon Kalmadı");
                    }
                }
                if (alınanLedTV > 0)
                {
                    if (l.StokAdedi > 0)
                    {
                        string LedTV = "LedTV";
                        ToplamAlınanLedTVFiyat = l.KdvliFiyat * alınanLedTV;
                        lstAdet.Items.Add(alınanLedTV);
                        lstUrun.Items.Add(LedTV);
                        lstKdv.Items.Add(ToplamAlınanLedTVFiyat);
                        l.StokAdedi -= alınanLedTV;
                        lblledtvsayısı.Text = l.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanLedTVFiyat;

                    }
                    else
                    {
                        MessageBox.Show("Stokta LedTV Kalmadı");
                    }
                }
                if (alınanLaptop > 0)
                {
                    if (k.StokAdedi > 0)
                    {
                        string Laptop = "Laptop";
                        ToplamAlınanLaptopFiyat = k.KdvliFiyat * alınanLaptop;
                        lstAdet.Items.Add(alınanLaptop);
                        lstUrun.Items.Add(Laptop);
                        lstKdv.Items.Add(ToplamAlınanLaptopFiyat);
                        k.StokAdedi -= alınanLaptop;
                        lbllaptopsayısı.Text = k.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanLaptopFiyat;
                    }
                    else
                    {
                        MessageBox.Show("Stokta Laptop Kalmadı");
                    }

                }
                if (alınanBuzdolabi > 0)
                {
                    if (b.StokAdedi > 0)
                    {
                        string Buzdolabı = "Buzdolabı";
                        ToplamAlınanBuzdolabıFiyat = b.KdvliFiyat * alınanBuzdolabi;
                        lstAdet.Items.Add(alınanBuzdolabi);
                        lstUrun.Items.Add(Buzdolabı);
                        lstKdv.Items.Add(ToplamAlınanBuzdolabıFiyat);
                        b.StokAdedi -= alınanBuzdolabi;
                        lblbuzdolabisayısı.Text = b.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanBuzdolabıFiyat;
                    }
                    else
                    {
                        MessageBox.Show("Stokta Buzdolabı Kalmadı");
                    }

                }
                lblToplamFiyat.Text = ToplamUcret.ToString();
                sayac++;

            }
            else
            {
                lstAdet.Items.Clear();
                lstUrun.Items.Clear();
                lstKdv.Items.Clear();
                ToplamUcret = 0;


                if (alınanTelefon > 0)
                {
                    if (c.StokAdedi > 0)
                    {
                        string Telefon = "Telefon";
                        ToplamAlınanTelefonFiyat = c.KdvliFiyat * alınanTelefon;
                        lstAdet.Items.Add(alınanTelefon);
                        lstUrun.Items.Add(Telefon);
                        lstKdv.Items.Add(ToplamAlınanTelefonFiyat);
                        c.StokAdedi -= alınanTelefon;
                        lbltelefonsayısı.Text = c.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanTelefonFiyat;

                    }
                    else
                    {
                        MessageBox.Show("Stokta Telefon Kalmadı");
                    }
                }
                if (alınanLedTV > 0)
                {
                    if (l.StokAdedi > 0)
                    {
                        string LedTV = "LedTV";
                        ToplamAlınanLedTVFiyat = l.KdvliFiyat * alınanLedTV;
                        lstAdet.Items.Add(alınanLedTV);
                        lstUrun.Items.Add(LedTV);
                        lstKdv.Items.Add(ToplamAlınanLedTVFiyat);
                        l.StokAdedi -= alınanLedTV;
                        lblledtvsayısı.Text = l.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanLedTVFiyat;

                    }
                    else
                    {
                        MessageBox.Show("Stokta LedTV Kalmadı");
                    }
                }
                if (alınanLaptop > 0)
                {
                    if (k.StokAdedi > 0)
                    {
                        string Laptop = "Laptop";
                        ToplamAlınanLaptopFiyat = k.KdvliFiyat * alınanLaptop;
                        lstAdet.Items.Add(alınanLaptop);
                        lstUrun.Items.Add(Laptop);
                        lstKdv.Items.Add(ToplamAlınanLaptopFiyat);
                        k.StokAdedi -= alınanLaptop;
                        lbllaptopsayısı.Text = k.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanLaptopFiyat;
                    }
                    else
                    {
                        MessageBox.Show("Stokta Laptop Kalmadı");
                    }

                }
                if (alınanBuzdolabi > 0)
                {
                    if (b.StokAdedi > 0)
                    {
                        string Buzdolabı = "Buzdolabı";
                        ToplamAlınanBuzdolabıFiyat = b.KdvliFiyat * alınanBuzdolabi;
                        lstAdet.Items.Add(alınanBuzdolabi);
                        lstUrun.Items.Add(Buzdolabı);
                        lstKdv.Items.Add(ToplamAlınanBuzdolabıFiyat);
                        b.StokAdedi -= alınanBuzdolabi;
                        lblbuzdolabisayısı.Text = b.StokAdedi.ToString();
                        ToplamUcret += ToplamAlınanBuzdolabıFiyat;
                    }
                    else
                    {
                        MessageBox.Show("Stokta Buzdolabı Kalmadı");
                    }

                }
                lblToplamFiyat.Text = ToplamUcret.ToString();
            }
        }


        void BtnTemizle_Click(object sender, EventArgs e)
        {
            lstAdet.Items.Clear();
            lstUrun.Items.Clear();
            lstKdv.Items.Clear();
            ToplamUcret = 0;
            lblToplamFiyat.Text = ToplamUcret.ToString();


        }


        public PictureBox resim1;
        public Label lbltelefon;
        public Label lbltelefonFiyatı;
        public Label lbltelefonstok;
        public Label lbltelefonsayısı;
        public Label lbltelefonAlınacak;
        public NumericUpDown telefonAdet;

        public PictureBox resim2;
        public Label lblledtv;
        public Label lblledtvFiyatı;
        public Label lblledtvstok;
        public Label lblledtvsayısı;
        public Label lblledtvAlınacak;
        public NumericUpDown ledtvAdet;

        public PictureBox resim3;
        public Label lbllaptop;
        public Label lbllaptopFiyatı;
        public Label lbllaptopstok;
        public Label lbllaptopsayısı;
        public Label lbllaptopAlınacak;
        public NumericUpDown laptopAdet;

        public PictureBox resim4;
        public Label lblbuzdolabi;
        public Label lblbuzdolabiFiyatı;
        public Label lblbuzdolabistok;
        public Label lblbuzdolabisayısı;
        public Label lblbuzdolabiAlınacak;
        public NumericUpDown buzdolabiAdet;

        public GroupBox grup;
        public Button btnEkle;
        public Button btnTemizle;
        public GroupBox grpSipariş;
        public Label lblAdet;
        public ListBox lstAdet;
        public Label lblUrun;
        public ListBox lstUrun;
        public Label lblKdv;
        public ListBox lstKdv;
        public Label lblToplam;
        public Label lblToplamFiyat;

    }

}
