using System;

namespace ConsoleApp{

class Product
{
    public string Name { get; set; }

    public int Fiyat { get; set; }

    public string Describe { get; set; }
}
class Conversion{
         static void Main(string[] args){

            //sınırsız sayıda ürün bilgisini alıp bir dizi içinde saklayıız. ürün adetini kullanıcı belirtsin. Eklenen ürünler listelensin.

            Console.WriteLine("adet: ");
            int adet = int.Parse(Console.ReadLine());

            Product[] products = new Product[adet];

            int i=0;
            Product product; //nesne oluşturduk

            do
            {
                product = new Product(); //nesneyi oluşturduk.
                Console.Write("ürün adı: ");
                product.Name = Console.ReadLine();

                Console.Write("price");
                product.Fiyat = int.Parse(Console.ReadLine());

                Console.Write("açıklama: ");
                product.Describe = Console.ReadLine();

                products[i] = product;
                i++;

            } while (adet!=i);

            // for (int a = 0; a < products.Length; a++)
            // {
            //     Console.WriteLine($"ürün adı: {products[a].Name} ürün fiyat: {products[a].Fiyat} açıklama:{products[a].Describe}");
            // }

            foreach (var urun in products) //products listesi içindeki her elaman sırayla urun yerine kopyalanıyor. birinci ürün kopyalanır sonra ekrana yazılır. ikinci ürün kopyalanır ekrana yazılır. böyle böyle tüm ürünler kopyalanıp yazdırılır.
            {
                 Console.WriteLine($"ürün adı: {urun.Name} ürün fiyat: {urun.Fiyat} açıklama:{urun.Describe}");
            }
    }
}
}