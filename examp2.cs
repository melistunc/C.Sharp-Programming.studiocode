using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){


   // girilen iki sayıdan hangisi büyük?
   Console.Write("1.sayı:" );
   int sayi1 = int.Parse(Console.ReadLine());

   Console.Write("2.sayı:" );
   int sayi2 = int.Parse(Console.ReadLine());

   string result = (sayi1>sayi2)?"true":"false";
   Console.WriteLine("sayi1>sayi2:" +result);
   */


   //parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.
   string mail= "msg@gmail.com"; 
   string passw = "1234";

   Console.Write("email: ");
   string email = Console.ReadLine();

   Console.Write("password: ");
   string password = (Console.ReadLine());
   
   string sonuc = (mail == email)?"email doğru":"email yanlış";
   Console.WriteLine(sonuc);

   string sonuc1 = (passw == password)?"password doğru":"password yanlış";
   Console.WriteLine(sonuc1); */

   //girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.
   Console.WriteLine("sayı: ");
   int sayi = int.Parse(Console.ReadLine());

   string sonuc = ((sayi % 2) == 0)?"çift sayı":"tek sayı";
   Console.WriteLine(sonuc);*/

   //girilen 3 sayıyı büyüklük olarak karşılaştırınız.
   Console.Write("1.sayıyı giriniz: ");
   int sayi3 = int.Parse(Console.ReadLine());

   Console.Write("2.sayıyı giriniz: ");
   int sayi4 = int.Parse(Console.ReadLine());

   Console.Write("3.sayıyı giriniz: ");
   int sayi5 = int.Parse(Console.ReadLine());

   var result = (sayi3>sayi4)?"true":"false";
   Console.WriteLine(result);
   Console.Write ("en büyük sayı:sayi3" +result);
    result1 = (sayi3>sayi5)?"true":"false";
   Console.WriteLine(result1);
   Console.Write ("en büyük sayı:sayi4" +result1);
    result2 = (sayi4>sayi5)?"true":"false";
   Console.WriteLine(result2);
   Console.Write ("en büyük sayı:sayi5" +result2);

   //kullanıcıdan vize(%40) ve final (%60) notunu alıp ortalama hesaplanıyor. Eğer oratlama 50 ve üstündeyse geçti değilse kaldı yazdırın.
   Console.Write("1.vize notu giriniz: ");
   int vize = int.Parse(Console.ReadLine());

   Console.Write("2.vize notu giriniz: ");
   int vize2 = int.Parse(Console.ReadLine());
   
   Console.Write("final notu giriniz: ");
   int final = int.Parse(Console.ReadLine());
   
   var result1 = ((vize+vize2)/2) *0.6 + (final*0.4);

   var sonuc2 = (result1>=50) && (final>=50);

   var durum2 = (result1>=50) || (final>=70); //finalden 70 alındığında ortalamanın önemi kalmasın.

   Console.WriteLine("Ortalama" +result1);
   Console.WriteLine(result1>=50?"geçti":"kaldı");
   //var elliüstü = (result1>50)?"geçti":"kaldı";
   //Console.WriteLine(elliüstü);


   //kişinin ad, kılo, boy bilgilerini alıp kilo indeksini hesaplayınız.

   Console.WriteLine("ad:" );
   string ad = Console.ReadLine();

   Console.WriteLine("kilo: ");
   float kilo = float.Parse(Console.ReadLine());

   Console.WriteLine("boy: ");
   float boy = float.Parse(Console.ReadLine());

   float indeks  = (kilo) /(boy *boy);

   var zayif = (indeks>=0) && (indeks<18.4);
   var normal = (indeks>=18.4) && (indeks<24.9);
   var kilolu = (indeks>=24.9) && (indeks<9.9);
   var obez = (indeks>29.9) && (indeks<34.9);

   Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen zayıf: {zayif}");
   Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen normal: {normal}");
   Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen kilolu: {kilolu}");
   Console.WriteLine($"{ad} kilo indeksin: {indeks} ve kilo değerlendirmen obez: {obez}");
}
}
}