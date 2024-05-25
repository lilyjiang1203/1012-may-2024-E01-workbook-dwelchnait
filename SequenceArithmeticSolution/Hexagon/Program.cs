// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tHello, Math World!\n\n");

///<summary>
///Author: don Welch
///Last Modified : May 24 2024
///Problem:
///Write a program that prompts the user to enter the side of a hexagon and displays its area. 
///The formula for computing the area of a hexagon is: 
/// area = (3 * sqrt(3) / 2) * (s * s) where s is the length of the side.
/// 
/// Detail Steps
/// .....
/// </summary>

string inputValue = "";
double lengthOfSide = 0.0;
double hexagonArea = 0.0;

Console.Write("Enter the length of the side:\t");
inputValue = Console.ReadLine();
lengthOfSide = double.Parse(inputValue);

//calculation
//more practice with the Math class
//rules of Math still apply in coding
// multiplication and division before addition and substration
// equal level operations left to right
// operations with (... ) are done first

hexagonArea = (3 * Math.Sqrt(3) / 2) * (Math.Pow(lengthOfSide,2));

Console.WriteLine($"\nThe area of the hexagon with a side length of {lengthOfSide} is {hexagonArea.ToString("0.0000")}");