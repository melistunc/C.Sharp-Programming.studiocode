using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            string msg = "hello there. My name is Melis Tunç";

            //Console.WriteLine(msg.Length); yazdığımız cümlenin uzunluğunu veriyor.

            //Console.WriteLine(msg.ToLower()); // string ifadenin tümünü küçük harfe çevirir.

            //Console.WriteLine(msg.ToUpper()); //string ifadenin tümünü büyük harfe çevirir.

            //Console.WriteLine(msg.Trim()); //sağ ve solda tüm boşluk karakterleri bulup sildirir.

            //Console.WriteLine(msg.TrimStart()); //string ifadenin başındaki karakterleri siler. TrimEnd ise en sondaki karakterleri siler.

            //Console.WriteLine(msg.Split()[0]); //string ifade içerisindeki tüm kelimeleri boşluk karakterinden itibaren ayırır ve yazdırır. sıfırıncı indexini aldık. çıktı: hello -olur.

            //Console.WriteLine(msg[4]); //string ifadenin altıncı karakterini getirir. harf olarak getirir.

            //Console.WriteLine(msg.StartsWith("M")); //string ifaedimiz M ile mi başlıyor. Çıktı: F false olur.

            //Console.WriteLine(msg.EndsWith("Ç")); // string ifadenin sonu Ç ile mi bitiyor. Çıktı: T true.

            //Console.WriteLine(msg.Contains("hello")); //istediğimiz bir karakter string içinde var mı bakarız. çıktı: true

           //Console.WriteLine(msg.IndexOf("name")); //bulduğu karakterin konumunu buluyoruz. 16 index numarasından itibaren name cümle içinde yer alıyor.

           //Console.WriteLine(msg.Substring(8)); //string içerisinde herhangi bir kelimeyi alırız. bize sekizinci indexten itibaren bilgiyi getirir.

           //Console.WriteLine(msg.Substring(5,10)); // beşinci indexten itibaren on karakter getirsin.

           //int index = msg.IndexOf("name");
           //Console.WriteLine(msg.Substring(index)); //name'den itibaren tüm bilgiler gelir.

           //Console.WriteLine(msg.Replace(" ", ",")); // boşluk karakterlerini , ile değiştirdik. replace karakter değiştirir.

           //Console.WriteLine(msg.Replace(" ", ",").Replace(".","")); //noktaları silip boşluk yaptık.

           //Console.WriteLine(msg.Replace("@", "")); // @ işaretini sildik.

           //Console.WriteLine(msg.Insertns(0, "...")); //string ifaedinin başına üç nokta koyduk.

           //Console.WriteLine(msg.Insert(msg.Length, "...")); //sonuna üç nokta ekledi.

           //Console.WriteLine(msg.Remove(5)); // beşinci indexi sil.

           Console.WriteLine(msg.Remove(5, 10)); // beşten itibaren on tanesini sil.

         }
}
}