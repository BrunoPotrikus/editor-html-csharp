using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear(); 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawHorizontal();
            DrawVertical();
            DrawHorizontal();
        }

        public static void DrawHorizontal()
        {
            Console.Write("+");
            for (int lines = 0; lines < 30; lines++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public static void DrawVertical()
        {
            for(int columns = 0; columns < 10; columns++)
            { 
                Console.Write("|");
                for (int lines = 0; lines < 30; lines++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}