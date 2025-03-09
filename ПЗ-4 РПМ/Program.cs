using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_4_РПМ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Build> buildings = new List<Build>
        {
            new Build("ул. Ленина, 1", "Жилой", 5, 20, 60),
            new Build("ул. Пушкина, 5", "Офисный", 10, 50, 45),
            new Build("пр. Победы, 10", "Жилой", 9, 100, 80),
            new Build("ул. Садовая, 7", "Коммерческий", 3, 10, 30)
        };

            var oldBuildings = buildings.Where(b => b.YearsInUse > 50);

            Console.WriteLine("Здания со сроком эксплуатации более 50 лет:");
            foreach (var building in oldBuildings)
            {
             Console.WriteLine($"Адрес: {building.Address}, Тип: {building.Type}, Этажей: {building.Floors}, " +
                                  $"Квартир: {building.Apartments}, Срок эксплуатации: {building.YearsInUse} лет, " +
                                  $"Срок до капитального ремонта: {building.YearsToMajorRepair} лет");
            }
        }
    }
}
