using System;
namespace encapsulation
{
    class Program
    {
        static void Main(string[]args)
        {
            Ogrenci ogrenci=new Ogrenci();
            ogrenci.Isim="Muhammed";
            ogrenci.Soyisim="Solmaz";
            ogrenci.OgrenciNo=258879;
            ogrenci.Sinif=5;

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            Ogrenci ogrenci2 =new Ogrenci("İkbal","Kıyatsıl",159963,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
            
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set  
            {
                if(value<1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sinif=1;
                }

                else
                {
                    sinif = value;
                }
            } 
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*******Öğrenci Bilgileri ******");
            Console.WriteLine("Öğrenci Adı       :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı    :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No        :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı    :{0}",this.Sinif);

        }
        public void SinifAtlat()
        {
            this.Sinif=this.Sinif +1;
        }
        public void SinifDusur()
        {
            this.Sinif=this.Sinif -1;
        }
        
    }
}