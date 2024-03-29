﻿//* change color
Console.ForegroundColor = ConsoleColor.DarkMagenta;

//* change console title
Console.Title = "Average Calculator";

//* find average of 3 numbers
double num01, num02, num03, result;

Console.Write("Input the first number: ");
num01 = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Input the second number: ");
num02 = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Input the third number: ");
num03 = Convert.ToDouble(Console.ReadLine());

result = num01 + num02 + num03;
result /= 3;

Console.WriteLine("The average of " + num01 + ", " + num02 + ", " + num03 + " is " + result + ".");

Console.ReadKey();