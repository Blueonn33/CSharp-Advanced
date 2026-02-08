namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstBook = new Book("Final Fantasy", 2015, "Ivaylo Kenov", "Square Enix");
            var secondBook = new Book("Nier Automata", 2018, "Square Enix");
            var thirdBook = new Book("Game of Thrones", 2015, "George Martin");

            var fullLibrary = new Library(firstBook, secondBook, thirdBook);

            foreach (var book in fullLibrary)
            {
                Console.WriteLine(book);
            }
        }
    }
}
