using System;

namespace A_LvLMod2Less_1
{
    class ConsoleSqript
    {
        static void Main(string[] args)
        {
            ConsoleLogic();
        }

        private static void ConsoleLogic()
        {
            string name;
            int count;
            int tryNum;

            bool isMenu = true;

            while (isMenu)
            {
                Console.WriteLine("1 - new Person, 2 - Show all Persons, 3 - training ,4 - Exit");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Input Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Input Count");
                        while (!int.TryParse(Console.ReadLine(), out tryNum))
                        {
                            Console.WriteLine("Error format");
                        }
                        count = tryNum;

                        Gum.InToGum(name, count, SelectRoom());
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        if (Gum.persons.Count != 0)
                        {
                            foreach (var pr in Gum.persons)
                            {
                                Console.WriteLine(pr.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("gym empty");
                        }
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Gum.Training();
                        break;

                    case ConsoleKey.D4:
                        isMenu = false;
                        break;
                }
            }
        }

        private static string SelectRoom()
        {
            string str;
            Console.WriteLine("1 - foot room, 2 - chest room, 3 - back room");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    str = "foot room";
                    break;

                case ConsoleKey.D2:
                    str = "chest room";
                    break;

                case ConsoleKey.D3:
                    str = "back room";
                    break;
                default:
                    str = "warm-up room";
                    break;
            }
            Console.Clear();
            return str;
        }
    }
}
