using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Setup for one pizza

namespace Uml2Sarah
{
    public class Pizza
    {
        #region Instance fields
        string _pizzaName;
        string _pizzaTopping;
        string _pizzaNo;
        double _pizzaPrice;
        #endregion

        #region Constructor
        public Pizza(string pizzaName, string pizzaTopping, string pizzaNo, double pizzaPrice)
        {
            _pizzaName = pizzaName;
            _pizzaTopping = pizzaTopping;
            _pizzaNo = pizzaNo;
            _pizzaPrice = pizzaPrice;
        
        }
        #endregion

        #region Properties
        public string PizzaName
        {
            get { return _pizzaName; }
        }
        public string PizzaTopping
        {
            get { return _pizzaTopping; }
        }
        public string PizzaNo
        {
            get { return _pizzaNo; }
        }
        public double PizzaPrice
        {
            get { return _pizzaPrice; }
        }

        public override string ToString()
        {
            return $"\tPizza No. {_pizzaNo} Name: {_pizzaName}. \tCost: {_pizzaPrice} Kr.    \tToppings: {_pizzaTopping}. ";
        }
        #endregion
    }
}
