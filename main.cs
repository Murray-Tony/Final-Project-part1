using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
   
    Author auth1 = new Author("Bill", "Murray", Convert.ToDateTime("11/01/1991"), "123456789", "Email@email.com");
    auth1.DisplayInfo();
    Author auth2 = new Author("Steve", "Seagull", Convert.ToDateTime("10/05/1998"), "987654123", "kittykat@gmail.com");
    auth2.DisplayInfo();

    Book book1 = new Book("11111","Harry Potter and the Potter", "Bill Murray");
    Book book2 = new Book("654623", "A Nice Day", "Steve Seagull");
    Book book3 = new Book("37463465", "The Thing That Should Be", "Bill Murray");
    Book book4 = new Book("346373", "Dos Equis", "Steve Seagull", Convert.ToDateTime("11/02/1991"), "Books R Us Publishing");
    Book book5 = new Book("6546", "Stuff That Stuffs", "Bill Murray", Convert.ToDateTime("10/05/1987"), "We Publish Books");
    Book book6 = new Book("654321321", "Booky McBookers", "Steve Seagull", Convert.ToDateTime("01/04/2021"), "Books R Us Publishing");
    auth1.AddBook(book1);
    auth1.AddBook(book3);
    auth1.AddBook(book5);
    Console.WriteLine("Author 1's books:");
    auth1.DisplayBooks();
    auth2.AddBook(book2);
    auth2.AddBook(book4);
    auth2.AddBook(book6);
    Console.WriteLine("Author 2's books:");
    auth2.DisplayBooks();
    auth1.RemoveBook("11111");
    Console.WriteLine("Author 1's books after removal of book 1:");
    auth1.DisplayBooks();
    Patron p1 = new Patron("Steve", "Stevenson", "1234");
    Patron p2 = new Patron("Jim", "Jimson", "5678");
    Patron p3 = new Patron("Bill", "Billson", "9123");
    Patron p4 = new Patron("James", "Jameson", "4567");
    Patron p5 = new Patron("Janet", "Janetson", "8912");
    p1.AddToRentalCart(book1, Convert.ToDateTime("10/2/2021"));
    p1.RemoveFromRentalCart(book3);
    p1.Display();
    p2.Display();
    p3.Display();
    p4.Display();
    p5.Display();
  }
}