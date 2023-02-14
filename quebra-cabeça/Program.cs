using System;

namespace QuebraCabeça
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo de quebra-cabeças!");
            Console.WriteLine("Você tem que mover as peças até formar a imagem correta.");
            Console.WriteLine("Digite 'up', 'down', 'left' ou 'right' para mover as peças.");
            Console.WriteLine("Digite 'exit' para sair do jogo.");
            Console.WriteLine();

            int[,] puzzle = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 0 }
            };

            int emptyRow = 2;
            int emptyCol = 2;

            while (true)
            {
                DrawPuzzle(puzzle);

                Console.WriteLine();
                Console.Write("Mova: ");
                string move = Console.ReadLine();

                if (move == "exit")
                {
                    break;
                }

                if (move == "up")
                {
                    if (emptyRow > 0)
                    {
                        puzzle[emptyRow, emptyCol] = puzzle[emptyRow - 1, emptyCol];
                        puzzle[emptyRow - 1, emptyCol] = 0;
                        emptyRow--;
                    }
                }
                else if (move == "down")
                {
                    if (emptyRow < puzzle.GetLength(0) - 1)
                    {
                        puzzle[emptyRow, emptyCol] = puzzle[emptyRow + 1, emptyCol];
                        puzzle[emptyRow + 1, emptyCol] = 0;
                        emptyRow++;
                    }
                }
                else if (move == "left")
                {
                    if (emptyCol > 0)
                    {
                        puzzle[emptyRow, emptyCol] = puzzle[emptyRow, emptyCol - 1];
                        puzzle[emptyRow, emptyCol - 1] = 0;
                        emptyCol--;
                    }
                }
                else if (move == "right")
                {
                    if (emptyCol < puzzle.GetLength(1) - 1)
                    {
                        puzzle[emptyRow, emptyCol] = puzzle[emptyRow, emptyCol + 1];
                        puzzle[emptyRow, emptyCol + 1] = 0;
                        emptyCol++;
                    }
                }
            }
        }

        static void DrawPuzzle(int[,] puzzle)
        {
            for (int row = 0; row < puzzle.GetLength(0); row++)
            {
                for (int col = 0; col < puzzle.GetLength(1); col++)
                {
                    Console.Write("|");

                    if (puzzle[row, col] == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" " + puzzle[row, col] + " ");
                    }
                }

                Console.WriteLine("|");
            }
             }
        }
    }
}