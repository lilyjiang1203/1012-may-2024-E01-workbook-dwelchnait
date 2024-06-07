// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tUsing Branch If Technique\n\n");

/*
 * Problem:
 * Write a program that will determine the cost of admission for a theatre.  
 * The price of admission is based on the age of the customer.  
 * Your program should prompt the user for their age and then display the correct 
 * admission amount.  
 * 
 * Children 6 and under = FREE ($0.00) 
 * Students 7 to 17 = $9.80 
 * Adults 18 to 54 = $11.35 
 * Seniors 55+ = $10.00 
 * 
 * this problem can be solved using a nested if technique
 * it can also be solve using the branching if-else if-else technique
 * 
 * syntax:
 * 
 *   if (condition(s))
 *   {
 *      true path
 *   }  
 *   else if (condition(s)
 *   {
 *      true path
 *   }
 *   [else if (condition(s))
 *    {
 *       true path
 *    } ....]
 *   else
 *   {
 *      required
 *      only false path (the "left overs")
 *   }
 */

int age = 0;
double admissionAmount = 0.0;
string inputValue;

Console.Write("Enter your age:\t");
inputValue = Console.ReadLine();
if (!int.TryParse(inputValue, out age))
{
    // not a integer number
    Console.WriteLine($"\n\tYou input of >{inputValue}< is not a number\n");
}
else if (age < 0)
{
    // is a number but it is negative
    Console.WriteLine($"\n\tYou input of >{age}< is not a positive value (greater of equal to 0)\n");
}
else
{
    //data is valid
    //NOTE: the condition operator is NOT JUST ==
    if (age <= 6)
    {
        admissionAmount = 0.0;
    }
    else if (age > 6 && age <= 17) //the first first is optional age > 6 &&
    {
        admissionAmount = 9.80;
    }
    else if (age <= 54)
    {
        admissionAmount = 11.35;
    }
    else
    {
        admissionAmount = 10.00;
    }

    Console.WriteLine($"\n\tA ticket for your age of {age} will cost ${admissionAmount.ToString("0.00")}\n");
}
