using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        while (true)
        {
            Console.Clear();
            //use https://patorjk.com/software/taag/ for ur title if you want
            Console.WriteLine(@"
░██████████░██   ░██    ░██            
    ░██          ░██    ░██            
    ░██    ░██░████████ ░██  ░███████  
    ░██    ░██   ░██    ░██ ░██    ░██ 
    ░██    ░██   ░██    ░██ ░█████████ 
    ░██    ░██   ░██    ░██ ░██        
    ░██    ░██    ░████ ░██  ░███████  

By: baggZ

Options:
    1) Test
    2) Exit
");

            string choice = Ask("Select Option");

            switch (choice)
            {
                //i put brakets cuz i think it look cool 
                case "1":
                    {
                        string input = Ask("Input");

                        Console.WriteLine("\n" + input);

                        Pause();
                        break;
                    }

                case "2":
                    {
                        return;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Option");
                        Pause();
                        break;
                    }
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        static string Ask(string question)
        {
            Console.Write(question + ": ");
            return Console.ReadLine()!.Trim();
        }
    }
}
