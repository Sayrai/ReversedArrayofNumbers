using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbersFunc
{
    class Program
    {
        private int[] listOfNumbers;
        private static string userInputs;



        //public object FirstNumber { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Number Game");

            Console.Write("Enter Four Number");
            int listOfNumbers = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Your reversed numbers are : " + userInputs);
            Console.ReadLine();

        }


        public static int ReversedArrayOfNumbers(int[] listOfNumbers)
        {
            
            int[] arrInt = listOfNumbers;
           
            Array.Reverse(arrInt);

            return arrInt[3];
        }
    }
}
