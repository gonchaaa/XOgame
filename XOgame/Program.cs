using System.Reflection.Emit;

string[,] gameBoard =
{
    {"_","_","_" },
    {"_","_","_" },
    {"_","_","_" }
};



bool player = true;
Before:

Console.Write("Enter x:");
int coordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y:");
int coordinateY = Convert.ToInt32(Console.ReadLine());


if (CheckCoor(gameBoard,coordinateX,coordinateY))
{
    Console.WriteLine("Coordinate is exist");
    goto Before;
}

string playerName= player ? "x" : "o";

gameBoard[coordinateX, coordinateY] = playerName;



for (int i = 0; i < gameBoard.GetLength(0); i++)
{
    for (int j = 0; j < gameBoard.GetLength(1); j++)
    {
        Console.Write($"{gameBoard[i, j]}");
    }
    Console.WriteLine("\n");
}


if (CheckWin(gameBoard,playerName))
{
    Console.WriteLine($"{playerName} win");

}
else
{

player = !player;
goto Before;
}
bool CheckCoor(string[,] board,int x,int y)
{
    if (board[x,y].Contains("_"))
    {
        return false;
    }
    return true;
}


bool CheckWin(string[,] board,string player)
{
    if (board[0,0]==player && board[0, 1] == player && board[0, 2] == player)
    {
        return true;
    }
    else if(board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
    {
        return true;
    }
    else if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
    {
        return true;
    }
    else if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
    {
        return true;
    }
    else if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
    {
        return true;
    }
    else if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
    {
        return true;
    }
    else if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
    {
        return true;
    }
    else if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
    {
        return true;
    }
    return false;
}