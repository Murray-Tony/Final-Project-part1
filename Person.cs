  using System;
  
  class Person
  {
        //Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public Address PermanentAddress;

        public Person() : this("Unknown", "Unknown", DateTime.Today, "Unknown", "Unknown", "Unknown")
        {
        }
        public Person(string fname) : this(fname, "Unknown", DateTime.Today, "Unknown", "Unknown", "Unknown")
        {
        }
        public Person(string fname, string lname) : this(fname, lname, DateTime.Today, "Unknown", "Unknown", "Unknown")
        {
        }
        public Person(string fname, string lname, DateTime birthday) : this(fname, lname, birthday, "Unknown", "Unknown", "Unknown")
        {
        }
        public Person(string fname, string lname, DateTime birthday, string social) : this(fname, lname, birthday, social, "Unknown", "Unknown")
        {
        }
        public Person(string fname, string lname, DateTime birthday, string social, string email) : this(fname, lname, birthday, social, email, "Unknown")
        {
        }
        public Person(string fname, string lname, DateTime birthday, string social, string email, string phonenumber) 
        {
          FirstName = fname;
          LastName = lname;
          DateOfBirth = birthday;
          SocialSecurity = social;
          Email = email;
          PhoneNumber = phonenumber;
          PermanentAddress = new Address();
          Console.WriteLine("Person constructor");
        }

        public virtual void Intro()
        {
            Console.WriteLine("Hello my name is "+ FirstName +" "+ LastName);
        }

        public void IsBirthday()
        {
          if ((DateTime.Today.Month == DateOfBirth.Month)&&(DateTime.Today.Day == DateOfBirth.Day))
            Console.WriteLine("It's your birthday!!!");
          else
            Console.WriteLine("Today is not your birthday.");
        }

      
    }