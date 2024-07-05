//Name: Don welch
//Assignment: 3
//Last Modified: July 5 2024


Console.WriteLine("\n\tIns and Outs of file processing\n\n");

//Create a collection of records for a class. We will collect the student names and their marks for
//  a course. Assume a maximum number of students as 25.

//Detail Steps
//Create 2 arrays for student names and marks (physical size 25)
//Create counter for array logical size
//Declare filename as constant

//Driver
//Call method to read the class list from file
//Call method to display the class list
//Call method to add a student
//Call method to display the class list
//Call method to write the class list to file


//Methods
//int ReadNamesandMarks(string[] studentNames, double[] studentMarks, string fileName)
//void DisplayClassList(string[] studentNames, double[] studentMarks, int logicalSize)
//int AddStudentandMark(string[] studentNames, double[] studentMarks, int logicalSize)
//void WriteNamesandMark(string[] studentNames, double[] studentMarks, int logicalSize, string fileName)

//Driver
const int PHYSICALSIZE = 25;
const string FILENAME = "CourseGrades.txt"; //could also be a .csv file
string[] studentNames = new string[PHYSICALSIZE];
double[] studentMarks = new double[PHYSICALSIZE];
int logicalSize = 0;

logicalSize = ReadNamesandMarks(studentNames,studentMarks, FILENAME);
DisplayClassList(studentNames,studentMarks,logicalSize);
logicalSize = AddStudentandMark(studentNames, studentMarks, logicalSize);
DisplayClassList(studentNames, studentMarks, logicalSize);
WriteNamesandMark(studentNames, studentMarks, logicalSize, FILENAME);

//Methods
static int ReadNamesandMarks(string[] studentNames, double[] studentMarks, string fileName)
{
    int countOfRecordsRead = 0;
    return countOfRecordsRead;
}

static void DisplayClassList(string[] studentNames, double[] studentMarks, int logicalSize)
{
    //display the class list with marks in a formatted column table

    //method reminder: reference parameters receive the address of the actual data (arrays)
    //                 value parameters receive a copy of the argument value (logicalSize)
    //                 treat your parameters as if they are local variables to the method

    Console.WriteLine("The following is your students and their marks\n\n");
    Console.WriteLine("{0,-25} {1,6:f1}", "Student","Grade");
    Console.WriteLine("{0,-25} {1,6:f1}", "=".PadRight(24,'='), "=".PadRight(5,'='));

    for(int i = 0; i < logicalSize; i++)
    {
        Console.WriteLine("{0,-25} {1,6:f1}", studentNames[i], studentMarks[i]);
    }
}

static int AddStudentandMark(string[] studentNames, double[] studentMarks, int logicalSize)
{
    return logicalSize;
}

static void WriteNamesandMark(string[] studentNames, double[] studentMarks, int logicalSize, string fileName)
{

}