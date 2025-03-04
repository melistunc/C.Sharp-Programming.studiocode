using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            //implicit casting (automatically): smaller type to larger

            //int-long-float (büyükten küçüğe saklanabilir.)
            int a = 10;
            long b = a; //32 bitlik sayı 64 bitte saklanabilir.

            //explicit casting (manually): lager type yo smaller

            long c = 10;
            int d = (int)c; //64 bilik bir sayıyı 32 bitlik sayıya atamak istediğimizde bilinçli dönüştürme yaparız.


            float e = 10.5f;
            double f = e; //float double'a göre daha az kapasiede olduğu için saklanabilir.

            double g = 10.423;
            float s = (float)g; //bilinçli tür dömüşümü yaparız.

            double k = 10.5;
            int l = (int)k; //bilinçli dönüşüm 

            Console.WriteLine(l) ;

            int m = 23453;
            byte n = (byte)m;

            Console.WriteLine(n); //burada bir veri kaybı olur.


            //int to string 
            int x = 10;
            string z = x.ToString(); //tostring ile int'i string'e dönüştürdük.





            Console.Write("1.sayı: ");
            int sayi1= int.Parse(Console.ReadLine()); //kullanıcıdan girilen satırı okur. dılşarıdan veri girişi. readline her zaman string veri alır. bu yüzden burada int-string dönüşümü yaparız pasre metodu ile. short olmasını istiyorsak da short.parse yazarız.

            Console.Write("2.sayı: "); //writeline alt satıra geçer. alt satıra geçmesini istemiyorsak write kullanırız.
            int sayi2= int.Parse(Console.ReadLine()); //readline satırı okur ve bir alt satıra geçer. alt satıra geçmesini istemiyorsak read yazarız.

            int toplam = sayi1 + sayi2;
            //her iki write şeklinde de veri okunabilir. (her iki kod aynı işevi görür.)
            Console.WriteLine("toplam: " +toplam);
            /*Console.WriteLine($"girilen toplam değer: {toplam}"); */ 
         }

    }
}