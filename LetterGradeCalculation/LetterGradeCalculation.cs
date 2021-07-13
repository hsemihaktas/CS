/****************************************************************************
**	@author Hasan Semih Aktaş
****************************************************************************/
using System;
using System.IO;
namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] okuyucu = new char[2];
            okuyucu[0]=' ';
            okuyucu[1] = '\n';
            string dosyaYolu = @"C:\Users\semih\Desktop\isim.txt";
            StreamReader oku = new StreamReader(dosyaYolu);
            string[] kelimeler = new string[200]; //Dosyadaki satırları kelimeler adlı diziye aktarıyorum
            string okunan = oku.ReadToEnd();
            kelimeler = okunan.Split(okuyucu);//Aldığımız satırları boşluk ve alt satıra geçmesine göre tek tek kelimleri diziye aktarıyorum
            string[] ad = new string[kelimeler.Length];
            string[] soyAd = new string[kelimeler.Length];
            string[] no= new string[kelimeler.Length];
            string[] vize= new string[kelimeler.Length];
            string[] quiz= new string[kelimeler.Length];
            string[] final= new string[kelimeler.Length];
            string[] harfNotu = new string[kelimeler.Length];
            string[] quizYüzdesi = new string[kelimeler.Length];
            string[] vizeYüzdesi= new string[kelimeler.Length];
            string[] finalYüzdesi = new string[kelimeler.Length];
            int notuAA=0;
            int notuBA=0;
            int notuBB=0;
            int notuCB=0;
            int notuCC=0;
            int notuDC=0;
            int notuDD=0;
            int notuFD=0;
            int notuFF=0;
            int sayac1 = 0;
            int sayac2;
            // Dosyada isim,soyisim,okulno,quiz,vize,final,quizetkisi,vizeetkisi ve finaletkisi olmak üzere 9 tane etmen olduğu için her 9 da bir kelime aynı dizi grubuna eşlik etmesi için sayacı 9 arttırıyorum.
            for (sayac2 = 0 ; sayac2 < kelimeler.Length; sayac2 += 9)
            { 
                ad[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 1; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                soyAd[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 2; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                no[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 3; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                quiz[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 4; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                vize[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 5; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                final[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 6; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                quizYüzdesi[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 7; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                vizeYüzdesi[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            sayac1 = 0;
            for (sayac2 = 8; sayac2 < kelimeler.Length; sayac2 += 9)
            {
                finalYüzdesi[sayac1] = kelimeler[sayac2];
                sayac1++;
            }
            for (sayac2 = 0; sayac2 < sayac1; sayac2++)
            {
                double quizNotu = Convert.ToDouble(quiz[sayac2]);
                double vizeNotu = Convert.ToDouble(vize[sayac2]);
                double finalNotu = Convert.ToDouble(final[sayac2]);
                double quizEtkisi = Convert.ToDouble(quizYüzdesi[sayac2])/100;
                double vizeEtkisi = Convert.ToDouble(vizeYüzdesi[sayac2])/100;
                double finalEtkisi = Convert.ToDouble(finalYüzdesi[sayac2])/100;
                double sonuc = quizNotu * quizEtkisi + vizeNotu * vizeEtkisi + finalNotu * finalEtkisi;
                if (90 < sonuc && sonuc <= 100)
                {
                    harfNotu[sayac2] = "AA";
                    notuAA++;
                }
                else if (85 < sonuc && sonuc <= 90)
                {
                    harfNotu[sayac2] = "BA";
                    notuBA++;
                }
                else if (80 < sonuc && sonuc <= 85)
                {
                    harfNotu[sayac2] = "BB";
                    notuBB++;
                }
                else if (75 < sonuc && sonuc <= 80)
                {
                    harfNotu[sayac2] = "CB";
                    notuCB++;
                }
                else if (65 < sonuc && sonuc <= 75)
                {
                    harfNotu[sayac2] = "CC";
                    notuCC++;
                }
                else if (58 < sonuc && sonuc <= 65)
                {
                    harfNotu[sayac2] = "DC";
                    notuDC++;
                }
                else if (50 < sonuc && sonuc <= 58)
                {
                    harfNotu[sayac2] = "DD";
                    notuDD++;
                }
                else if (40 < sonuc && sonuc <= 49)
                {
                    harfNotu[sayac2] = "FD";
                    notuFD++;
                }
                else
                {
                    harfNotu[sayac2] = "FF";
                    notuFF++;
                }
            }
            for (sayac2 = 0; sayac2 < sayac1; sayac2++)//Verileri ekrana yazdırıyorum
            {
                Console.WriteLine(ad[sayac2] + " " + soyAd[sayac2] + " " + no[sayac2] + " " + quiz[sayac2] + " " + vize[sayac2] + " " + final[sayac2] +" "+harfNotu[sayac2]);
            }
            string yazıYolu = @"C:\Users\semih\Desktop\bitiş.txt";
            StreamWriter yaz = new StreamWriter(yazıYolu);
            for (sayac2 = 0; sayac2 < sayac1; sayac2++) //Verileri dosyaya yazdırıyorum
            {
                yaz.WriteLine(ad[sayac2] + " " + soyAd[sayac2] + " " + no[sayac2] + " " + quiz[sayac2] + " " + vize[sayac2] + " " + final[sayac2] + " " + harfNotu[sayac2]);
            }
            yaz.WriteLine("AA alan kişi sayısı sınıfın %" +notuAA * 100 / sayac2 + " dır");
            yaz.WriteLine("BA alan kişi sayısı sınıfın %" + notuBA * 100 / sayac2 + " dır");
            yaz.WriteLine("BB alan kişi sayısı sınıfın %" + notuBB * 100 / sayac2 + " dır");
            yaz.WriteLine("CB alan kişi sayısı sınıfın %" + notuCB * 100 / sayac2 + " dır");
            yaz.WriteLine("CC alan kişi sayısı sınıfın %" + notuCC * 100 / sayac2 + " dır");
            yaz.WriteLine("DC alan kişi sayısı sınıfın %" + notuDC * 100 / sayac2 + " dır");
            yaz.WriteLine("DD alan kişi sayısı sınıfın %" + notuDD * 100 / sayac2 + " dır");
            yaz.WriteLine("FD alan kişi sayısı sınıfın %" + notuFD * 100 / sayac2 + " dır");
            yaz.WriteLine("FF alan kişi sayısı sınıfın %" + notuFF * 100 / sayac2 + " dır");
            yaz.Close();
        }
    }
}