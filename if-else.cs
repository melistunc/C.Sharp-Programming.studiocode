using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

           //var isLoggedin = true;
           //if(isLoggedin)
           // Console.WriteLine("hoş geldiniz."); if koşulu true olduğu için writeline çalışır.

            //if(isLoggedin == 0) şeklinde yazarsak isloggedlin true mu diye sormuş oluruz.
            
            
            string username = "melistunc";
            string password = "1234";

            //var isLoggedin = (username == "melistunc") && (password == "1234"); //isloggedin de username melistunc ve pasw 1234 mü? 

            if ((username == "melistunc") && (password == "1234")) {
              Console.WriteLine("bilgileriniz doğru");
              Console.WriteLine("hoş geldiniz."); } //bir tane kod bloğu varsa süslü koymaya gerek yok ama çok satırda süslü parantez kullanırız.

              
            if (username == "melistunc") { 
                if(password == "1234"){ //iç içe for döngüsü.
              Console.WriteLine("bilgileriniz doğru");
              Console.WriteLine("hoş geldiniz."); }

              else 
              {
                Console.WriteLine("username doğru fakat password yanlış");
              }
            }

             else
              Console.WriteLine("parola yanlış"); //username veya parola yanlış olduğunda burası çalışır.

         }
}
}