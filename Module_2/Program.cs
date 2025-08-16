// See https://aka.ms/new-console-template for more information

int dayofweek;

Console.WriteLine("Please Inpute Your Day of Week: ");
dayofweek = Convert.ToInt32(Console.ReadLine());
//dayofweek = int.Parse(Console.ReadLine());

if (dayofweek == 1)
{
	Console.WriteLine("Sunday");
}
else if (dayofweek == 2)
{
	Console.WriteLine("Monday");
}
else if (dayofweek == 3)
{
	Console.WriteLine("Tuesday");
}
else if (dayofweek == 4)
{
	Console.WriteLine("Wenesday");
}
else if (dayofweek == 5)
{
	Console.WriteLine("Thurday");
}
else if (dayofweek == 6)
{
	Console.WriteLine("Friday");
}
else if (dayofweek == 7)
{
	Console.WriteLine("Saturday");
}
else
{
	Console.WriteLine("Invalid Date Of Week Number");
}



