using System;
using System.Collections.Generic;

namespace Labb_2_del_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customercrate = new Program();
           
            customercrate.LoggaIn();
            var products = new List<Products>();//detta är produkterna som finns
            var customers = new List<Customers>();//kunder som finns registerade
            var customersProducts = new List<Products>();//detta är kundvagnen
        }



        public void RegisterCustomer()
        {
            Console.WriteLine("Please enter a username and password");
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            //om anvödanren matar in valfri texti skall dem kunna logga in och då anropas run metoden
            if (name == "" && password == "")
            {
                var customers = new List<Customers>();//detta är kundvagnen
                customers.Add(new Customers(name,password));

            }

        }

        public void LoggaIn()
        {
            Console.WriteLine("Please enter your username");
            string Username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string Password = Console.ReadLine();

            var customers = new List<Customers>();//detta är kundvagnen
            
            //vilkor för att accepterar dem tre olika inloggningarna som okey,då ska dem anropa run metoden
            if (Username == "Knatte" && Password == "123")
            {
                customers.Add(new Customers("Knatte", "123"));
            }
            else if (Username == "Fnatte" && Password == "321")
            {

                customers.Add(new Customers("Fnatte", "321"));
            }
            else if (Username == "Tjatte" && Password == "213")
            {
                customers.Add(new Customers("Tjatte", "213"));
            }
        }
        //metod för att e användaren möjlighet att logga ut och in,welcome message metoden nropas 

        public void Add_Product()

        {
            int choice = 0;
            choice = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Please choose one of the following products");
                Console.WriteLine("1.Apple", 15);
                Console.WriteLine("2.Banana", 25);
                Console.WriteLine("3.Egg", 30);
                var customersProducts = new List<Products>();//detta är kundvagnen
                
               
                


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("An Apple has been added");
                        customersProducts.Add(new Products("Apple", 15));
                        break;
                    case 2:
                        Console.WriteLine("A banana has been added");
                        customersProducts.Add(new Products("Banana", 25));
                        break;
                    case 3:
                        Console.WriteLine("An Egg has been added");
                        customersProducts.Add(new Products("Egg", 30));
                        break;


                    default:
                        Console.WriteLine("Sorry invalid choice please choice another product");
                        break;
                }

            } while (choice != 0);

        }
        public void Calc_total()
        {




        }
        public void PrintCustomerCrate()
        {






        }




        public void LogOut()

        {


            Menu1();


        }
        public void Menu1()
        {


            Console.WriteLine("Hello and welcome");
            Console.WriteLine("Please choose one fo the following choices");
            Console.WriteLine("1.Log In");//skapa en metod för att logga in 
            Console.WriteLine("2.Register as a new customer");// skapa en etod för att registrera en ny kund
            Console.WriteLine("3.Log Out");


            int choice = 0;
            choice = int.Parse(Console.ReadLine());

            //om användaren väljer att logga in ska logga in metoden anropas 
            if (choice == 1)
            {


                LoggaIn();

                //om användaren väljer att registrera en ny kund ska registrerustomer metoden anropas 
            }
            else if (choice == 2)
            {


                RegisterCustomer();

            }
            else if (choice == 3)
            {


                LogOut();

            }
        }



        public void Menu2()

        {
            int choice = 0;
            choice = int.Parse(Console.ReadLine());


            do

            {
                Console.WriteLine(" 1: Add a product");
                Console.WriteLine(" 2: Total price");
                Console.WriteLine(" 3: Print your crate ");
                Console.WriteLine(" 4: Log out");
                Console.WriteLine(" 5: Terminate the program");





                switch (choice)
                {
                    //Lägger till en produkt
                    case 1:
                        Add_Product();
                        break;
                    //visar totla kostnaden av kundvagnen
                    case 2:
                        Calc_total();
                        break;
                    case 3:
                        //skriver ut inehållet av kundvagnen
                        PrintCustomerCrate();
                        break;
                    case 4:
                        //ger användaren en möjlighet att logga ut och anropar welcome messaeg meoden
                        LogOut();
                        break;
                    case 5:
                        //terminerar programmet
                        Console.WriteLine("Program terminated");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry this choice is not available");
                        break;
                }
            } while (choice != 0);




        }


    }
}

