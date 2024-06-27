// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tIts a bunch of small worlds (after all)\n");

//the part of your program that is the "control" portion is often called the driver

//Driver
//  controls the main processing of a program
//  declares the data storage required in the program
//  it calls any methods that are required to complete
//      the program process


//the driver will get assistance from small chucks of code which are the methods

//Methods
//  individual coding components
//  perform a single task
//  called by the driver OR by another method

//Problem: Create a simple calculator
// the calculator will add, subtract, multiple or divide
// the calculator will input 2 numbers from the user
// the user will select a menu choice as to the action against the two numbers
// the calculator will display the result of the menu action

#region Driver controller
int num1 = 0;
int num2 = 0;
double result = 0.0;
string choice = "";

//method call statement
//uses the method name and supplies any required values for parameters
//the values for the parameters are called arguments on the call statement
//the order of the arguments and datatypes must match the parameter will
//the argument name DOES NOT need to match the parameter name
//the arguments are your data store in the driver routine

//the call will return an integer value
//the method to call is GetIntegerNumber(string)
//the argument required for the method is a string
num1 = GetIntegerNumber("Enter you first calculation number.");

//reuse the method to get the second number
num2 = GetIntegerNumber("Enter you second calculation number.");

Console.WriteLine($"\nNumber 1: {num1} and Number 2: {num2}");
#endregion

#region Methods

// create a component of code to do a specific task
// Task: get an integer number
// process:
//      prompt for the number
//      read the number
//      (validation should be done ensuring it is a number: integer)
//      return the entered integer

//what is the structure of a method
//syntax : method header () { method code }

//Method Header components
//  a) return datatype
//  b) method name
//  c) optional list of parameters (values passed into the method)

//  returndatatype methodname ([list of parameters])
//  {
//          method code
//      [return value]
//  }

//return datatype
//  valid C# datatype
//  if the method is to return NO value, use the keyword: void

//methodname
//  programmer defined name
//  should be meaningful
//  Pascal Case

//list of parameters
//  optional
//  parameter synatx: datatype localvariablename
//  separate the list of parameters using a comma ,
//  a parameter many be assigned a defualt value
//  parameters with a default value must be at the end of the parameter list

//RULE:
//the order of incoming parameters DICTATE the order of the arguments
//      on the call statement
//the argument/parameter pair MUST have the same datatype

//Is datatype important?
//YES
//VALUE type parameters receive a COPY of the argument value
//      any changes to the parameter within your method code
//          remains within the method.
//      changes DO NOT affect the data in the driver code
//REFERNECE type parameters
//      reference variables contain the address of where the actual data exists
//      this address is passed to the method
//      any changes to data at this address remains after exiting the method
//      therefore when you return to the driver code, method changes can be viewed
//          in the original data.

//the use of the keyword "static" isolates the content of the method
//      to within the method. It DOES NOT allow for global variables.
//      It forces the programmer to properly scope the variables for the mehtod
//using static is an optional choice

//FOR OUR COURSE TO ENSURE APPROPRIATE METHOD DEVELOPMENT, WE WILL USE
//  THE KEYWORD  "static" ON ALL OF OUR METHODS


//methods that return a value are commonly called functions
//methods that do not return a value are commonly called subroutines
static int GetIntegerNumber(string prompt)
{
    //a properly structure method has
    //  a) a Single entry point (method header)
    //  b) a SINGLE exit point (the physical end of the method OR a
    //      SINGLE return statement

    //method scope
    //variable declared within a method exist as long as the method is executing
    //each time the method is called, the variables are recreated.
    //treat your parameters as if they are local variables
    string inputValue = "";
    int localNumber = 0;
    Console.Write($"{prompt}\t:");
    inputValue = Console.ReadLine();
    //do appropriate validation on user input value

    localNumber = int.Parse(inputValue);

    //if you have a returndatatype other than void, you MUST have a return statement
    //the return statement has a SINGLE value
    //the datatype of the value MUST match the returndatatype on the method header
    return localNumber;
}
#endregion
