using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace M2_Loop
{
    class program
    {
        public static int i = 0;
        static void whileloop()
        {
            
            while (i < 5)
            {
                Console.WriteLine($"The value are : {i} ");
                i++;
            }
           
        }
        static void dowhileloop()
        {
            
           
            do
            {
                Console.WriteLine($"The value are : {i} ");
                    i++;
                
            }while(i<5);

        }
        static void forloop()
        {
           
            for (i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine($"The value are : {i} ");
            }
            
        }
        static void Main(String[] args)
        {
            Loop.Menu();






        }
    }
}