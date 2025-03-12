using System;

namespace ConsoleApp{
class Conversion{
          static void Main(string[] args){

            //sınırsız sayıda ürün ismini bir dizi içinde saklayın. ürün adetini kullanıcı belirlesin. eklenen ürünler listelensin.

            Console.WriteLine("adet:");
            int adet =int.Parse(Console.ReadLine());

            string [] urunler = new string[adet];
            int i=0;

            do
            {
                Console.WriteLine("ürün adı: ");
                urunler[i] = Console.ReadLine();
                i++;
            } while (adet!=i);
}
}
}