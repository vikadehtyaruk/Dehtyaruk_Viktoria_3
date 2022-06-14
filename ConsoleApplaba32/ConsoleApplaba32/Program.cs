using ConsoleApplaba32;
namespace ConsoleApplaba32
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sweets romashka = new Sweets("romashka", 15, 3);
            Sweets chocolapka = new Sweets("chocolapka", 5,1);
            Sweets barbaryska = new Sweets("barbaryska", 6,5);
            List<Sweets> sweets = new List<Sweets>() { };
            GetPodarunok(romashka, chocolapka, barbaryska, sweets);
            GetWeight(sweets);
            FindBySugar(sweets);
            SortByWeight(sweets);
            Console.ReadKey();

            static void SortByWeight(List<Sweets> sweets)
            {
                var q = sweets.GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count);
                int i = 0;
                foreach (var x in q)
                {
                    Console.WriteLine("Цукерка: " + sweets[i].Name + " к-сть: " + x.Count);
                }
            }
            static void FindBySugar(List<Sweets> sweets)
            {
                Console.WriteLine("Введіть нижню межу");
                int down= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть верхню межу");
                int up= Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < sweets.Count; i++)
                {
                    Console.WriteLine($"{ sweets[i].Name } " + Enumerable.Range(down, up).Contains(sweets[i].Sugar));
                }
            }
            static void GetPodarunok(Sweets romashka, Sweets chocolapka, Sweets barbaryska, List<Sweets> sweets)
            {
                Console.WriteLine("Скільки цукерок бажаєте обрати в подарунок?");
                int count= Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Що бажаєте додати у подарунок?\n 1 - ромашка\n 2 - шоколапка\n 3 - барбариска\n 4 - якщо ви завершили вибір");
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            sweets.Add(romashka);
                            break;
                        case 2:
                            sweets.Add(chocolapka);
                            break;
                        case 3:
                            sweets.Add(barbaryska);
                            break;
                        case 4:
                            foreach (var sweet in sweets)
                                Console.WriteLine(sweet);
                            break;
                    }
                }
            }
            static void GetWeight(List<Sweets> sweets)
            {
                int sum = 0;

                for (int i = 0; i < sweets.Count; i++)
                {
                    sum += sweets[i].Weight;
                }
                Console.WriteLine("Вага подарунка:" + sum + "гр");
            }
        }
    }
}