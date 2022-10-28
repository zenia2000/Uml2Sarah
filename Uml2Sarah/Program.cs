// See https://aka.ms/new-console-template for more information
using Uml2Sarah;

PizzaLibrary pizzaLibrary = new PizzaLibrary();
CustomerLibrary customerLibrary = new CustomerLibrary();

Pizza pizza1 = new Pizza("Margerita", "Cheese", "1", 75.50);
Pizza pizza2 = new Pizza("Vesuvio", "Cheese, Ham", "2", 80.75);
Pizza pizza3 = new Pizza("Hawaii", "Cheese, Ham, Pineapple", "3", 90.00);

pizzaLibrary.AddPizza(pizza1);
pizzaLibrary.AddPizza(pizza2);
pizzaLibrary.AddPizza(pizza3);

Customer customer1 = new Customer("1111", "Lars Jensen", "00 00 00 00", "Nørre Alle 27");

customerLibrary.AddCustomer(customer1);

Menu menu = new Menu(pizzaLibrary,customerLibrary);

menu.Run();
Console.ReadLine();