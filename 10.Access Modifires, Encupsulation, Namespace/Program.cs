//using System;
//namespace AccessModifiersExample
//{
//    class Person
//    {
//        public string Name;              // hər yerdən görünür
//        private int age;                 // yalnız bu class daxilində
//        protected string NationalID;     // bu class və onun miras alan siniflərdə
//        internal string City;            // yalnız eyni project daxilində
//        protected internal string Phone; // eyni project və miras alan siniflərdə

//        public void SetAge(int a)
//        {
//            age = a; // private sahəyə daxil olur
//        }

//        public int GetAge()
//        {
//            return age;
//        }
//    }

//    class Student : Person
//    {
//        public void ShowNationalID()
//        {
//            Console.WriteLine("National ID: " + NationalID); // protected sahəyə giriş
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Person p = new Person();
//            p.Name = "Roya";
//            p.City = "Goranboy";
//            p.Phone = "0501234567";

//            p.SetAge(19); // private sahəyə public method ilə daxil oluruq
//            Console.WriteLine("Age: " + p.GetAge());
//        }
//    }
//}






//using System;

//namespace EncapsulationExample
//{
//    class BankAccount
//    {
//        private double balance; // balans gizlidir

//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//                balance += amount;
//        }

//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= balance)
//                balance -= amount;
//        }

//        public double GetBalance()
//        {
//            return balance;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            BankAccount acc = new BankAccount();
//            acc.Deposit(1000);
//            acc.Withdraw(200);
//            Console.WriteLine("Current balance: " + acc.GetBalance());
//        }
//    }
//}





//using System;

//// Namespace 1
//namespace MyApp.Models
//{
//    class User
//    {
//        public string Name { get; set; }
//    }
//}

//// Namespace 2
//namespace MyApp.Services
//{
//    class UserService
//    {
//        public void PrintUserName(MyApp.Models.User user)
//        {
//            Console.WriteLine("User Name: " + user.Name);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var user = new MyApp.Models.User { Name = "Aysel" };
//        var service = new MyApp.Services.UserService();
//        service.PrintUserName(user);
//    }
//}
