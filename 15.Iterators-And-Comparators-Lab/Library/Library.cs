using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> libraryBooks;
        public Library(params Book[] books)
        {
            this.libraryBooks = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.libraryBooks);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                this.Reset();
            }

            public bool MoveNext()
            {
                this.currentIndex++;

                if (this.currentIndex == books.Count)
                {
                    return false;
                }

                return true;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }

            public Book Current
            {
                get
                {
                    return this.books[this.currentIndex];
                }
            }

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}
