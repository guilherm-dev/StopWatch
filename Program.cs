using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace StopWatch
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Menu();
            }

            static void Menu()
            {
                Console.Clear();
                Console.WriteLine("S = seg -> 10s = 10 seconds");
                Console.WriteLine("M = min -> 1m = 1 minute");
                Console.WriteLine("0 = Exit");
                Console.WriteLine("How many minutes or seconds do you wanna count?");

                string data = Console.ReadLine().ToLower();
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                int multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                if (time == 0)
                    System.Environment.Exit(0);

                PreStart(time * multiplier);


                Console.ReadKey();
            }

            static void PreStart(int time)
            {
                Console.Clear();
                Console.WriteLine("Ready...");
                Thread.Sleep(1000);

                Console.WriteLine("Set...");
                Thread.Sleep(1000);

                Console.WriteLine("Go...");
                Thread.Sleep(1500);

                Start(time);
                Console.ReadKey();
            }
            static void Start(int time)
            {
                int currentTime = 0;

                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                    Console.ReadKey();
                }


                Console.Clear();
                Console.WriteLine("Stopwatch finished");
                Thread.Sleep(2500);
                Menu();

            }
        }
    }