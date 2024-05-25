// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tHello, Math World!\n\n");

///<summary>
///Author: Don Welch
///Last Modified: May 24, 2024
///Problem : Cylinder Area and Volume
///Write a program that reads in the radius and length of a cylinder and 
///computes the area and volume using the formulas: 
///area = radius ∗ radius ∗ 𝜋𝜋 
///volume = 𝑎rea ∗ length 
/// 
/// Detail Steps
/// DECLARE radius as double
/// DECLARE length as double
/// DECLARE area as double
/// DECLARE volume as double
/// DECLARE inputValue as string
/// PROMPT "Enter cylinder radius:" radius
/// READ radius
/// PROMPT "Enter cylinder length:" length
/// READ length
/// SET area = radius ∗ radius ∗ 𝜋𝜋 (pi)
/// SET volume = area * length
/// DISPLAY calculated area and volume
/// </summary>

//in this example my variables will be using Camel Case
//the first letter in your first word making up your variable name is lower case
//the first letter in each of the remaining words making up your variable name are upper case
//if your variable has ONLY ONE word the first letter is still lower case

double radius = 0.0, length = 0.0; //example of multiple variables declared on one line
double area; //if no initial value assigned at declaration the system default is assigned
double volume = 0.0;
string inputValue = "";

Console.Write("Enter the cylinder radius: \t");
//inputValue = Console.ReadLine();
//radius = double.Parse(inputValue);
radius = double.Parse(Console.ReadLine()); //fine IF proper data ALWAYS entered

Console.Write("Enter the cylinder length: \t");
inputValue = Console.ReadLine();
length = double.Parse(inputValue);

//area = radius * radius * double.Pi;     //way one
//area = radius * radius * Math.PI;       //way two
area = Math.Pow(radius, 2) * Math.PI;   //way three

volume = area * length;

//the format rounds on the final digit
//rules 5 -> rounds up :  <- 4 rounds down
Console.WriteLine($"The cylinder area is {area.ToString("#,##0.0000")}"); // 99.3000 102.0000 1,509.0000
//the Math Round control the rounding
Console.WriteLine($"The cylinder area is {Math.Round(area,4,MidpointRounding.ToZero)}"); // 99.3000 102.0000 1,509.0000

Console.WriteLine($"The cylinder volume is {volume.ToString("0.0")}");
