// See https://aka.ms/new-console-template for more information

// any line with a double slash at the front is a comment

//this line of code will display the string that is
//  within the double quotes
//.WriteLine will write the string and more your cursor
//      to the next line on the screen

//the following is a aplha numeric variable capable of
//  holding both numbers and characters
//the characters within the double quotes is a literal

string myName = "Don";
int classSize = 15, floorNumber;

//string alpha-number characters
//int is an integer
//double is a number with decimal places
//decimal is a number with more decial places
//bool is boolean holding either true or false 

//How can one use a variable within a string message

//concatenation
Console.WriteLine("Hello " + myName + ", World!");

//string interperlation
Console.WriteLine($"Hello {myName}, World!");

//this line of code will wait until the user presses
//  a key on their keyboard
Console.ReadKey();
