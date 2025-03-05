using System;

namespace ConsoleApp{
class Conversion{
         static void Main(string[] args){

            //string[] names = new string[5]; //names isimli dizi. 5 alanlı. 

            
            //names[0] = "lila";
            //names[1] = "lily";
            //names[2] = "kate";
            //names[3] = "vanessa";
            //names[4] = "jennie";

            string[] names = {"lily", "lila", "kate", "vanessa", "jennie"};

            names[0] = "rose"; //sıfırıncı elemana lily demiştirk fakat bunu sonradan değiştriebilirz. artık sıfırıncı eleman ismi rose oldu.

            //int[] numbers = new int [5];

            //numbers[0] = 22;
            //numbers[1] = 23;
            //numbers[2] = 24;
            //numbers[3] = 25;
            //numbers[4] = 26;

            int [] numbers = {22, 23, 24, 25, 26};

            numbers[3] = 27; //üçüncü indexi artık 27 olarak değiştirdik eskiden 25'ti. 

            Console.WriteLine($"name: {names[4]} and number: {numbers[3]}");
         }
}
}