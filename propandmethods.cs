namespace oopDersleri
{
    class Program
    {
        static void Main(string[] args) {
            
            ogrenci ogr1 = new ogrenci() {OgrenciNo = "100", AdSoyad = "Ada Bilgi" , Sube = "6/A"};
            ogrenci ogr2 = new ogrenci() { OgrenciNo = "200", AdSoyad = "Yiğit Bilgi", Sube = "7/A" };
            ogrenci ogr3 = new ogrenci() { OgrenciNo = "300", AdSoyad = "Ela Bilgi", Sube = "8/A" };


            ogrenci[] ogrenciler = new ogrenci[3] {ogr1 , ogr2 , ogr3 };

            foreach(var ogr in  ogrenciler)
            {
                Console.WriteLine(ogr.BilgileriYazdir());
            }
            

        }
    }

    class ogrenci
    {
        //property
        public string OgrenciNo { get; set; }

        public string AdSoyad { get; set; }

        public string Sube { get; set; }

        //methods
        public string BilgileriYazdir()
        {
            return $"{this.OgrenciNo} nolu öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube} şubesidir.";
        }

        
    }
}
