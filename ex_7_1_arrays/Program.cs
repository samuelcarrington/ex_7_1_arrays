using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_1_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7-1 Arrays  
            1. Create an array of type integer that includes the numbers 1-10. 
            2. Create an array of type string that includes the months of the year. 
            3. Print to the console the fifth month of the year. 
            4. Print to the console the sum of the third and eighth numbers. 
            5. Print to the console all of the numbers using a for loop. 
            6. Print to the console all of the months of the year using a foreach loop. 
            7. Print to the console the months of the year in reverse order.*/

            //1. Create an array of type integer that includes the numbers 1-10. 
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //2. Create an array of type string that includes the months of the year. 
            string[] monthsOfYear = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //3. Print to the console the fifth month of the year.
            Console.WriteLine(monthsOfYear[4]);

            //4. Print to the console the sum of the third and eighth numbers.
            int sum = array[2] + array[7];
            Console.WriteLine(sum);

            //5. Print to the console all of the numbers using a for loop.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //6. Print to the console all of the months of the year using a foreach loop. 
            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.Write(monthsOfYear[i] + " ");
            }
            Console.WriteLine();

            //7. Print to the console the months of the year in reverse order.
            Array.Reverse(monthsOfYear);
            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.Write(monthsOfYear[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
