using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            //while

            int i=0;
            while (i<10) // i 10'dan küçük olduğu sürece ekrana yazdır.
            {
                if(i%2==0) //sadece çift sayıları yazdırır.
                   Console.WriteLine("sayı çift "+i);
                else
                  Console.WriteLine("sayı tek"+i);
                i++;

                string name ="";

                while (string.IsNullOrEmpty(name)) //string içindeki değişken içindeki bilgi null ise true bilgi dönrürüyor. yani herhangi bir şey yazarsak false olur ve döngüden çıkar.
                {
                    Console.WriteLine("isminiz: "+name);
                }

                // do-while, kontrolü başta değil sonda yapar yani en az 1 kere çalışır.

                do //isimi okuduktan sonra kontrol ederiz.
                {
                   Console.WriteLine("isminiz: ");
                   name = Console.ReadLine();

                } while (string.IsNullOrEmpty(name));
            }
         }
}
} 