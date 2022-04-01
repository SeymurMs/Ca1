using System;

namespace Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsExit = true;
            User user = new User();
            do
            {
                Console.WriteLine("Home");
                Console.WriteLine("1. Share status");
                Console.WriteLine("2.Get status by title");
                Console.WriteLine("3. quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Title Daxil edin:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Content Daxil edin:");
                        string content = Console.ReadLine();
                        Status status = new Status(title, content);
                        user.ShareStatus(status);

                        break;
                    case "2":
                        string titleStr = Console.ReadLine();
                        Console.WriteLine(user.GetStatusByTitle(titleStr));
                        break;
                    case "3":
                        IsExit = false;
                        break;
                    default:
                        Console.WriteLine("Bele emeliyyat yoxdur");
                        break;
                }

            } while (IsExit);
        }
    }
}
