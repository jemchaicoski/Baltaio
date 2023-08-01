using System;
using System.Text.RegularExpressions;

public class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MMODO DE VISUALIZAÇÃO");
        Console.WriteLine("--------------");
        Replace(text);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\n");
        Console.WriteLine("--------------");
        Console.ReadKey();
        Menu.Show();
    }
    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {

            if (strong.IsMatch(words[i]))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
               Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );

                Console.Write(" ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(words[i]);
                Console.Write(" ");
            }
        }
    }
}