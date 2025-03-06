using System;

namespace ConsoleApp
{
    class Conversion
    {
        static void Main(string[] args)
        {

            string[] names = { "lily", "lila", "kate", "vanessa", "jennie" };
            int[] numbers = { 22, 23, 24, 25, 26 };

            //isimler[0] = "lily"
            names.SetValue("rose", [0]); // lily bilgisini sıfırncı indexe atadık. sıfırncı indexteki lily'i rose yaptık.

            //Console.WriteLine(names[0]);
            Console.WriteLine(names.GetValue(0)); //sıfırncı elemanı ekrana yazdırdık.

            Console.WriteLine(Array.IndexOf(names, "lila")); //dizi içerisinde lila'nın index numarasını bulduk.

            Console.WriteLine(names.Length); //dizi içerisindeki eleman sayısını bulduk.

            Array.Sort(names); // names dizisindeki elemanları alfabetik sıralamaya göre sıraladı.
            Console.WriteLine(names.GetValue(0));

            Array.Sort(numbers); // numbers dizisindeki elemanları sıraya göre sıraladı.
            Console.WriteLine(names.GetValue(0));

            Array.Reverse(names); // names dizisindeki elemanların yerini ters değiştirdik.
            Array.Reverse(numbers); //numaraları ters çevirdik.
            Array.Clear(names, 0, 2); //names dizisndeki sıfırıncı indexindne itibaren iki elemanı sil.
            Array.Clear(numbers, 0, 2);//numbers dizisndeki sıfırıncı indexindne itibaren iki elemanı sil. silinen elemanlar yerine null gönderilir.

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[^1]); // baştan birinci ve sondan birinci karakteri getirir(jennie). 2 yazsaydık en baştaki ve sondan bir önceki gelecekti. 

            var result = names[1..4]; //birinci indexten başla dördüncü elemana kadar git. dördüncü eleman dahil değil.

             var result = names[1..]; //birden sonraki hepsini al.

              var result = names[..3]; //baştan başla  üçüncü indexteki elemana kadar git.

              string msg = "hello there";
              Console.WriteLine(msg[0..5]); //sıfırdan başla 5.karaktere kadar git. harf olarak gider. iki nokta ile belirli yere parçalanma işlemi yapabiliriz.


            foreach (var name in names) //bütün elemanlar sırayla ekrana yazdırılır.
            {
                Console.WriteLine(name);
            }
        }
    }
}