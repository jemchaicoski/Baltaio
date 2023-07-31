using System;
using System.Text;

public static class Editor
{
    public static void Show()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO DE EDIÇÃO");
        Console.WriteLine("--------------");
        Start();
    }
    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine);
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("\n");
        Console.WriteLine("DDeseja salvar o arquivo?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        var option = short.Parse(Console.ReadLine());
    }
}

