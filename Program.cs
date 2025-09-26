using System;
class program
{
       static void Main()
    {
        int n = 7;
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + "");
            }
            Console.WriteLine();
        }
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
            Console.Write(j + "");
            }
            Console.WriteLine();
        }
    }
}
