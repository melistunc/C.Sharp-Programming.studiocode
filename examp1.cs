using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){ 

            int x=2, y=8, z=10;

            //1-kullanıcıdan girilen iki sayının çarpımı ve x,y,z sayılarının toplamının farkı.

            Console.WriteLine("1.sayıyı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            int carpim = sayi * sayi2;

            int toplam = x + y + z;

            short fark = (short)(carpim - toplam);
            Console.WriteLine("sonuç:" +fark);

            //2-kullanıcıdan girilen sayının tek çift kontrolü.

            Console.WriteLine("sayı: ");
            int sayi4 = int.Parse(Console.ReadLine());

            bool sonuc = (sayi4 % 2)==1?true:false; // 1 ise modu true veya false deriz.

            Console.WriteLine("girilen sayı çift mi: {sonuc}");


            //3- x,y,z toplamının mod 3'ü kaçtır.

            int toplam1 = x + y + z;
            int mod1 = toplam1 % 3;

            Console.WriteLine(mod1);


            // y'nin x.'ci kuvveti kaçtır.

            int kuvvet = (int)Math.Pow(y,x);,
            Console.WriteLine(kuvvet);
         }
}
}