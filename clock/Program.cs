using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Figgle;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry = true;
            do
            {
                Console.WriteLine("What template do you want : ");
                Console.WriteLine("1 : dd/MM/yyyy");
                Console.WriteLine("HH/mm/ss");
                Console.WriteLine("2 : HH/mm/ss");
                Console.WriteLine("3 : exit");
                Console.WriteLine(Figgle.FiggleFonts.Lcd.Render("By Milleville "));
                try
                {
                    int answer = int.Parse(Console.ReadLine());


                    if (answer == 1)
                    {
                        do
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            DateTime saveNow = DateTime.Now;
                            DateTime Test = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
                            Console.WriteLine(
                                Figgle.FiggleFonts.Starwars.Render(Test.ToString("dd/MM/yyyy")));
                            Console.WriteLine(Figgle.FiggleFonts.Starwars.Render(Test.ToString("HH:mm:ss")));
                        } while (true);
                    }
                    else if (answer == 2)
                    {
                        do
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            DateTime saveNow = DateTime.Now;
                            DateTime Test = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
                            Console.WriteLine(Figgle.FiggleFonts.Starwars.Render(Test.ToString("HH:mm:ss")));
                        } while (true);
                    }
                    else if (answer == 3)
                    {
                        Console.WriteLine("Have a good day !");
                        Console.WriteLine("Press any button to close...");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadKey(); }
            }while (retry == true);
            /*
            do
            {
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                DateTime saveNow = DateTime.Now;
                DateTime Test = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
                Console.WriteLine(
                    Figgle.FiggleFonts.Starwars.Render(Test.ToString("HH:mm:ss")));
            } while (true); */
        }
    }
}