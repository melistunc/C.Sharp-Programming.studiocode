using System;

namespace ConsoleApp{
class Conversion{
          static void Main(string[] args){

            string name = "melis tunç";

            for (int i = 0; i < name.Length; i++)
            {
                if(name[i] =='d')
                  break; //eğer name harfinde d varsa bu kısıma gelince döngü durdurulsun.
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("döngü dışı");

             for (int i = 0; i < name.Length; i++)
            {
                if(name[i] =='d')
                  continue; //eğer name harfinde d varsa bu kısıma gelince bu kısım alanılsın ve bu kısım hariç döngü devam etsin.
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("döngü dışı");

            int x=0;
            while(x<5)
            {
                if(x==2)
                  break; // x 2 olduğu zaman döngü dursun. döngüden çıkılsın.
                Console.WriteLine(x);
                x++; 
            }
            Console.WriteLine("döngü dışı");

             while(x<5)
            {
                if(x==2)
                  continue; // x 2 olduğu zaman döngü 2'yi atlasın döngü devam etsin fakat burada sonsuz döngü olur. if satırnın öncesine x++; yazarsak sonsuz döngü engellenmiş olur yani 2 gördüğü anda 2'yi yazmaz sonrasında döngü devam eder.
                Console.WriteLine(x);
                x++; 
            }
            Console.WriteLine("döngü dışı");

            //1-100 arasındaki tek sayıların toplamı

            int y=1;
            int toplamı =0;
            while (x<100)
            {
                x++;
                if(x%2==0) // çift olduğu anda burası atlansın yani hiçbir çift sayı yazılmaz toplamaya alınmaz.
                  continue;
                toplamı +=x;

            }
            Console.WriteLine("toplam: "+toplamı);
          }
}
}