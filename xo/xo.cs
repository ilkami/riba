using System;

class TicTacToe
{
    static char[,] board;
    static int moves;
    static char currentPlayer;
    static bool againstComputer;
    static Random random = new Random();

    static void Main()
    {
        while (true)
        {
            InitializeGame();

            while (true)
            {
                Console.Clear();
                DisplayBoard();

                if (againstComputer && currentPlayer == 'O')
                {
                    ComputerTurn();
                }
                else
                {
                    Console.Write($"Ход {currentPlayer}: введите номер клетки (1-9) > ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int cell) || cell < 1 || cell > 9)
                    {
                        Console.WriteLine("Нужно ввести число от 1 до 9!");
                        Console.ReadKey();
                        continue;
                    }

                    int row = (cell - 1) / 3;
                    int col = (cell - 1) % 3;

                    if (board[row, col] == 'X' || board[row, col] == 'O')
                    {
                        Console.WriteLine("Эта клетка уже занята!");
                        Console.ReadKey();
                        continue;
                    }

                    board[row, col] = currentPlayer;
                }

                moves++;

                if (CheckVictory())
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine($"{currentPlayer} победил! Поздравляем!");
                    break;
                }
                else if (moves == 9)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine("Ничья!");
                    break;
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }

            Console.WriteLine("Сыграем еще? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            if (answer != "yes") break;
        }

        Console.WriteLine("Игра окончена. Нажмите любую клавишу...");
        Console.ReadKey();
    }

    static void InitializeGame()
    {
        board = new char[3, 3]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        moves = 0;
        currentPlayer = 'X';

        Console.Clear();
        Console.WriteLine("Выберите режим игры:");
        Console.WriteLine("1 - Два игрока");
        Console.WriteLine("2 - Против компьютера");

        string choice = Console.ReadLine();
        againstComputer = choice == "2";
    }

    static void ComputerTurn()
    {
        Console.WriteLine("Компьютер делает ход...");
        int row, col;
        do
        {
            int move = random.Next(1, 10);
            row = (move - 1) / 3;
            col = (move - 1) % 3;
        } while (board[row, col] == 'X' || board[row, col] == 'O');

        board[row, col] = currentPlayer;
        System.Threading.Thread.Sleep(500);
    }

    static void DisplayBoard()
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                char cell = board[i, j];

                if (cell == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (cell == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write($" {cell} ");
                Console.ResetColor();

                if (j < 2)
                    Console.Write("|");
            }

            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("---+---+---");
        }
        Console.WriteLine();
    }

    static bool CheckVictory()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return true;
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i]) return true;
        }

        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;

        return false;
    }
}