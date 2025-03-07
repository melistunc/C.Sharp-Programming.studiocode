//operatörler
// 1- Artitmetik operatörler (+,-,/,%,++,--)

int a =10;
int b= 20;
float val;

val = a + b; //30
val = a - b; //-10
val = a * b; //200
val = (float)a / (float)b; //0
val = b % a; //mod alımı. bir sayının çift mi tek mi olduğunu bulmak için kullanırız genelde.
val = a++; //ilk önce val değerine a 'yı atarız ve sonra a olur. val = 10, a=11
val = ++a; // a'yı bir arttırıp val'e eşitledi. val=11, a=11
val = a--;
val = --a;

//en son olan satır çalışır.

Console.WriteLine("value:" +val);




// 2- Atama operatörleri (=,+=,-=,*=,/=,%=)

int x=5, y=10, z=20;
double vali;

x += 5; // x = x+5
x -= 5; // x = x-5
x *= 5; // x = x*5
x /= 5; // x = x/5
x %= 5; 
vali = Math.Pow(2,5); // math sınıfından pow metodu üs alır yani 2 üzeri 5 olur.
vali = Math.Sqrt(25); // 25'in karekökünü alır.
vali = Math.Abs(-10); // mutlak değerini alırız.
vali = Math.Round(4.45); //yuvarlama işlemi yaparız.4.5'te 4'e yuvarlar. ortada olursa en yakın çift sayıya yuvarlar.
vali = Math.Ceiling(5.5); //yukarı yuvarlar.
vali = Math.Floor(4.7); // en yakın aşağı yuvarlar.

Console.WriteLine($"x: {x}, y: {y}, z:{z}");




// 3- Karşılaştırma operatörleri (==,!=,<,>,<=,>=,?:)

int n=5, s=5, f=10, m=4;
string username ="melistunç";
string password = "12345";

var result = (n ==s); //true a eşit mi b'ye
result = (n == f); //false a eşit mi c'ye 

result = (username == "melistunç"); // true
result = (password == "12432"); //false

result = (n != f); // n, s'ye eşit değil mi. true
result = (n != s); //false. 
result = (n > s); //false 
result = (f >m ); //false
result = (n >= s ); //true
result = (f <= m ); //false
string sonuc = (n == s)?"n=s":"n!=s"; // doğruysa n=s yazsın yanlışsa n!=s yazsın.
sonuc = (username =="melistunç")?
                  (password == "12432")?"password true":"password false":
                  (password == "12432")?"password true":"password false";



// 4- Mantıksal operatörler (&&,||,!)
int l = 5;
var result1 = (l>5);
result1 = (l<10);
int hak = 6;
char devam='e';

//5<x<10 and(&&)
//true && true = true
// false && true = false
//false && false = false
result1 = (x>5) && (x<10); //true 
result1 = (x<5) && (x<10); //false
result1 = (hak>0) && (devam == 'e'); //true

//or(||)
//true && true = true
//true && false = true
//false && false = false
result1 = (x > 0) || ( x % 2 ==0); // sayı sıfırdan büyükse ve sayı çift sayı ise true.


// not (!)
// true => false
//false => true
result1 = !(x>0); //false. x sıfırdan küçük değilse true.

//x, 5-10 arasında olan bir çift sayı mıdır?
result1 = ((x>5) && (x<10)) && (x%2 == 0); //true && true = true