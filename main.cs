using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Book book1 = new Book("3974", "The littlest derp", "Tony Murray", Convert.ToDateTime("11/03/1991"), "Publishinghouse");
    book1.Display();
    Author auth1 = new Author("Bill", "Murray", Convert.ToDateTime("11/01/1991"), "123456789", "Email@email.com");
    auth1.DisplayInfo();
  }
}