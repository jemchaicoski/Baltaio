using System;

namespace Stopwatch
{
    class Program {
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Escreva seu numero com marcador 'S' para contar em segundos");
            Console.WriteLine("Escreva seu numero com marcador 'M' para contar em minutos");
            Console.WriteLine("Ex: 10 segundos => 10s");
            Console.WriteLine("Ex: 10 minutos => 10m");
            Console.WriteLine("Pressione 'x' para sair");
            Console.WriteLine("Quanto você quer contar?");

            String data = Console.ReadLine().ToLower();
            char type;
            int time;
            int multiplier = 1;

            if(data.Length > 1){
                 type = char.Parse(data.Substring(data.Length -1, 1));
                 time = int.Parse(data.Substring(0, data.Length -1));
            } else {
                 type = char.Parse(data);
                 time = 0;
            }
            

            if(type == 'm'){
                multiplier = 60;
            }

            if(type == 'x') {
               endScreen();
            }

            preStart(time * multiplier);
        }
        static void start(int time){
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"{currentTime}/{time}");
                Thread.Sleep(1000);
            }
            Menu();
        }
        static void preStart(int time){
            Console.Clear();
            Console.WriteLine("Preparar");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("( ) ( ) ( )");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("(@) ( ) ( )");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("(@) (@) ( )");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("(@) (@) (@)");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Já!!!");
            Thread.Sleep(2000);
            
            start(time);
        }
        
        static void endScreen(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Obrigado por usar a aplicação");

            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░█████████░░░░░░░░░");
            Console.WriteLine("░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░░");
            Console.WriteLine("░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███░░░░");
            Console.WriteLine("░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░");
            Console.WriteLine("░░░░█▒▒▒▒▒█░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███░");
            Console.WriteLine("░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██");
            Console.WriteLine("░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
            Console.WriteLine("░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██");
            Console.WriteLine("██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██");
            Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██");
            Console.WriteLine("██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░");
            Console.WriteLine("░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░");
            Console.WriteLine("░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░");
            Console.WriteLine("░░████████████░░░█████████████████░░░░░░");
            Thread.Sleep(5000);
            Console.Clear();

            Console.ReadLine();
            System.Environment.Exit(0);
        }
    }
    
}