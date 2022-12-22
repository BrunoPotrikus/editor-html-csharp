using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------------");

            Replace(text);
            Console.WriteLine("-----------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(" ");

           for (int index = 0; index < words.Length; index++)
            {
                if (strong.IsMatch(words[index]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[index].Substring(
                            words[index].IndexOf('>') + 1,
                            (words[index].LastIndexOf('<') - 1) - words[index].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[index]);
                    Console.Write(" ");
                }
            }
        }
    }
}
