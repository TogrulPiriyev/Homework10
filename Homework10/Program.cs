using System;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                string username = Console.ReadLine();
                string password = Console.ReadLine();
                User user = new User(username, password);
                user.ShowInfo();

            }
            catch (PasswordIncorrectException e)
            {


                Console.WriteLine(e.Message);
            }
            catch(InvalidUserNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Bilinmeyen bir xeta!!"); 
            }
            

        }
    }
}
