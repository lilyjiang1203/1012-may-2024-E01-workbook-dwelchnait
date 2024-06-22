// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;

Console.WriteLine("\n\tWelcome to the Collective\n\n");

//a single variable
//holds a single value
//it can be altered
//syntax:  datatype name;
int grade = 78;

//a Collection
//C# supports various kinds of collections
//we will concentration at this time on Arrays
//an array represents a number of values of the same datatype
//referencing a particular value within the collection can be done using an "index"
//arrays are fixed size collections
//arrays hold a single datatype of values
//you must specify the maximum size of your array before you can use it
//if you try to reference an item via the index and the index is < 0 or greater then the max size, your
//  code will abort with an expection
//each value in the array can be referred to as the array element.
//syntax:  datatype [] arrayname [= new datatype[max-size]];

//Create an array of grades for a class of size 33
//We will fill the array with a random set of grades between 0 and 100.

//you might wish to create a constant variable for your array max size
const int PHYSICALSIZE = 33;

//declaration
//double [] grades;

//set the size

//grades = new double[33]; //you can use a literal
//grades = new double[PHYSICALSIZE]; //you can use a variable (constant)

//one can combine your declaration and set in one statement

double[] grades = new double[PHYSICALSIZE];

//create the Random number generator
Random rnd = new Random();

for (int index = 0; index < grades.Length; index++)
{
    //Console.WriteLine($"The grade at index {index} is {grades[index]}");
}//eof

//traverse (walk through the array) the array filling in each element with a
//  random value between 0 and 100 inclusive
//since arrays are of a particular size and referencing an array element
//  is via a numeric index, the preferred iteration structure would be the for loop
//the index of this array is 0 through 32 (the natural count is 1 to 33)
for (int index = 0; index < PHYSICALSIZE; index++)
{
    //syntax to reference an array element is:  arrayname[index]
    grades[index] = (double)rnd.Next(0, 10000) / 100.0;
    
}//eof

//scope of index in the for
//any variable declared within the for loop is known only to the for loop
//so here index would be undeclared
//Console.WriteLine($"the current value of index is {index}");

//the array max size can be obtained via an array property
//this property is called Length
for(int index = 0; index < grades.Length; index++)
{
    //Console.WriteLine($"The grade at index {index} is {grades[index]}");
}//eof

//declaring the array size by supplying a set of values on the declaring statement
//when you supply a set of values, the system automatically set the size of your array
//  to the number of values
//using this technique not only gives the array its size BUT ALSO its initial element values
string[] dayOfWeek = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

for (int index = 0; index < dayOfWeek.Length; index++)
{
   // Console.WriteLine($"The week day at index {index} is {dayOfWeek[index]}");
}//eof

//order your array values by using a method of arrays called Sort
//Array.Sort(grades); //ascending the sort form

//Array.Sort(grades, (x, y) => x.CompareTo(y)); //ascending
Array.Sort(grades, (x, y) => y.CompareTo(x)); //descending

for (int index = 0; index < grades.Length; index++)
{
    Console.WriteLine($"The grade at index {index} is {grades[index]}");
}//eof

