// sınıf: Araba 
// property: Marka:string
// property Model:string
// property Renk:string
// property Agirlik:int
// method: Start()
// method: Stop()
// method: Hizlan()
// method: Yavasla()
// Opel = Marka nesnedir.

//sınıftan türetilen her bir veri yapısına nesne denir. Nesneler class'lardan oluşur.
//property class içinde oluşturduğumuz değişkenlerdir.
//sınıfa hizmet eden yapılara method denir. 
// Opel.Start() dediğimiz zaman araba çalışacak.


using System;

namespace ConsoleApp{


class Ogrenci //class oluşturduk.
{
    public int OgrNo { get; set; }
    public string Ad { get; set; }
    public string Sube { get; set; } //her bir özelliğimiz için property oluşturduk.
}
class Conversion{
          static void Main(string[] args){

            int[] ogrno = {100,200,300};
            string [] ad = {"ada","lale","bengisu"};
            string [] sube = {"10A","10B","11A"};
            // sube[3] yazdığımız zaman sube dizisi içindeki 4.eleman deriz.



            Ogrenci ogr1 = new Ogrenci(); //nesne tanımlama. Ogrenci nesnesi ile ogr1 isimli bir nesne oluşturduk.

            ogr1.Ad = "ada"; //ogr1 oluşturduğumuz nesnedir. ogr1 "nokta" yaparsak bize ogr1'i oluşturduğumuz Class'ın property'lerine erişim imkanı sağlar. Yani nesneyi Ogrenci class'ından oluşturduğumuz için ogr1 ile Ogrenci Class'ındaki tüm property2lere erişim imkanı sağlarız." 
            ogr1.OgrNo = 100;
            ogr1.Sube = "10A";

           



            Ogrenci ogr2 = new Ogrenci(){ //bu şekilde de nesne içine bilgi aktarabiliriz. birden fazla bilgi aktaracaksak.

                OgrNo = 200,
                Ad = "lale",
                Sube = "10B"
            };
            


            Ogrenci ogr3 = new Ogrenci();
            ogr3.Ad = "bengisu";
            ogr3.OgrNo = 300;
            ogr3.Sube = "11A";

            Ogrenci[] ogrenciler = new Ogrenci[3]; //Ogrenci sınıfı türünde (Ogrenci sınıfında tanımladığımız ve eleman atadığımız bilgilerle) ogrenciler isimli bir liste tanımladık. Ve bu listenin 3 elemanlı olduğunu belirttik.

            ogrenciler[0] = ogr1; // ogrenciler dizisinin ilk elemanına ogr1 nesnesini atadık. (ogr1 nesnesi içinde öğrenci hakkında tüm bilgileri atamıştık.)
            ogrenciler[0] = ogr2;
            ogrenciler[0] = ogr3;

            for (int i = 0; i < ogrenciler.Length; i++) // kaç tane öğrenci varsa o kadar çalışsın ve ekrana yazdırsın.
            {
                 Console.WriteLine($"no: {ogrenciler[i].OgrNo}, ad: {ogrenciler[i].Ad}, sube: {ogrenciler[i].Sube}"); //ogr1 üzerinden ad ,no, şubeye erişebildik.

            }
}
}
}
