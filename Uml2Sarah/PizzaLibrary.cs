using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Info on all pizzas

namespace Uml2Sarah
{
    public class PizzaLibrary
    {

        private List<Pizza> _pizzaList;
        public PizzaLibrary()
        {
            _pizzaList = new List<Pizza>();
        }
        public int Count
        { 
            get { return _pizzaList.Count; } 
        }

        public void PrintPizza()
        {
            foreach (Pizza pizza in _pizzaList)
            {
                Console.WriteLine(pizza.ToString());
            }
        }

        public void AddPizza(Pizza aPizza)
        {
            _pizzaList.Add(aPizza);
        }

        public Pizza LookupPizza(string pizzaNo)
        {
            foreach (Pizza item in _pizzaList)
            {
                if (item.PizzaNo == pizzaNo)
                    return item;
            }
            return null;
        }
        public void DeletePizza(string pizzaNo)
        {
            _pizzaList.Remove(LookupPizza(pizzaNo));
        }

        public void EditPizza(string pizzaNo, Pizza pizzaToEdit)
        {
            int a = 0;
            while (a < _pizzaList.Count)
            {
                if (_pizzaList[a].PizzaNo == pizzaNo)
                {
                    _pizzaList[a] = pizzaToEdit;
                    break;
                }
                a++;
            }
        }
    }
}
