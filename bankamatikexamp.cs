using System;

namespace ConsoleApp{
class Conversion{
          static void Main(string[] args){

            //menü:bakiye
            //para yatırma
            //para çekme
            //çıkış
 
            string secim = "";
            double bakiye =0;
            
            do
            {
            Console.WriteLine("1-bakiye /n2-para yatırma/n3-para çekme/n4-çıkış");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                 Console.WriteLine("bakiyeniz {0} TL", bakiye);
                 break;
                case "2":
                 Console.WriteLine("yatırmak istediğiniz miktar: ");
                 double yatirilan = double.Parse(Console.ReadLine());
                 bakiye+=yatirilan;
                 break;
                case "3":
                 Console.WriteLine("çekmek istediğiniz miktar: ");
                 double cekilecekmiktar= double.Parse(Console.ReadLine());
                 if(cekilecekmiktar>bakiye)
                   Console.WriteLine("bakiyeniz yetersiz.");
                 bakiye-=cekilecekmiktar;
                 break;
                case "4":
                 Console.WriteLine("çıkış");  
                 break;
                default:
                 Console.WriteLine("hatalı seçim.");
                 break;
                
            }
             } while (secim!="4");

         Console.WriteLine("uygulamadan çıkıldı."); 
          }
}
}