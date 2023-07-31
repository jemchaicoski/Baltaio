
public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        handleMenuOption(option);
    }

    public static void DrawScreen()
    {
        var ScreenLimit = 30;
        var Lines = 10;

        DrawUpperPart(ScreenLimit);

        for (int i = 0; i <= Lines; i++)
        {
            Console.Write("|");

            for (int j = 0; j < ScreenLimit; j++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        DrawLowerPart(ScreenLimit);
        WriteOptions();
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("=========================");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma das opções:");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("=========================");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir arquivo");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("3 - Sair");
        Console.SetCursorPosition(3, 9);

    }

    public static void handleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 3: Console.WriteLine("Exit"); break;
            default: Show(); break;
        }
    }
    private static void DrawUpperPart(int ScreenLimit)
    {
        Console.Write("+");
        for (int i = 0; i < ScreenLimit; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write("\n");
    }
    private static void DrawLowerPart(int ScreenLimit)
    {
        for (int i = 0; i < ScreenLimit + 2; i++)
            Console.Write("^");
    }
}
