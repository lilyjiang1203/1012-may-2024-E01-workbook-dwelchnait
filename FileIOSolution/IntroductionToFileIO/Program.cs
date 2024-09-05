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
    //the skeleton of the method is often referred to as a method stub
    //method reminder: parameters are "treated" as local variables

    //place a few comments within the method to explain what the method will do
    //Purpose: Read the course grades file and store the data to the arrays

    //steps:
    // a) Declare local variables: StreamReader, counter, input string
    // b) Test to see if the file exists
    //    1) no: display an appropriate message and exit method
    //    2) yes: read the file
    //            process each file record on at a time
    //            for each record, split data and store into arrays
    //            increment record count for each record read

    int countOfRecordsRead = 0;
    string inputLine = "";

    //there are a couple of techniques to use to read a file
    //StreamReader (this course uses the StreamReader/StreamWriter technique)
    //  is useful if you have a very large file and your intention
    //      is that you may not be reading the entire file
    //      OR
    //      the file will not total fit in your machine
    //use the System.IO.File class
    //  is class have serval methods create that allow for
    //      reading of files that are not extremely large
    //      AND your intent is to read the entire file

    //Need to know
    //a) where is the file located on your machine
    //b) what is the file name

    //by default 
    //  your program will expect the physical to be in the same folder as the .exe file when you compile

    //you can use relative addressing to indicate a different location then the default
    //you can add several ../ folder increments to reposition the location to find your physical file

    string filePath = $"../../../{fileName}";

    //create an instance variable of the reader that will manager the File Input
    StreamReader reader = null;

    //use the File class to test if a file exists BEFORE trying to use
    if (File.Exists(filePath))
    {
        //read the file
        //as you read your file, if an error occurs you need to catch the error and handle it
        try
        {
            //setup your instance for the StreamReader
            reader = new StreamReader(filePath);

            //read the file record by record (loop)
            //when you reach the end of the file, the system will set a flag called EndOfStream
            //   this will indicate that you have reached the end of the file
            while(!reader.EndOfStream)
            {
                //read a record
                inputLine = reader.ReadLine();

                //next, we need to separate the values on the line into
                //  their appropriate arrays
                //to do this, we will use a string method call .Split('deliminator')
                //the deliminator can be any single character.
                //for a csv file (comma separate values) the deliminator is a comma ,
                //the Split() method will split the data on the line into separate values
                //  at the deliminator
                //the Split() method returns the values of the line to an string array
                string[] lineValues = inputLine.Split(',');

                //note: assuming that the data in the file is valid

                studentNames[countOfRecordsRead] = lineValues[0];
                studentMarks[countOfRecordsRead] = double.Parse(lineValues[1]);

                //increment count of records read
                countOfRecordsRead++;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Read Error: {ex.Message}");
        }
        finally
        {
            //this is an optionally piece of code that can be used on your try/catch
            //normally
            //  you will execute all of the try successfully, exit the try/catch
            //or
            //  an error will be generated and you will process the catch, exit the try/catch

            //the finally will be execute WHETHER you exited the try/catch successful or having
            //      an error

            //in this code, we will manually close the file that is being read
            if (reader != null) //try to close ONLY if you have a reader
            {
                reader.Close(); //manually close the file
            }
        }
    }
    else
    {
        Console.WriteLine($"\n\t Your file {fileName} does not exists. No records read.");
    }

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
    //logicalSize is a value type variable
    //when one passes a value type variable, the method get a copy of the value

    bool continueAdding = true;
    string inputValue = "";
    //check is there room to add another student?
    if (logicalSize < studentMarks.Length)
    {
        while(logicalSize < studentMarks.Length && continueAdding)
        {
            Console.Write("\nEnter student name:\t");
            inputValue = Console.ReadLine();

            // you would place any validation for your data here
            // for this example, we are assuming valid data

            studentNames[logicalSize] = inputValue;

            Console.Write("Enter student mark:\t");
            inputValue = Console.ReadLine();
            studentMarks[logicalSize] = double.Parse(inputValue);

            logicalSize++;

            Console.Write("Enter another student (Y or N):\t");
            inputValue = Console.ReadLine();
            if (inputValue.ToUpper().Equals("N"))
            {
                continueAdding = false;
            }
        }
    }
    else
    {
        Console.WriteLine("The class is full. Unable to add another student. ");
    }
    return logicalSize; //logicalSize is a value type variable
}

static void WriteNamesandMark(string[] studentNames, double[] studentMarks, int logicalSize, string fileName)
{
    //setup the StreamWriter instance
    StreamWriter writer = null;
    string outputLine = "";
    string filePath = $"../../../{fileName}";

    //anything can go wrong when writing
    //therefore, like other coding area, we will use a try/catch to handle any exception
    try
    {
        //create an instance of the actual StreamWriter
        
        //if your file DOES NOT exist, it will be created and opened
        //if your file DOES exist, it will be opened

        //depending on the write options, action against your will vary
        // a)to OVERWRITE all existing lines use the option-> false
        // b)to APPEND to the existing lines use the option-> true
        writer = new StreamWriter(filePath, false);

        //write to the file
        //my program will control the writing of the lines
        for(int i = 0; i < logicalSize; i++)
        {
            //building my file line
            outputLine = $"{studentNames[i]},{studentMarks[i]}";
            //write the line to the file
            writer.WriteLine(outputLine);
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"System Error: {ex.Message}");
    }
    finally
    {
        //close the opened file
        if (writer != null)
        {
            writer.Close();
        }
    }
}