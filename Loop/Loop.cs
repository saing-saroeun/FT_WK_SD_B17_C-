using System;
using System.Collections.Generic;
using System.Linq;
using System;


namespace M2_Loop
{
    public class Loop
    {
        public static void Menu()
        {



            Console.WriteLine("=====Welcome to Loop using===== : ");
            Console.WriteLine("1. Home");
            Console.WriteLine("2. About Us");
            Console.WriteLine("3. Cpntact us");
            Console.WriteLine("4. Privacy");
            Console.WriteLine("5. EXit");
            Console.WriteLine("Please select an option 1-5 : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            switch (input)
            {
                case 1:
                   Console.WriteLine("Welcome Home page ");
                break;  
                case 2:
                   Console.WriteLine("Welcome About us ");
                break;
                case 3:
                   Console.WriteLine("Welcome Contact us ");
                break;
                case 4:
                   Console.WriteLine("Welcome Privacy ");
                break;
                case 5:
                    System.Environment.Exit(5);
                break;
            }
            Console.ReadKey();
            
            
        }







    }

















}


    




