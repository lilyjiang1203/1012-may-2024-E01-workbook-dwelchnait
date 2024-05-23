// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tWeek One Problem Two\n\n");

///<summary>
/// Name: Don Welch
/// Assignment: Week One Problems: Problem 2
/// Last Updated: may 22 2024
///  
/// 
/// Detail Steps
/// 
/// DECLARE constant PERCENT_SAVINGS as Float (in C# this would be either a double or decimal)
/// DECLARE ManualCost as Float
/// DECLARE SavingsAmount as Float
/// PROMPT “Enter the current system cost:” ManualCost
/// Set SavingAmount  = ManualCost * PERCENT_SAVINGS
/// DISPLAY “The savings on the cost is [SavingAmount]”
/// 
///</summary>
///

//a constant CANNOT be changed within the program once declared
//to change a constant you need to change your code and re-compile
const double PERCENT_SAVINGS = 0.15;

string inputValue = ""; //this is used by the reading of the data
decimal ManualCost = 0.0m; //m indicates that the literal is a decimal type
                           //d indicates that the literal is a double (default)
decimal SavingsAmount = 0.0m;
Console.Write("Enter the current system cost:\t");
inputValue = Console.ReadLine();
ManualCost = decimal.Parse(inputValue); //change the string to the desired datatype
SavingsAmount = ManualCost * (decimal)PERCENT_SAVINGS;
Console.WriteLine($"\nThe savings on the cost is {SavingsAmount.ToString("#,##0.00")}\n");

