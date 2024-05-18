// See https://aka.ms/new-console-template for more information

// any line with a double slash at the front is a comment

//this line of code will display the string that is
//  within the double quotes
//.WriteLine will write the string and more your cursor
//      to the next line on the screen

//the following is a aplha numeric variable capable of
//  holding both numbers and characters
//the characters within the double quotes is a literal

using static System.Runtime.InteropServices.JavaScript.JSType;

//string myName = "Don";
//int classSize = 15, floorNumber;

//string alpha-number characters
//int is an integer
//double is a number with decimal places
//decimal is a number with more decial places
//bool is boolean holding either true or false 

//How can one use a variable within a string message

//concatenation
//Console.WriteLine("Hello " + myName + ", World!");

//string interperlation
//Console.WriteLine($"Hello {myName}, World!");

//this line of code will wait until the user presses
//  a key on their keyboard
//Console.ReadKey();

///<summary>
/// Name: Don Welch
/// Assignment: Week One Problems: Problem 1
/// Last Updated: may 17 2024
///  
/// 
/// Detail Steps
/// 
///Declare Conversion Rate as float (C# coding conventions ConversionRate)
///Declare Audience Size as integer (C# coding conventions AudienceSize)
///Declare number of conversions as integer (C# coding conventions NumberOfConversions)
///Prompt the user for “Enter the conversion rate:”
///Input(Read) the conversion rate
///Prompt the user for “Enter the audience size:”
///Input(Read) the audience size
///Calculate the number of conversions: Number of conversions = conversion rate X audience size
///Display the Number of conversions to the user
/// 
///</summary>

// camelCase: the first word starts with a lower case character, all other words in the variable 
//              start with a capital
// PascalCase (TitleCase): each word in the variable starts with a capital
// CAPITAL_CASE: this is reserved for constants within your program

double conversionRate; //this statement declares a variable of datatype double with a name of conversionRate
int audienceSize;
int numberOfConversions;
string inputValue;

//PROMPT
//The Console class has a number of methods for a coder to use for input and output into/outof the program
//Console.Write(....); will output a string to your console window AND keep the cursor on the same line
//Console.WriteLine(....); will output a string to your console window AND move the cursor to the next line

//you can use special wildcard character to help with spacing during your input/ouput
// \t go to the start of the next tab alignment on the line
// \n go to the next line (leave a blank line)
Console.Write("\n\nEnter the conversion rate (example seven and one half percent as 7.5):\t\t");

//READ what the user typed on the screen
//I need to store the incoming information into a variable.
//
//ALL INCOMING DATA IS BROUGHT INTO YOUR PROGRAM AS A STRING DATATYPE!!!!!!!!!
//
inputValue = Console.ReadLine();
conversionRate = double.Parse(inputValue);

Console.Write("Enter the audience size:\t");

//variables can be RE-USED.
//HOWEVER: WARNING!!!!!!: VARIABLES CAN ONLY HOLD ONE ITEM (DATA PIECE) AT A TIME!!!!
//ANY VALUE THAT WAS IN inputValue IS NOW GONE, IT IS NO MORE, IT IS HISTORY!!!!!
//A NEW VALUE NOW EXISTS WITHIN inputValue
inputValue = Console.ReadLine();
audienceSize = int.Parse(inputValue);

//Calculation
//Arithmetic
//casting a equation:
// place the desired data type in (...) in front of your equation.
// in the following example the equation will be cast (changed) to an integer (int)
//WARNING:  this cast will cause truncation of decimals

// conversionRate (double) divided by a double literal 100.0
// this results in a double
// audienceSize (int) multipled by the results of the divison
//  an integer * double gives a double
// the (int) will cast the result of the calculation (double) into an integer
//  this will truncate the decimal portion of the double value.
numberOfConversions = (int)(audienceSize * (conversionRate / 100.0));

//diplay the results
Console.WriteLine($"The expected audience size will be {numberOfConversions}");