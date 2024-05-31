// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tHello, Pythagorean Theorem !\n\n");

///<summary>
///Author: Don Welch
///Last Modified: May 27 2024
///
/// Problem:
/// The Pythagorean Theorem can be used to find the length of the 
/// hypotenuse of a right triangle.  Write a program that can solve 
/// for the hypotenuse once provided with the height and 
/// base of the right triangle. Use double lengths.
/// 
/// forumla: hypotenuse = sqrt ( side a * a + side  b * b)
/// 
/// Detail Steps
/// 
/// </summary>
/// 

double heightLength, baseLength;
string inputValue;
double hypotenuse;

Console.Write("Enter your height value: \t");
inputValue = Console.ReadLine();
heightLength = double.Parse(inputValue);

Console.Write("Enter your base value: \t");
inputValue = Console.ReadLine();
baseLength = double.Parse(inputValue);

//rules of math
// items within (...) are done first
// * and / , left to right
// + and - , left to right
hypotenuse = Math.Sqrt(heightLength * heightLength + Math.Pow(baseLength,2));

Console.WriteLine($"\nThe hypotenuse of a triangle with a height of {heightLength}" +
    $" and a base of {baseLength} is {hypotenuse.ToString("0.000")}");