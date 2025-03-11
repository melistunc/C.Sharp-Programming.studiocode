using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            int ay =5;
            
            switch (ay) //switch bize elseif durumu gibi bir durum sağlar. Buraya yazdığım koşula göre alt durumlar oluşturur.
            {
                case 12: //durumlar
                case 1:
                case 2:
                     Console.WriteLine("kış mevsimi");
                    break; //break ile bu durum olmuşsa bir sonraki case'e geçmemişizi engeller.
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz mevsimi");
                    break;
                case 9:
                    Console.WriteLine("sonbahar mevsimi");
                    break;
                case 10:
                    Console.WriteLine("sonbahar mevsimi");
                    break;
                case 11:
                    Console.WriteLine("sonbahar mevsimi");
                    break;
                    
                default:
                   Console.WriteLine("yanlış bilgi.");
                   break;
            }
         }
}
}