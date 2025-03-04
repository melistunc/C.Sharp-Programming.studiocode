using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){ 

            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("surname: ");
            string surname = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            //string name = "Lily Rose";
            //string surname = "Depp";
            //int age = 27;

            //string str = name+ surname+ " "+ "playing Nosferatu. She is"+" " +age+ " "+ "years old.";
            
            //string str = $"Her name is {name} {surname} and she is {age} years old."
            
            string str= string.Format("Her name is {0} {1} and she is {2} {0} years old", name,surname,age); //burada virgülden sonra gelen ilk değişken 0, ikincisi 1, üçüncüsü 2 numarasını alır.


            Console.WriteLine(str);

         }
}
}