using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            //kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme durumunu kontrol ediniz.Ehliyet alma koşulu en az 18 ve eğitim durumu lise ya da üniversite olabilir.

        //     Console.WriteLine("isim: ");
        //     string isim = Console.ReadLine();

        //     Console.WriteLine("yaş: ");
        //     int yas = int.Parse(Console.ReadLine());

        //     Console.WriteLine("Üniversite: ");
        //     string univercity = Console.ReadLine();

        //     if(yas>=18) {
        //         if (univercity == "lise" || univercity == "üniversite")
        //         {
        //         Console.WriteLine($"{isim} ehliyet alabilirsiniz.");
        //     } 

        //     else {
        //     Console.WriteLine($"ehliyet almak için eğitim durmunuz yetersiz. "); 
        //     }     
        // } 
        // else {
        //         Console.WriteLine($"{isim} ehliyet almak için en az 18 olmalısınız.");
        //     }  


        

            //girilen 3 sayıdan en büyüğünü bulunuz.

            // Console.Write("1.sayı:" );
            // int sayi1 = int.Parse(Console.ReadLine());

            // Console.Write("2.sayı:" );
            // int sayi2 = int.Parse(Console.ReadLine());

            // Console.Write("3.sayı:" );
            // int sayi3 = int.Parse(Console.ReadLine());

            // if(sayi1>sayi2 && sayi1>sayi3){
            //     Console.WriteLine($"{sayi1} en büyük sayıdır.");   
            // }
            
            // if(sayi2>sayi1 && sayi2>sayi3){

            //     Console.WriteLine($"{sayi2} en büyük sayıdır.");
            // }

            // if(sayi3>sayi2 && sayi3>sayi1) 
            // {
            //     Console.WriteLine($"{sayi3} en büyük sayıdır.");
            // }

            //bir öğrencinin 2 yazılı bir sözlu notu alınıp hesaplanan ortalama not aralığına karşılık gelen not bilgisini yazdırın.

        //     Console.Write("1.yazılı not: ");
        //     int not1 = int.Parse(Console.ReadLine());

        //     Console.Write("2.yazılı not: ");
        //     int not2 = int.Parse(Console.ReadLine());

        //     Console.Write("sözlü not: ");
        //     int not3 = int.Parse(Console.ReadLine());

        //     var ortalama = (not1 + not2 + not3) / 3;
        //     int not=-1;

        //     if(0<ortalama && ortalama<24)
        //     not=0;
            
        //     else if(25<ortalama && ortalama<44)
        //     not =1;
            
        //     else if(45<ortalama && ortalama<54)
        //         not=2;
            
        //     else if(55<ortalama && ortalama<69)
        //     not =3;

        //     else if(70<ortalama && ortalama<84)
        //     not =4; 

        //     else if (85<ortalama && ortalama<100) 
        //     not = 5;

        //     else 
        //     Console.WriteLine("yanlış not.");
         
        // Console.WriteLine($"not ortalaması: {ortalama} ve notunuz: {not}");

        //trafiğe çıkış tarihi alınan bir aracın servis zamanı aşağıdaki bilgilere göre hesaplayınız.

        Console.WriteLine("Trafiğe çıkış tarihi yıl: ");
        int tarih = int.Parse(Console.ReadLine());

        Console.WriteLine("Trafiğe çıkış tarihi ay: ");
        int tarih2= int.Parse(Console.ReadLine());

        Console.WriteLine("Trafiğe çıkış tarihi gün: ");
        int tarih3 = int.Parse(Console.ReadLine());

        int toplamgun = (DateTime.Now - new DateTime(tarih,tarih2,tarih3)).Days; // new ile yeni bir nesne tanıttık. Anlık zamandan dışarıdan girilen zamanı çıkardık. Girilen zamanın nesnesini new ile biz oluşturduk parametreler vererek.

        if(toplamgun<=365)
         Console.WriteLine("1.servis");

        else if(toplamgun>365 && toplamgun<=365*2)
         Console.WriteLine("2.servis");

        else if(toplamgun>365*2 && toplamgun<=365*3)
         Console.WriteLine("3.servis");

        else
         Console.WriteLine("yanlış bilgi."); 
} 
} 
}