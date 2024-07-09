// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nTic Tac Toe Game\n");

/************************************ driver *****************************/

//multi-dimensional array
//2 or more values within a row on your array

//game board

//              *          *
//              *          *                        this area would be a row
//              *          *
//    **************************************
//              *          *
//              *          *                        this area would be a row
//              *          *
//    **************************************
//              *          *
//              *          *                        this area would be a row
//              *          *
//     column     column        column



//the array STILL must be of a single datatype
//the rows vs columns do not need to match
//syntax string[ , ] indicates a 2 dimensional array (2D-array)
//                   the comma indicates each additional dimension (3D [,,])
//in a 2D array, the first value is your rows, the second value is the columns
string[,] gameBoard = new string [5 , 5];

InitializeBoard(gameBoard);
DisplayGameBoard(gameBoard);

/************************************ methods ****************************/

static void InitializeBoard(string[,] gameBoard)
{
    //for each row
    for(int r = 0; r < 5; r++)
    {
        //for each column on the row
        for(int c = 0; c < 5; c++)
        {
            if (c == 1 || c == 3)
            {
                gameBoard[r, c] = "|";
            }
            else if (r == 1 || r == 3)
            {
                gameBoard[r, c] = "-".PadLeft(3,'-');
            }
            else
            {
                gameBoard[r, c] = "   ";
            }
        }
    }
}

static void DisplayGameBoard(string[,] gameBoard)
{
    for (int r = 0; r < 5; r++)
    {
        //for each column on the row
        for (int c = 0; c < 5; c++)
        {
            Console.Write(gameBoard[r, c]);
        }
        Console.WriteLine();
    }
}