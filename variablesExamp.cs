class VariablesExamp {
    static void Main (string[] args) {

        /*kilo bilgisi tutacak değişken*/
        byte kilo = 55; //yer kaplamasın diye en küçüğü yeterlidir.

        // plaka bilgisi tutacak bir değişken
        byte plaka = 72;
        string plakaa = "09 mmmms 06";

        // araç km bilgisini tutan bir değişken
        int km = 18267632;
        string _km = "1983983";

        //müşteri id'sini tutacak bir değişken
        int musteriID = 26633;
        string musteriId = "A254366";

        //bir ürünün staışta olup olmadığı bilgisini tutacak değişken
        bool SatıstaMi = true;

        //maaş bilgisini tutacak bir değişken
        decimal maas = 800.0000m;

        //öğrenci adını ve soyadını tutacak bir değişken
        string bilgi = " melis tunç";
        string ad ="melis";
        string soyad = "tunç";
        string fullname = ad +" "+ soyad; // melis tunç

        //şube kodunu tutacak bir değişken (örneğin ; A)
        char kod = 'Y';

        //null
        //nullable

        byte? yas = null; //null değer atarsak değişken başına soru işareti koyarız. Daha sonra kullanmak için veya kullanıcan bilgi almak için null koyabiliriz. byte, short, int, long, decimal, double.

        //string ve char bilgiye null yazmak zorunda değiliz.
        string plakam; //nullable

        //bool için de soru işareti ekleriz.
        bool? varMi = null; //kullanıcının cinsiyetini belirtmek istemedği durumlarda kullanıcı herhangi bir şey belirtmezse burası null olur.

    }
}