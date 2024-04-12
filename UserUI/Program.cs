using UserBusinessLayer;
using UserModel;
using UserDataLayer;

namespace UserUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username:  ");
            string userID = Console.ReadLine();

            Console.Write("Enter Password:  ");
            string pass = Console.ReadLine();

            Business veri = new Business();
            bool result = veri.Verification(userID, pass);

            if (result)
            {
                Console.WriteLine("Welcome to the Bus");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
