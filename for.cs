using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            // //for
            // for (int i = 7; i > 0; i=i-2)
            // {
            //     Console.WriteLine(i); // en son 4'e kadar yazar. 5'i yazmaz. i 7'den başlar ve her seferinde ikişer azaltır sıfıra kadar.
            // }



            //  for (int i = 1; i < 10; i++)
            // {
            //     Console.WriteLine("merhaba"); //9 defa merhaba yazar. 1-9
            // }



            // int toplam=0;
            //  for (int i = 0; i < 100; i++)
            // {
            //     if(i%2==0){ //i değerinde çift olanları alırız.
            //     toplam+=i;
            //     } 
            // }
            // Console.WriteLine(toplam);



            // string [] isimler = {"ada","yiğit","sena"}; //dizilerde for kullanmak.

            // for (int i = 0; i < isimler.Length; i++)
            // {
            //     Console.WriteLine(isimler[i]);
            // }

            // //1-

            // Console.Write("Başlangıç: ");
            // int baslangic = int.Parse(Console.ReadLine());

            // Console.Write("Bitiş: ");
            // int bitis = int.Parse(Console.ReadLine());

            // Console.Write("Artış: ");
            // int artis = int.Parse(Console.ReadLine());

            // int sayac=0;
            // for (int i = baslangic; i <= bitis; i=i+artis)
            // {
            //     sayac++;
            //     Console.WriteLine(i);
            //     Console.WriteLine(sayac);
            // }

            //2-sayilar dizisindeki hangi sayılar 3'ün katıdır.
            int[] sayilar = {1,2,3,5,6,7,23,67,90};

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(i%3==0)
                Console.WriteLine(i);
            }
            //3-sayıların toplamı
            int toplam=0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam+=sayilar[i];
            }
            Console.WriteLine("toplam:"+toplam);

            //4-tek sayıların karesi

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayilar[i]%2==1)
                Console.WriteLine(sayilar[i]*sayilar[i]);
            }

            //5-arabalar dizisindeki en az 5 karakterli araç isimleri
            string [] arabalar ={"mercedes","bmw","opel","mazda","toyota"};

            for (int i = 0; i < arabalar.Length; i++)
            {
                if(arabalar[i].Length>=5)
                 Console.WriteLine(arabalar[i]);
            }
         }

}
}