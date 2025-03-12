using System;

namespace ConsoleApp{
class Conversion{
          static void Main(string[] args){
            
            //girilen bir sayıın asal olup olmadığının kontrolü.

              bool asalmi = true;
            Console.WriteLine("sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi==1)
            {
                Console.WriteLine("1 asal sayı değildir");
            }

            for (int i = 2; i < sayi; i++)
            {
                if(sayi%i==0){
                    asalmi=false;
                    break;
                }
            }

        if(asalmi)
          Console.WriteLine("sayı asaldır. ");

        else
          Console.WriteLine("sayı asal değildir.")  
          }
}
}