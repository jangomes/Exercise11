using System;

namespace Exercise11
{
    class Program
    {
        /*Write a program for a package delivery service. The program contains an array that holds the 
            ten zip codes to which the company delivers packages. Prompt a user to enter a zip code and 
            display a message indicating whether the zip code is one to which the company delivers.*/
        static void Main(string[] args)
        {

            string[] zipCode = {"D01A3M2","D10I9R0", "D02F6H7", "D14S2S2","D01H2N2"  };

            Console.WriteLine("Please insert your zip code: ");
            string zipCodeUser = Console.ReadLine();

            bool contains = false;


            for (int i = 0; i < zipCode.Length; i++)
            {
                if (zipCodeUser == zipCode[i])
                {
                    contains = true;
                    break;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("We deliver to you home");
                
            }
            else
            {
                Console.WriteLine("We don't deliver to you home");
            }


        }
    }
}
