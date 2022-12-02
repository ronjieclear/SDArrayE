using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDArrayE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Dimension Array");
            //Create a Single D Array
            string[] fruits = new string[4];
            //Assigning value to the array index
            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Cherry";
            fruits[3] = "Dalandan";
            //fruits[4] = "Elderberry"; // Produce error due to out of bounds

            //To determine the size of the existing array
            int capacityofarray = fruits.Length; //retrived the size of the array fruits
            Console.WriteLine($"Size of fruit array: {capacityofarray}");
            
            //To resize the array
            Array.Resize(ref fruits, capacityofarray + 1);
            //determing the new size of the array
            capacityofarray = fruits.Length; //retrived the size of the array fruits
            Console.WriteLine($"New size of fruit array: {capacityofarray}");

            //Add new value to the new blacnk index
            fruits[4] = "Elderberry";

            //To display the value of an array 
            Console.WriteLine(fruits[1]); //This will display Banana
            Console.WriteLine(fruits[4]);//This will display Elderberry

            //Create a dynamic array with value initialization
            string[] prutas = new string[] {"Atis","Bayabas","Chico","Durian","Guyabano","Santol","SUha"};
            
            //Display the value 
/*            Console.WriteLine(prutas[0]);
            Console.WriteLine(prutas[1]);
            Console.WriteLine(prutas[2]);
            Console.WriteLine(prutas[3]);
            Console.WriteLine(prutas[4]);*/

            //Display value using a loop
/*            for(int i=0;i<prutas.Length;i++)
            {
                Console.WriteLine(prutas[i]);
            }*/
            
            //Display the value using foreach loop
            foreach (string vh in prutas)
            {
                Console.WriteLine(vh);
            }



            Console.ReadLine();
        }
    }
}
