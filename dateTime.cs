using System;
using System.Globalization;

namespace ConsoleApp
{
    class Conversion
    {
        static void Main(string[] args)
        {
            string[] aylar = {"ocak","subat","mart","nisan","mayıs","haziran","temmuz","ağustos","eylül","ekim","kasım","aralık"};

            DateTime simdi = DateTime.Now; //datetime sınıfı ile çalıştık. ismi simdi oldu ve simdiki güncel bilgiyi Now ile getirdik.
            
            Console.WriteLine(aylar[simdi.Month-1]); //subat bilgisini getirir. aylardan 1 çıkarıp subatı buluruz.
            Console.WriteLine(simdi); 
            Console.WriteLine(simdi.Year); //su anki zamanın yıl bilgisini getirdik.
            Console.WriteLine(simdi.Month); // ay bilgisi.
            Console.WriteLine(simdi.Day);
            Console.WriteLine(simdi.DayOfWeek); // haftanın günü.
            Console.WriteLine(simdi.Hour);
            Console.WriteLine(simdi.Minute);
            Console.WriteLine(simdi.Second);

            DateTime dt = new DateTime(2016,03,16,14,30,21); // yıl ay gün saat dakika saniye
            
            DateTime dt1 = dt.AddDays(2); //mevcut datetime bilgisine 2 eklemiş oluruz. yani bugun ayın 22'si ise ayın 24'ü olur. saat ay yıl dakika saat saniye vs hepsini ekleyebiliriz bu şekilde.

            var fark = simdi - dt; // bize su anki zaman ve oluşturduğumuz zamanın arasındaki farkı bize verir.

            Console.WriteLine(fark.TotalDays); // iki tarih arasındaki gün farkını bize verir.

            Console.WriteLine(simdi.ToString("d")); //ile sadece tarih bilgisi.
            Console.WriteLine(simdi.ToString("D")); //tarih bilgisi yanında gün bilgisi
            Console.WriteLine(simdi.ToString("F"));//tarih gün bilgisi yanında saat bilgisi
            Console.WriteLine(simdi.ToString("M"));//gün ve ay bilgisi
            Console.WriteLine(simdi.ToString("t"));//dakika saniye bilgisi
            Console.WriteLine(simdi.ToString("T"));//tam saat bilgisi.
            Console.WriteLine(simdi.ToString("Y")); //ay ve yıl bilgisi

            Console.WriteLine(simdi.ToString("hh-mm-ss")); //saat dakika saniye bilgisi.
            Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy")); // saat gün ay yıl

            CultureInfo culture = new CultureInfo("en"); //tarih bilgisini ingilizce olarak değiştirdik.

            Console.WriteLine(simdi.ToString("F", culture));
        }
    }
}