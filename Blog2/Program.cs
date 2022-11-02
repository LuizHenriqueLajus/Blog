using Blog2.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Blog2
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=192.168.25.17,433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;trustservercertificate=true;";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("        My Blog        ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("What you wanna do?");
            Console.WriteLine();
            Console.WriteLine("1) User management");
            Console.WriteLine("2) Bio management");
            Console.WriteLine("3) Category management");
            Console.WriteLine("4) Tag management");
            Console.WriteLine("5) Link profile/user");
            Console.WriteLine("6) Link post/tag");
            Console.WriteLine("7) Report");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}