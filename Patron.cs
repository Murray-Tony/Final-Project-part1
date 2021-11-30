using System;
using System.Collections.Generic;


class Patron : Person
{
 public string LibraryId { get; set; }
 public DateTime StartDate { get; set; }
 public DateTime EndDate { get; set; }
 public bool IsAccountActive { get; set; }
 public List<Book> RentalCart = new List<Book>();
 public double FineAmountDue { get; set; }

  public Patron(string FirstName, string LastName, string LibraryId)
  {
  this.FirstName = FirstName;
  this.LastName = LastName;
  this.LibraryId = LibraryId;
  this.FineAmountDue = 0;
  this.StartDate = DateTime.Today;
  this.IsAccountActive = true;
  }

  public void Display()
  {
  Console.WriteLine("Patron ID=" + LibraryId + " Name= " + FirstName + " " + LastName);
  }

  public void AddToRentalCart(Book b, DateTime DateDue)
  {
  RentalCart.Add(b);
  Book b1 = b;
  Console.WriteLine("Added to rental cart " + b1.Title + " for Patron " + FirstName + " " + LastName);
  }
  
  public void RemoveFromRentalCart(Book b)
  {
    RentalCart.Remove(b);
    Book b1 = b;
    Console.WriteLine("Removed from rental cart" + b1.Title + " for Patron " + FirstName + " " + LastName);
  }

}