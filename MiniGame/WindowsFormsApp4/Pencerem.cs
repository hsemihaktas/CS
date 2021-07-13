/****************************************************************************
**	@author Hasan Semih Aktaş
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    //------------------------------------------------------------------
    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    //------------------------------------------------------------------
    public class Atik : IAtik
    {
        public int Hacim
        {
            get;
            set;

        }

        public Image Image
        {
            get;
            set;
        }
    }
    //------------------------------------------------------------------
    class CamSise : Atik
    {
        public CamSise()
        {
            this.Hacim = 600;
        }
    }
    class Bardak : Atik
    {
        public Bardak()
        {
            this.Hacim = 250;
        }
    }
    class Gazete : Atik
    {
        public Gazete()
        {
            this.Hacim = 250;
        }
    }
    class Dergi : Atik
    {
        public Dergi()
        {
            this.Hacim = 200;
        }
    }
    class Domates : Atik
    {
        public Domates()
        {
            this.Hacim = 150;
        }
    }
    class Salatalık : Atik
    {
        public Salatalık()
        {
            this.Hacim = 120;
        }
    }
    class KolaKutusu : Atik
    {
        public KolaKutusu()
        {
            this.Hacim = 350;
        }
    }
    class SalçaKutusu : Atik
    {
        public SalçaKutusu()
        {
            this.Hacim = 550;
        }
    }
    //------------------------------------------------------------------
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }
    //------------------------------------------------------------------
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }
        bool Ekle(Atik atik);
        bool Bosalt();
    }
    //------------------------------------------------------------------

    class OrganikAtıkKutusu : IAtikKutusu
    {

        public int BosaltmaPuani
        {
            get;

        }

        public int Kapasite
        {
            get;
            set;
        }

        public int DoluHacim
        {
            get;
            set;
        }

        public int DolulukOrani
        {
            get;
            set;
        }
        public OrganikAtıkKutusu()
        {
            BosaltmaPuani = 0;
            Kapasite = 700;
            DoluHacim = 0;
            DolulukOrani = 0;


        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                DoluHacim = 0;
                DolulukOrani = 0;
                return true;
            }
            else
                return false;

        }


        public bool Ekle(Atik atik)
        {
            if ((Kapasite - DoluHacim) >= atik.Hacim)
            {
                DoluHacim += atik.Hacim;
                double dolu= Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite) * 100;
                DolulukOrani = Convert.ToInt32(dolu);
                return true;
            }
            else
                return false;
        }

    }
    class KağıtKutusu : IAtikKutusu
    {

        public int BosaltmaPuani
        {
            get;

        }

        public int Kapasite
        {
            get;
            set;
        }

        public int DoluHacim
        {
            get;
            set;
        }

        public int DolulukOrani
        {
            get;
            set;
        }
        public KağıtKutusu()
        {
            BosaltmaPuani = 1000;
            Kapasite = 1200;
            DoluHacim = 0;
            DolulukOrani = 0;


        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                DoluHacim = 0;
                DolulukOrani = 0;
                return true;
            }
            else
                return false;

        }


        public bool Ekle(Atik atik)
        {
            if ((Kapasite - DoluHacim) >= atik.Hacim)
            {
                DoluHacim += atik.Hacim;
                double dolu = Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite) * 100;
                DolulukOrani = Convert.ToInt32(dolu);
                return true;
            }
            else
                return false;
        }

    }
    class CamKutusu : IAtikKutusu
    {

        public int BosaltmaPuani
        {
            get;

        }

        public int Kapasite
        {
            get;
            set;
        }

        public int DoluHacim
        {
            get;
            set;
        }

        public int DolulukOrani
        {
            get;
            set;
        }
        public CamKutusu()
        {
            BosaltmaPuani = 600;
            Kapasite = 2200;
            DoluHacim = 0;
            DolulukOrani = 0;


        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                DoluHacim = 0;
                DolulukOrani = 0;
                return true;
            }
            else
                return false;

        }


        public bool Ekle(Atik atik)
        {
            if ((Kapasite - DoluHacim) >= atik.Hacim)
            {
                DoluHacim += atik.Hacim;
                double dolu = Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite) * 100;
                DolulukOrani = Convert.ToInt32(dolu);
                return true;
            }
            else
                return false;
        }

    }
    class MetalKutusu : IAtikKutusu
    {

        public int BosaltmaPuani
        {
            get;

        }

        public int Kapasite
        {
            get;
            set;
        }

        public int DoluHacim
        {
            get;
            set;
        }

        public int DolulukOrani
        {
            get;
            set;
        }
        public MetalKutusu()
        {
            BosaltmaPuani = 800;
            Kapasite = 2300;
            DoluHacim = 0;
            DolulukOrani = 0;


        }

        public bool Bosalt()
        {
            if (DolulukOrani>=75)
            {
                DoluHacim = 0;
                DolulukOrani = 0;
                return true;
            }else
            return false;

        }

        public bool Ekle(Atik atik)
        {
            if ((Kapasite - DoluHacim) >= atik.Hacim)
            {
                DoluHacim += atik.Hacim;
                double dolu = Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite) * 100;
                DolulukOrani = Convert.ToInt32(dolu);
                return true;

            }
            else
                return false;
        }

    }
    class Pencerem : Form
    {
        CamSise camSise = new CamSise();
        Bardak bardak = new Bardak();
        Gazete gazete = new Gazete();
        Dergi dergi = new Dergi();
        Domates domates = new Domates();
        Salatalık salatalık = new Salatalık();
        KolaKutusu kolaKutusu = new KolaKutusu();
        SalçaKutusu salçaKutusu = new SalçaKutusu();
        OrganikAtıkKutusu organikKutusu = new OrganikAtıkKutusu();
        KağıtKutusu kağıtKutusu = new KağıtKutusu();
        CamKutusu camKutusu = new CamKutusu();
        MetalKutusu metalKutusu = new MetalKutusu();

        int sayi;
        int süre = 60;
        int puan;
        Random rastgele = new Random();

        public Pencerem()
        {
            string oyunBitti = "resim\\0.jpg";

            this.Width = 600;
            this.Height = 500;

            Font font = new Font("Times New Roman", 30);

            pic_oyunResmi = new PictureBox();
            pic_oyunResmi.Top = 20;
            pic_oyunResmi.Left = 20;
            pic_oyunResmi.Width = 200;
            pic_oyunResmi.Height = 200;
            pic_oyunResmi.ImageLocation = oyunBitti;
            pic_oyunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Controls.Add(pic_oyunResmi);

            lbl_oyunPuanı = new Label();
            lbl_oyunPuanı.Top = 230;
            lbl_oyunPuanı.Left = 20;
            lbl_oyunPuanı.TextAlign = ContentAlignment.BottomCenter;
            lbl_oyunPuanı.Text = puan.ToString() ;
            lbl_oyunPuanı.Font = font;
            lbl_oyunPuanı.Width = 200;
            lbl_oyunPuanı.Height = 40;
            Controls.Add(lbl_oyunPuanı);

            lbl_zaman = new Label();
            lbl_zaman.Top = 280;
            lbl_zaman.Left = 20;
            lbl_zaman.BackColor = Color.Green;
            lbl_zaman.TextAlign = ContentAlignment.BottomCenter;
            lbl_zaman.Text = "60";
            lbl_zaman.Font = font;
            lbl_zaman.Width = 200;
            lbl_zaman.Height = 40;
            Controls.Add(lbl_zaman);

            btn_yeniOyun = new Button();
            btn_yeniOyun.Top = 330;
            btn_yeniOyun.Left = 20;
            btn_yeniOyun.Text = "YENİ OYUN";
            btn_yeniOyun.Width = 200;
            btn_yeniOyun.Height = 40;
            Controls.Add(btn_yeniOyun);

            btn_cıkıs = new Button();
            btn_cıkıs.Top = 380;
            btn_cıkıs.Left = 20;
            btn_cıkıs.Text = "ÇIKIŞ";
            btn_cıkıs.Width = 200;
            btn_cıkıs.Height = 40;
            Controls.Add(btn_cıkıs);

            btn_organikAtıkKutu = new Button();
            btn_organikAtıkKutu.Top = 20;
            btn_organikAtıkKutu.Left = 240;
            btn_organikAtıkKutu.Text = "ORGANİK ATIK KUTUSU";
            btn_organikAtıkKutu.Width = 150;
            btn_organikAtıkKutu.Height = 20;
            Controls.Add(btn_organikAtıkKutu);

            lst_organikAtık = new ListBox();
            lst_organikAtık.Top = 50;
            lst_organikAtık.Left = 240;
            lst_organikAtık.Width = 150;
            lst_organikAtık.Height = 120;
            Controls.Add(lst_organikAtık);

            btn_organikAtıkBoşalt = new Button();
            btn_organikAtıkBoşalt.Top = 180;
            btn_organikAtıkBoşalt.Left = 240;
            btn_organikAtıkBoşalt.Text = "BOŞALT";
            btn_organikAtıkBoşalt.Width = 150;
            btn_organikAtıkBoşalt.Height = 20;
            Controls.Add(btn_organikAtıkBoşalt);

            pr_atık = new ProgressBar();
            pr_atık.Top = 200;
            pr_atık.Left = 240;
            pr_atık.Width = 150;
            pr_atık.Height = 20;
            pr_atık.Minimum = 0;
            pr_atık.Maximum = 100;
            pr_atık.Value = organikKutusu.DolulukOrani;
            Controls.Add(pr_atık);

            btn_kağıtKutu = new Button();
            btn_kağıtKutu.Top = 20;
            btn_kağıtKutu.Left = 410;
            btn_kağıtKutu.Text = "KAĞIT KUTUSU";
            btn_kağıtKutu.Width = 150;
            btn_kağıtKutu.Height = 20;
            Controls.Add(btn_kağıtKutu);

            lst_kağıt = new ListBox();
            lst_kağıt.Top = 50;
            lst_kağıt.Left = 410;
            lst_kağıt.Width = 150;
            lst_kağıt.Height = 120;
            Controls.Add(lst_kağıt);

            btn_kağıtKutusuBoşalt = new Button();
            btn_kağıtKutusuBoşalt.Top = 180;
            btn_kağıtKutusuBoşalt.Left = 410;
            btn_kağıtKutusuBoşalt.Text = "BOŞALT";
            btn_kağıtKutusuBoşalt.Width = 150;
            btn_kağıtKutusuBoşalt.Height = 20;
            Controls.Add(btn_kağıtKutusuBoşalt);

            pr_kağıt = new ProgressBar();
            pr_kağıt.Top = 200;
            pr_kağıt.Left = 410;
            pr_kağıt.Width = 150;
            pr_kağıt.Height = 20;
            pr_kağıt.Minimum = 0;
            pr_kağıt.Maximum = 100;
            pr_atık.Value = kağıtKutusu.DolulukOrani;
            Controls.Add(pr_kağıt);

            btn_camKutu = new Button();
            btn_camKutu.Top = 260;
            btn_camKutu.Left = 240;
            btn_camKutu.Text = "CAM KUTUSU";
            btn_camKutu.Width = 150;
            btn_camKutu.Height = 20;
            Controls.Add(btn_camKutu);

            lst_cam = new ListBox();
            lst_cam.Top = 290;
            lst_cam.Left = 240;
            lst_cam.Width = 150;
            lst_cam.Height = 120;
            Controls.Add(lst_cam);

            btn_camKutusuBoşalt = new Button();
            btn_camKutusuBoşalt.Top = 420;
            btn_camKutusuBoşalt.Left = 240;
            btn_camKutusuBoşalt.Text = "BOŞALT";
            btn_camKutusuBoşalt.Width = 150;
            btn_camKutusuBoşalt.Height = 20;
            Controls.Add(btn_camKutusuBoşalt);

            pr_cam = new ProgressBar();
            pr_cam.Top = 440;
            pr_cam.Left = 240;
            pr_cam.Width = 150;
            pr_cam.Height = 20;
            pr_cam.Minimum = 0;
            pr_cam.Maximum = 100;
            pr_cam.Value = camKutusu.DolulukOrani;
            Controls.Add(pr_cam);

            btn_metalKutu = new Button();
            btn_metalKutu.Top = 260;
            btn_metalKutu.Left = 410;
            btn_metalKutu.Text = "METAL KUTUSU";
            btn_metalKutu.Width = 150;
            btn_metalKutu.Height = 20;
            Controls.Add(btn_metalKutu);

            lst_metal = new ListBox();
            lst_metal.Top = 290;
            lst_metal.Left = 410;
            lst_metal.Width = 150;
            lst_metal.Height = 120;
            Controls.Add(lst_metal);

            btn_metalKutusuBoşalt = new Button();
            btn_metalKutusuBoşalt.Top = 420;
            btn_metalKutusuBoşalt.Left = 410;
            btn_metalKutusuBoşalt.Text = "BOŞALT";
            btn_metalKutusuBoşalt.Width = 150;
            btn_metalKutusuBoşalt.Height = 20;
            Controls.Add(btn_metalKutusuBoşalt);

            pr_metal= new ProgressBar();
            pr_metal.Top = 440;
            pr_metal.Left = 410;
            pr_metal.Width = 150;
            pr_metal.Height = 20;
            pr_metal.Minimum = 0;
            pr_metal.Maximum = 100;
            pr_metal.Value = metalKutusu.DolulukOrani;
            Controls.Add(pr_metal);

            btn_yeniOyun.Click += yeniOyun_Click;
            btn_cıkıs.Click += cıkıs_Click;
            btn_organikAtıkKutu.Click += organikAtıkKutusu_Click;
            btn_organikAtıkBoşalt.Click += organikAtıkBoşalt_Click;
            btn_kağıtKutu.Click += kağıtKutusu_Click;
            btn_kağıtKutusuBoşalt.Click += kağıtKutusuBoşalt_Click;
            btn_camKutu.Click += camKutusu_Click;
            btn_camKutusuBoşalt.Click += camKutusuBoşalt_Click;
            btn_metalKutu.Click += metalKutusu_Click;
            btn_metalKutusuBoşalt.Click += metalKutusuBoşalt_Click;

            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (süre > 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                süre--;
                lbl_zaman.Text = süre.ToString();


            }
            if(süre==0)
            {
                string oyunBitti = "resim\\0.jpg";
                pic_oyunResmi.ImageLocation = oyunBitti;
                organikKutusu.DolulukOrani = 0;
                kağıtKutusu.DolulukOrani = 0;
                camKutusu.DolulukOrani = 0;
                metalKutusu.DolulukOrani = 0;
                organikKutusu.DoluHacim = 0;
                kağıtKutusu.DoluHacim = 0;
                camKutusu.DoluHacim = 0;
                metalKutusu.DoluHacim = 0;
                lst_cam.Items.Clear();
                lst_kağıt.Items.Clear();
                lst_metal.Items.Clear();
                lst_organikAtık.Items.Clear();
                pr_atık.Value = organikKutusu.DolulukOrani;
                pr_cam.Value = camKutusu.DolulukOrani;
                pr_kağıt.Value = kağıtKutusu.DolulukOrani;
                pr_metal.Value = metalKutusu.DolulukOrani;
            }
        }
        void yeniOyun_Click(object sender, EventArgs e)
        {
            sayi = rastgele.Next(1, 9);
            string yol = "resim\\" + sayi + ".jpg";
            pic_oyunResmi.ImageLocation = yol;
            süre = 60;
            puan = 0;
            lbl_zaman.Text = süre.ToString();
            lbl_oyunPuanı.Text = puan.ToString();
            timer1.Start();

        }
        void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void organikAtıkKutusu_Click(object sender, EventArgs e)
        {
            
            if(sayi==5 && (organikKutusu.Kapasite-organikKutusu.DoluHacim)>=domates.Hacim)
            {
                organikKutusu.Ekle(domates);

                lst_organikAtık.Items.Add("Domates  150");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_atık.Value = organikKutusu.DolulukOrani;
            }
            if (sayi == 6 && (organikKutusu.Kapasite-organikKutusu.DoluHacim)>=salatalık.Hacim)
            {
                organikKutusu.Ekle(salatalık);
                lst_organikAtık.Items.Add("Salatalık  120");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_atık.Value = organikKutusu.DolulukOrani;
            }

        }

        void organikAtıkBoşalt_Click(object sender, EventArgs e)
        {
            
            if (organikKutusu.DolulukOrani>=75)
            {
                lst_organikAtık.Items.Clear();
                organikKutusu.Bosalt();
                puan += organikKutusu.BosaltmaPuani;
                lbl_oyunPuanı.Text = puan.ToString();
                pr_atık.Value = organikKutusu.DolulukOrani;
                süre += 3;
                lbl_zaman.Text = süre.ToString();
            }
        }
        void kağıtKutusu_Click(object sender, EventArgs e)
        {
            if (sayi == 3 && (kağıtKutusu.Kapasite-kağıtKutusu.DoluHacim)>=gazete.Hacim)
            {
                kağıtKutusu.Ekle(gazete);
                lst_kağıt.Items.Add("Gazete  250");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_kağıt.Value = kağıtKutusu.DolulukOrani;
            }
            if (sayi == 4 && (kağıtKutusu.Kapasite-kağıtKutusu.DoluHacim)>=dergi.Hacim)
            {
                kağıtKutusu.Ekle(dergi);
                lst_kağıt.Items.Add("Dergi  200");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_kağıt.Value = kağıtKutusu.DolulukOrani;
            }
        }
        void kağıtKutusuBoşalt_Click(object sender, EventArgs e)
        {
            if (kağıtKutusu.DolulukOrani>=75)
            {
                lst_kağıt.Items.Clear();
                kağıtKutusu.Bosalt();
                puan += kağıtKutusu.BosaltmaPuani;
                lbl_oyunPuanı.Text = puan.ToString();
                pr_kağıt.Value = kağıtKutusu.DolulukOrani;
                süre += 3;
                lbl_zaman.Text = süre.ToString();
            }
        }
        void camKutusu_Click(object sender, EventArgs e)
        {
            if (sayi == 1 && (camKutusu.Kapasite-camKutusu.DoluHacim)>=camSise.Hacim)
            {
                camKutusu.Ekle(camSise);
                lst_cam.Items.Add("Cam Sise  600");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_cam.Value = camKutusu.DolulukOrani;
            }
            if (sayi == 2 && (camKutusu.Kapasite-camKutusu.DoluHacim)>=bardak.Hacim)
            {
                camKutusu.Ekle(bardak);
                lst_cam.Items.Add("Bardak  250");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_cam.Value = camKutusu.DolulukOrani;
            }
        }
        void camKutusuBoşalt_Click(object sender, EventArgs e)
        {
            if (camKutusu.DolulukOrani>=75)
            {
                lst_cam.Items.Clear();
                camKutusu.Bosalt();
                puan += camKutusu.BosaltmaPuani;
                lbl_oyunPuanı.Text = puan.ToString();
                pr_cam.Value = camKutusu.DolulukOrani;
                süre += 3;
                lbl_zaman.Text = süre.ToString();
            }
        }
        void metalKutusu_Click(object sender, EventArgs e)
        {
            if (sayi == 7 && (metalKutusu.Kapasite-metalKutusu.DoluHacim)>=kolaKutusu.Hacim)
            {
                metalKutusu.Ekle(kolaKutusu);
                lst_metal.Items.Add("Kola Kutusu  350");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_metal.Value = metalKutusu.DolulukOrani;
            }
            if (sayi == 8 && (metalKutusu.Kapasite-metalKutusu.DoluHacim)>=salçaKutusu.Hacim)
            {
                metalKutusu.Ekle(salçaKutusu);
                lst_metal.Items.Add("Salça Kutusu  550");
                sayi = rastgele.Next(1, 9);
                string yol = "resim\\" + sayi + ".jpg";
                pic_oyunResmi.ImageLocation = yol;
                pr_metal.Value = metalKutusu.DolulukOrani;
            }
        }
        void metalKutusuBoşalt_Click(object sender, EventArgs e)
        {
            if (metalKutusu.DolulukOrani>=75)
            {
                lst_metal.Items.Clear();
                metalKutusu.Bosalt();
                puan += metalKutusu.BosaltmaPuani;
                lbl_oyunPuanı.Text = puan.ToString();
                pr_metal.Value = metalKutusu.DolulukOrani;
                süre += 3;
                lbl_zaman.Text = süre.ToString();
            }
               
        }
      
        public PictureBox pic_oyunResmi;
        public Label lbl_oyunPuanı;
        public Label lbl_zaman;
        public Button btn_yeniOyun;
        public Button btn_cıkıs;

        public Button btn_organikAtıkKutu;
        public ListBox lst_organikAtık;
        public Button btn_organikAtıkBoşalt;
        public ProgressBar pr_atık;

        public Button btn_kağıtKutu;
        public ListBox lst_kağıt;
        public Button btn_kağıtKutusuBoşalt;
        public ProgressBar pr_kağıt;

        public Button btn_camKutu;
        public ListBox lst_cam;
        public Button btn_camKutusuBoşalt;
        public ProgressBar pr_cam;

        public Button btn_metalKutu;
        public ListBox lst_metal;
        public Button btn_metalKutusuBoşalt;
        public ProgressBar pr_metal;

        public Timer timer1;


    }
}
