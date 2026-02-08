public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public string Title
    {
        get; set;
    }
    public int Year
    {
        get; set;
    }
    public List<string> Authors
    {
        get; set;
    }

    public int CompareTo(Book other)
    {
        int result = this.Year.CompareTo(other.Year);
        if (result == 0)
        {
            result = this.Title.CompareTo(other.Title);
        }
        return result;
    }

    public override string ToString()
    {
        return $"{Title} - {Year}";
    }
}

public class BookComparator : IComparer<Book>
{
    public int Compare(Book first, Book second)
    {
        var titleComparison = first.Title.CompareTo(second.Title);

        if (titleComparison != 0)
        {
            return titleComparison;
        }

        return second.Year.CompareTo(first.Year);
    }
}