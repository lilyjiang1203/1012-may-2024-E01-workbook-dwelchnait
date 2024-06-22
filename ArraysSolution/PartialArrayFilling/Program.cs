// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Partial Array filling\n\n");

const int PHYSICALSIZE = 10;
int[] numbers = new int[PHYSICALSIZE];

//this variable will contain a number representing the actual number of elements used
//  in the array
int logicalSize = 0;

string inputValue = "";
int num = 0;
bool flag = true;
double sumOfNumbers = 0.0;
double averageOfNumbers = 0.0;

while(flag)
{
    if (logicalSize == PHYSICALSIZE)
    {
        //no more room available in the array
        flag = false;
        Console.WriteLine("\n\nArray is full.\n\n");
    }
    else
    {
        Console.Write("Enter a positive number (enter a character to quit):\t ");
        inputValue = Console.ReadLine();
        if (int.TryParse(inputValue, out num))
        {
            //logicalSize in indicating the next available array element to use
            //once the loop is completed then logicalSize will hold a value indicating
            //  how many actual array elements have been used
            numbers[logicalSize] = num;

            //change the logicalSize to point to the next available array element
            logicalSize++;
        }
        else
        {
            flag = false; //set the loop execution condition to false (exit loop)
        }
    }
}

//the entire array
Console.WriteLine("the entire array\n");
for (int index = 0; index < numbers.Length; index++)
{
    Console.WriteLine($"The number at index {index} is {numbers[index]}");
    sumOfNumbers += numbers[index];
}//eof
Console.WriteLine($"The average of the array numbers is: {sumOfNumbers / PHYSICALSIZE}");

//the used portion of the array
//the termination of this loop is when the actual elements used are display
Console.WriteLine("\n\nOnly the used portion of the array\n");
sumOfNumbers = 0;
for (int index = 0; index < logicalSize; index++)
{
    Console.WriteLine($"The number at index {index} is {numbers[index]}");
    sumOfNumbers += numbers[index];
}//eof
Console.WriteLine($"The average of the array numbers is: {sumOfNumbers / logicalSize}");