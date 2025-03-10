using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            int x =int.Parse(Console.ReadLine());
            int y= int.Parse(Console.ReadLine());

            if (x>y)
            Console.WriteLine("X büyük Y'den.");

            else if (x==y) //else if ile şart koyarız. Fraklı bir şart.
            Console.WriteLine("x ve y eşittir.");

            else 
            Console.WriteLine("X küçük Y'den.");

            

            Console.Write("sayi: ");
            int sayi = int.Parse(Console.ReadLine());

            if(sayi>0)
              Console.WriteLine("sayı pozitiftir.");

            else if(sayi == 0)
            Console.WriteLine("sayı sıfıra eşit.");
             
            else
              Console.WriteLine("sayı sıfırdır.");  
         }
}
}