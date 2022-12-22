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
            Options();
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

        public static void Options()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3 ,3);
            Console.WriteLine("--------------------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma op��o");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Abrir arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Editar arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - -Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Op��o: ");

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                case 1:
                    Editor.Show();
                    break;

                case 2:
                    Create();
                    break;

                default:
                    Console.WriteLine("Op��o inv�lida!");
                    Show();
                    break;
            }
        }

        public static void Open()
        {
            Console.WriteLine("Abrir");
        }

        public static void Create()
        {
            Console.WriteLine("Editar");
        }

        public static void Save()
        {
            Console.WriteLine("Editar");
        }
    }
}