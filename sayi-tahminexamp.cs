using System;

namespace ConsoleApp{
class Conversion{
          static void Main(string[] args){

            //1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın, puanlama yapınız. Kullanıcı devam etmek istiyorsa devam etsin.

            do
            {
            var rnd = new Random(); //random sınıfı oluşturduk.
            int tutulan= rnd.Next(1,100); //next ile sayı üretiriz burada 1-100 aralığında ürettik.

            int hak =5; //max 5 hakkı oldu.
            int sayi;
            int tur=0;
            double puan=100/hak;

            while (hak>0)//hhak sıfırdan büyük oludğu sürece kullanıcıya sayı soaracağız.
            {
                tur++;
                 Console.WriteLine($"{tur}Sayı: ");
                 sayi =int.Parse(Console.ReadLine());
                 hak--;

                 if (sayi==tutulan){
                    double sorupuan = 100- (puan*(tur-1)); 
                    Console.WriteLine($"Tebrikler {tur} defada bildiniz. {sorupuan} puan kazandınız."); 
                    break; //döngüden çıkması için.
                 }
                else
                {
                    if (hak==0)
                        break;
                    if (tutulan>sayi)
                         Console.WriteLine("Yukarı.");
                    else
                        Console.WriteLine("Aşağı.");
                }    
               
            }
             Console.WriteLine("Oyun bitti.");
             Console.WriteLine("Devam etmek istiyor musunuz? (e/h)");
             string result = Console.ReadLine();

             if(result=="h" || result=="hayır")
                 break;

             } while (true);
          }
}
}