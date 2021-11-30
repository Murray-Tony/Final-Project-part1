using System;
using System.Collections.Generic;
class Book
{

  public virtual string ISBN {get;set;}
  public virtual string Title {get;set;}
  public virtual string AuthorInfo {get;set;}
  public virtual DateTime PublishedOn{get;set;}
  public virtual string PublishedBy {get;set;}
  public List<Book> BookList = new List<Book> ();
  public void Add(Book book)
  {
    BookList.Add(book);
  }
  public Book():this("Unknown", "Unknown", "Unknown", DateTime.Today, "Unknown")
        {
        }
  public Book(string isbn):this(isbn, "Unknown", "Unknown", DateTime.Today, "Unknown")
        {
        }
  public Book(string isbn, string title):this(isbn, title,"Unknown", DateTime.Today, "Unknown")
        {
        }
  public Book(string isbn, string title, string authorinfo):this(isbn, title, authorinfo, DateTime.Today, "Unknown")
        {
        }
  public Book(string isbn, string title, string authorinfo, DateTime publishedon, string publishedby)
        {
            ISBN = isbn;
            Title = title;
            AuthorInfo = authorinfo;
            PublishedOn=publishedon;
            PublishedBy=publishedby;
        }
  public virtual void Display()
  {
    Console.WriteLine("The book '"+ Title+"' was written by "+AuthorInfo+" and published on "+PublishedOn);
  }
}
