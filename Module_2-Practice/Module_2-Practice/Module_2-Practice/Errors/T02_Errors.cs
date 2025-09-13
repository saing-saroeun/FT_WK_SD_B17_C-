using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T02_Errors
	{
		static void Main(string[] args)
		{
			int age = "20"; // ❌ ERROR: assigning string to int
			string name = 123; // ❌ ERROR: assigning int to string

			{
				int innerVar = "50"; // ❌ ERROR: wrong type
			}

			Console.WriteLine("Age: " + Age); // ❌ ERROR: variable name mismatch
			Console.WriteLine("Name: " + Name); // ❌ ERROR: variable name mismatch
		}
	}
}
