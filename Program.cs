using System;
using System.Threading;

namespace Timer 
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.Write("Digite o tempo de duração: ");
            string? data = Console.ReadLine().ToLower();
            if (data == "0") { Environment.Exit(0); }

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int timeUser = int.Parse(data.Substring(0, data.Length - 1));
            
            PreStart();
            Start(timeUser, type);
        }

        static void PreStart(){
            Console.Clear();
            Console.WriteLine("Ready.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Ready..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Ready....");

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Goooo!");
            Thread.Sleep(1500);
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("----------StopWatch----------");
            Console.WriteLine();
            Console.WriteLine("Segundos = 10s");
            Console.WriteLine("Minutos = 1m");
            Console.WriteLine();
        }

        static void Start(int time, char type)
        {
            int currentTime = 0;
            if(type == 'm'){ time *= 60; }

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"Contando : {currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Temporizador finalizado");

            Thread.Sleep(2000);
        }
    }
}                                                                                           