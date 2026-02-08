using System.Collections;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> libraryBooks;

    public Library(params Book[] books)
    {
        this.libraryBooks = new SortedSet<Book>(books, new BookComparator());
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return this.libraryBooks.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}