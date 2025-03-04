using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            Console.Write("kısa kenar: ");
            int kisa =int.Parse(Console.ReadLine());

            Console.Write("uzun kenar: ");
            int uzun =int.Parse(Console.ReadLine());

            var alan = kisa * uzun; //var ile bu hesaplamadan dönen ne ise o veri tipine göre dönsürür.
            var cevre = (kisa + uzun)*2;

            var str = "melis tunç";
            var piece = 100.5m;

            //Console.WriteLine("alan: "+alan + " " + "çevre:" +cevre);
            Console.WriteLine($"alan: {alan} çevre: {cevre}");
         }
}
}