using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//meny setup

namespace Uml2Sarah
{
    public class Menu
    {
        private PizzaLibrary _pizzaLibrary;
        private CustomerLibrary _customerLibrary;

        public Menu (PizzaLibrary pizzaLibrary, CustomerLibrary customerLibrary)
        {
            _pizzaLibrary = pizzaLibrary;
            _customerLibrary = customerLibrary;
        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\tWelcome to Mama's pizza");
            Console.WriteLine("\t-----------------------");
            Console.WriteLine("\t1. Show menu");
            Console.WriteLine("\t2. Add Pizza to menu");
            Console.WriteLine("\t3. Edit Pizza from menu");
            Console.WriteLine("\t4. Detele Pizza from menu");
            Console.WriteLine("\t5. Payment");
            Console.WriteLine("\t-----------------------");
            Console.WriteLine("\t6. Add Customer Profile");
            Console.WriteLine("\t7. Edit Customer Profile");
            Console.WriteLine("\t8. Delete Customer Profile");
            Console.WriteLine("\t9. Show All Customer Profiles");
            Console.WriteLine("\t-----------------------");
            Console.WriteLine("\t0. Exit");
            Console.WriteLine("\t-----------------------");
            Console.Write("\tType a number to access the feature: ");  
            return ReadUserChoice();
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\tMenu");
                        Console.WriteLine();
                        _pizzaLibrary.PrintPizza();
                        Console.WriteLine();
                        Console.WriteLine("\tPress Enter to return to titlescreen");
                        break;

                    case 2:
                        Console.Clear();
                        AddPizza();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\tEdit a Pizza");
                        EditPizza();
                        break ;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\tDelete a Pizza");
                        DeletePizza();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Payment");//I Don't know, why I added this...
                        Console.WriteLine("To be added at a later date");
                        Console.WriteLine("Press Enter to continue");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Create a customer profile");
                        CreateCustomer();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Edit a Profile");
                        EditCustomer();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Delete a Profile");
                        DeleteCustomer();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Show all profiles");
                        Console.WriteLine("\tCustomers");
                        Console.WriteLine();
                        _customerLibrary.PrintCustomer();
                        Console.WriteLine();

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Unreadable input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();
            }
        }


        private void AddPizza()
        {
            {
                Console.Write("\tType the number of the new pizza: ");
                string pizzaNoOld = Console.ReadLine();
                Pizza pizza = _pizzaLibrary.LookupPizza(pizzaNoOld);
                if (pizza == null)
                {
                    Console.Write("\tType pizza name: ");
                    string pizzaName = Console.ReadLine();
                    Console.Write("\tType pizza toppings. separate with ,: ");
                    string pizzaTopping = Console.ReadLine();
                    Console.Write("\tType pizza price. Like - 80.00: ");
                    double pizzaPrice = double.Parse(Console.ReadLine());
                    Pizza pizzaNew = new Pizza(pizzaName, pizzaTopping, pizzaNoOld, pizzaPrice);
                    _pizzaLibrary.AddPizza(pizzaNew);
                    Console.WriteLine();
                    Console.WriteLine("\tThe pizza has been added");
                }
                else
                {
                    Console.WriteLine("\tpizza already exist");
                }
            }
        }


            private void DeletePizza()
        {
            Console.WriteLine("\tType the number of the pizza you want to delete");
            Console.Write("\tPizza number: ");
            string pizzaNo = Console.ReadLine();
            Pizza pizza = _pizzaLibrary.LookupPizza(pizzaNo);
                if (pizza != null)
                {
                _pizzaLibrary.DeletePizza(pizzaNo);
                Console.WriteLine();
                Console.WriteLine("\tThe pizza has been deleted");
                }
                else
                {
                Console.WriteLine();
                Console.WriteLine("\tPizza not found");
                } 
        }
        
        private void EditPizza()
        {
            Console.Write("\tType the number of the pizza you want to edit: ");
            string pizzaNoOld = Console.ReadLine();
            Pizza pizza = _pizzaLibrary.LookupPizza(pizzaNoOld);
            if (pizza == null)
            {
                Console.WriteLine("\tpizza doesn't exist");
            }
            else
            {
                Console.Write("\tType pizza name: ");
                string pizzaName = Console.ReadLine();
                Console.Write("\tType pizza number: ");
                string pizzaNo = Console.ReadLine();
                Console.Write("\tType pizza toppings. separate with ,: ");
                string pizzaTopping = Console.ReadLine();
                Console.Write("\tType pizza price. Like - 80.00: ");
                double pizzaPrice = double.Parse (Console.ReadLine());
                Pizza editedPizza = new Pizza(pizzaName, pizzaTopping, pizzaNo, pizzaPrice);
                _pizzaLibrary.EditPizza(pizzaNoOld, editedPizza);
                Console.WriteLine();
                Console.WriteLine("\tThe pizza has been edited");
            }
        }
        private void CreateCustomer()
        {
            Console.WriteLine("\tAdd a Customer");
            Console.Write("\tType customer Id: ");
            string customerId = Console.ReadLine();
            Console.Write("\tType name of customer: ");
            string customerName = Console.ReadLine();
            Console.Write("\tType the phone number of the customer: ");
            string customerPhone = Console.ReadLine();
            Console.Write("\tType the address of the customer: ");
            string customerAdress = Console.ReadLine();
            Customer c = new Customer(customerId,customerName,customerPhone,customerAdress);
            _customerLibrary.AddCustomer(c);
            Console.WriteLine();
            Console.WriteLine("\tYour new customer has been added");
        }

        private void EditCustomer()
        {
            Console.Write("\tType the Id of the customer you want to edit: ");
            string customerIdOld = Console.ReadLine();
            Customer customer = _customerLibrary.LookupCustomer(customerIdOld);
            if (customer == null)
            {
                Console.WriteLine("\tcustomer doesn't exist");
            }
            else
            {
                Console.Write("\tType customer Id: ");
                string customerId = Console.ReadLine();
                Console.Write("\tType name of customer: ");
                string customerName = Console.ReadLine();
                Console.Write("\tType the phone number of the customer: ");
                string customerPhone = Console.ReadLine();
                Console.Write("\tType the address of the customer: ");
                string customerAdress = Console.ReadLine();
                Customer c = new Customer(customerId, customerName, customerPhone, customerAdress);
                _customerLibrary.UpdateCustomer(customerId, customer);
                Console.WriteLine();
                Console.WriteLine("\tThe customer has been edited");
            }

        }
        private void DeleteCustomer()
        {
            Console.WriteLine("\tType the id of the customer you want to delete");
            Console.Write("\tCustomer Id: ");
            string customerId = Console.ReadLine();
            Customer aCustomer = _customerLibrary.LookupCustomer(customerId);
            if (aCustomer != null)
            {
                _customerLibrary.DeleteCustomer(customerId);
                Console.WriteLine();
                Console.WriteLine("\tThe customer has been deleted");
            }
            else
            Console.WriteLine("\tCustomer not found");
        }

    }
}
