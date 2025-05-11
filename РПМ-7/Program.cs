using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalRoutes = 10;
            int[] suitableRoutes = { 3, 7 }; // Пусть подходящие маршрутки — это 3 и 7
            int missedBuses = 0;

            while (true)
            {
                int incomingRoute = random.Next(1, totalRoutes + 1);
                Console.WriteLine($"Прибывает маршрутка №{incomingRoute}");

                if (Array.Exists(suitableRoutes, route => route == incomingRoute))
                {
                    Console.WriteLine("Подходящая маршрутка! Студент поехал на занятие.");
                    break;
                }
                else
                {
                    missedBuses++;
                    Console.WriteLine("Не подходит. Ждём следующую...");

                    if (missedBuses > 4 && missedBuses <= 5)
                    {
                        Console.WriteLine("Студент звонит другу: \"Я опаздываю на занятие!\"");
                    }
                    else if (missedBuses > 5)
                    {
                        Console.WriteLine("Студент устал ждать и пошёл домой.");
                        break;
                    }
                }

               
            }
        }
    }
}
