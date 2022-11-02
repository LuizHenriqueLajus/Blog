using Blog2.Models;
using Blog2.Repositories;

namespace Blog2.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("New Tag");
            Console.WriteLine("-------------");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag successfully registered");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to save tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
