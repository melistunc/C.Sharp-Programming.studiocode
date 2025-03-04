using System; //her seferinde System.console... yazmak yerine burada belirterek console.write... yazarak kolaylık sağlamış oluruz.

namespace ConsoleApp { //namespace System'in hangi klasör altında olduğunu belirtiyor. System diyerek tam yolunu belirtmiş oluyoruz.


class Variables {
    static void Main(string[] args){

        // tamsayı (byte,short,int,long)
        int sayi = 10;
        //int sayi = 20; aynı değişken içinde bir değer daha atayamayız.
        int sayi2 = 20;
        long sayi6 = 23646635552; //long ile çok büyük sayıları tutabiliriz.
        short sayi7 = -431; // short -3200 ile 3200 arasında alır.
        byte sayi8 = 254; // 0 ile 255 arasında sayı alır.

        Console.WriteLine(sayi6);
        Console.WriteLine(sayi);
        Console.WriteLine(sayi2);
        Console.WriteLine(sayi7);
        Console.WriteLine(sayi8);

        //System.Console.WriteLine(); // cw yazıp enter dersek kısa yoldan burası yazılır.

        // ondalıklı sayı
        float sayi3 = 9.2f; //float ile ondalıklı sayı belirtirsek sayının sonuna f harfini koymlaıyız. daha hassaslığı az olanları  float ile saklayabiliriz.
        double sayi4 = 10.2; // burada f yazmamıza gerek yok.
        decimal sayi5 = 199.3m; // sayı sonuna m eklemeliyiz. decimal'de hassasiyeti fazla olanları saklarız.
        Console.WriteLine(sayi3);
        Console.WriteLine(sayi4);
        Console.WriteLine(sayi5);


        //karakter
        string name = "lily"; // kelime yazarsak string.
        char name2 = 'm'; //tek bir karakter kullanmak istiyorsak char kullanırız.


        //boolean  true-false
        bool isRetires = true; // o kişi emekli mi -evet.

        bool isActive = false;
    }
  }
}