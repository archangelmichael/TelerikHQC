using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mini4ki
{
    public class Mines
    {
        public class Player
        {
            string name;
            int points;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Points
            {
                get { return points; }
                set { points = value; }
            }

            public Player() { }

            public Player(string playerName, int playerPoints)
            {
                this.name = playerName;
                this.points = playerPoints;
            }
        }

        static void Main(string[] args)
        {
            const int TOTAL_NUMBER_CELLS_COUNT = 35;

            string command = string.Empty;
            char[,] field = CreatePlayField();
            char[,] mines = PlaceMines();

            int scoreCounter = 0;
            List<Player> bestPlayers = new List<Player>(6);

            int rowStart = 0;
            int colStart = 0;

            bool hasHitMine = false;
            bool isNewGame = true;
            bool isGameWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play 'Mines'. Test your luck trying to find all empty fields." +
                    " Command 'top' shows highscores, 'restart' starts a new game, 'exit' exits the game and bye, bye!");
                    DrawPlayField(field);
                    isNewGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out rowStart) &&
                        int.TryParse(command[2].ToString(), out colStart) &&
                        rowStart <= field.GetLength(0) && colStart <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowHighScores(bestPlayers);
                        break;
                    case "restart": // Command should be newgame, cause it generates a new field
                        field = CreatePlayField(); // Can be deleted so the field is the same, but restarted
                        mines = PlaceMines(); 
                        DrawPlayField(field);
                        hasHitMine = false;
                        isNewGame = true; // Changed it to true, cause the field is not the same == (it's a new game)
                        scoreCounter = 0; // Added by me, cause score should be reseted after a restart
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[rowStart, colStart] != '*')
                        {
                            if (mines[rowStart, colStart] == '-')
                            {
                                GenerateMinesCountAtPosition(field, mines, rowStart, colStart);
                                scoreCounter++;
                            }
                            if (TOTAL_NUMBER_CELLS_COUNT == scoreCounter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                DrawPlayField(field);
                            }
                        }
                        else
                        {
                            hasHitMine = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (hasHitMine)
                {
                    DrawPlayField(mines);
                    Console.Write("\nHrrrrrr! You died an honourable death with {0} points. " + 
                        "Enter your name: ", scoreCounter);
                    string playerNickName = Console.ReadLine();
                    Player currentPlayer = new Player(playerNickName, scoreCounter);
                    if (bestPlayers.Count < 5)
                    {
                        bestPlayers.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < bestPlayers.Count; i++)
                        {
                            if (bestPlayers[i].Points < currentPlayer.Points)
                            {
                                bestPlayers.Insert(i, currentPlayer);
                                bestPlayers.RemoveAt(bestPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    bestPlayers.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    bestPlayers.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    ShowHighScores(bestPlayers);

                    field = CreatePlayField();
                    mines = PlaceMines();
                    scoreCounter = 0;
                    hasHitMine = false;
                    isNewGame = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nCongratulations! Opened 35 cells without a single drop of blood.");
                    DrawPlayField(mines);
                    Console.WriteLine("Enter your name, champ: ");
                    string playerNickName = Console.ReadLine();
                    Player winner = new Player(playerNickName, scoreCounter);
                    bestPlayers.Add(winner);
                    ShowHighScores(bestPlayers);
                    field = CreatePlayField();
                    mines = PlaceMines();
                    scoreCounter = 0;
                    isGameWon = false;
                    isNewGame = true;
                }
            } while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("Adios Amigo.");
            Console.Read();
        }

        private static void DrawPlayField(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rowsCount = 5;
            int colsCount = 10;
            char[,] board = new char[rowsCount, colsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> randomPositions = new List<int>();
            while (randomPositions.Count < 15)
            {
                Random randomNumbersGenerator = new Random();
                int generatedNumber = randomNumbersGenerator.Next(50);
                if (!randomPositions.Contains(generatedNumber))
                {
                    randomPositions.Add(generatedNumber);
                }
            }

            foreach (int position in randomPositions)
            {
                int mineCol = (position / colsCount);
                int mineRow = (position % colsCount);
                if (mineRow == 0 && position != 0)
                {
                    mineCol--;
                    mineRow = colsCount;
                }
                else
                {
                    mineRow++;
                }
                board[mineCol, mineRow - 1] = '*';
            }

            return board;
        }

        private static void ShowHighScores(List<Player> bestPlayers)
        {
            Console.WriteLine("\nTo4KI:");
            if (bestPlayers.Count > 0)
            {
                for (int i = 0; i < bestPlayers.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, bestPlayers[i].Name, bestPlayers[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void GenerateMinesCountAtPosition(char[,] board, char[,] mineField, int currentRow, int currentCol)
        {
            char minesCount = CalculateNearbyMinesAtPosition(mineField, currentRow, currentCol);
            mineField[currentRow, currentCol] = minesCount;
            board[currentRow, currentCol] = minesCount;
        }

        private static void GenerateEmptyCellsNearbyMinesCounts(char[,] board) // THIS METHOD IS NOT USED, SO IT CAN BE DELETED
        {
            int rowsCount = board.GetLength(0);
            int colsCount = board.GetLength(1);

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char numberOfNearbyMines = CalculateNearbyMinesAtPosition(board, i, j);
                        board[i, j] = numberOfNearbyMines;
                    }
                }
            }
        }

        private static char CalculateNearbyMinesAtPosition(char[,] board, int currentRow, int currentCol)
        {
            int nearbyMinesCount = 0;
            int rowsCount = board.GetLength(0);
            int colsCount = board.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (board[currentRow - 1, currentCol] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if (currentRow + 1 < rowsCount)
            {
                if (board[currentRow + 1, currentCol] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if (currentCol - 1 >= 0)
            {
                if (board[currentRow, currentCol - 1] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if (currentCol + 1 < colsCount)
            {
                if (board[currentRow, currentCol + 1] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (board[currentRow - 1, currentCol - 1] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol + 1 < colsCount))
            {
                if (board[currentRow - 1, currentCol + 1] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if ((currentRow + 1 < rowsCount) && (currentCol - 1 >= 0))
            {
                if (board[currentRow + 1, currentCol - 1] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            if ((currentRow + 1 < rowsCount) && (currentCol + 1 < colsCount))
            {
                if (board[currentRow + 1, currentCol + 1] == '*')
                {
                    nearbyMinesCount++;
                }
            }
            return char.Parse(nearbyMinesCount.ToString());
        }
    }
}
