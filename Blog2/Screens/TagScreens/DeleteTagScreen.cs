using Blog2.Models;
using Blog2.Repositories;

namespace Blog2.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Delete");
            Console.WriteLine("-------------");
            Console.Write("Insert Id to delete: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag successfully deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete tag");
                Console.WriteLine(ex.Message);
            }
        }

    }
}
