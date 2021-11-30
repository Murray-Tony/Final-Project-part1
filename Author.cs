
using System;
using System.Collections.Generic;
class Author : Person
{
  private List<Book> BookList = new List<Book>();


 public Author() : base()
        {
        }
  public Author(string fname, string lname) : base(fname,  lname) 
  {
  }
  public Author(string fname, string lname, DateTime birthday):base(fname,lname,birthday)
  {}
  public Author(string fname, string lname, DateTime birthday, string social):base(fname,lname,birthday,social)
  {}
  public Author (string fname, string lname, DateTime birthday, string social, string email):base(fname,lname,birthday,social,email)
  {}
  public Author(string fname, string lname, DateTime birthday, string social, string email, string phonenumber):base(fname, lname, birthday, social, email, phonenumber)
  {}
  public void DisplayInfo(){
    base.Intro();
    Console.WriteLine(Email);
  }
  public void DisplayBooks() {
    foreach (var book in BookList) {
      book.Display();
    }}
  public void AddBook(Book b)
  {
    BookList.Add(b);
    this.FirstName = FirstName;
    this.LastName = LastName;
  }
  public void RemoveBook(string ISBN)
  {
    BookList.Remove(BookList.Find(Book => Book.ISBN == ISBN));
  }
  

}