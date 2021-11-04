using System;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            User user = new User(username,password);

            user.ShowInfo();

        }
    }
}
