using System;

namespace DataTypesPractice
{
    class Program
    {
        // Global variable example
        static string globalMessage = "Hello from global scope!";

        static void Main(string[] args)
        {
            // ================================
            // 1. DATA TYPES
            // ================================

            // Integer data types
            int age = 25;                 // integer literal
            long population = 8000000000; // large integer

            // Floating-point data types
            float pi = 3.14f;              // 'f' suffix for float literal
            double e = 2.718281828;        // double literal

            // Character data type
            char grade = 'A';

            // Other types
            bool isStudent = true;         // boolean
            string name = "Alice";         // string

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
            Console.WriteLine($"Pi: {pi}, e: {e}");
            Console.WriteLine($"Population: {population}, Student? {isStudent}");

            // ================================
            // 2. LITERALS
            // ================================
            Console.WriteLine("Literal examples:");
            Console.WriteLine(100);         // integer literal
            Console.WriteLine(5.67);        // double literal
            Console.WriteLine('Z');         // char literal
            Console.WriteLine(true);        // boolean literal
            Console.WriteLine("This is a string literal.");

            // ================================
            // 3. VARIABLES & SCOPE
            // ================================
            Console.WriteLine(globalMessage); // accessing global variable

            string localMessage = "Hello from local scope!";
            Console.WriteLine(localMessage);

            // This will cause an ERROR if uncommented (variable out of scope)
            // Console.WriteLine(innerMessage);

            {
                string innerMessage = "Hello from inner block!";
                Console.WriteLine(innerMessage);
            }

            // ================================
            // 4. ANONYMOUS TYPES
            // ================================
            var person = new { FirstName = "John", LastName = "Doe", Age = 30 };
            Console.WriteLine($"Anonymous type: {person.FirstName} {person.LastName}, Age {person.Age}");

            // Intentional ERROR (anonymous types are immutable)
            // person.Age = 31; // Uncomment to see error

            // ================================
            // EXERCISES
            // ================================

            // TODO 1: Create your own variables for:
            //   - an integer, a double, a char, and a string
            //   - print them in one line

            // TODO 2: Create an anonymous type for a car
            //   - include brand, model, and year
            //   - print all values

            // TODO 3: Create a variable inside a block, try to print it outside, and see the error

            // TODO 4: Try changing a literal's type (e.g., make 3.14 an integer) and fix the error

            Console.ReadKey();
        }
    }
}
