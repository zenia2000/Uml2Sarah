using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//info on all customers

namespace Uml2Sarah
{
    public class CustomerLibrary
    {
        private Dictionary<string,Customer> _customerDictionary;
        public CustomerLibrary()
        {
            _customerDictionary = new Dictionary<string, Customer>();
        }
        public int Count
        {
            get { return _customerDictionary.Count; }
        }
        public void AddCustomer(Customer aCustomer)
        {
            if (!_customerDictionary.ContainsKey(aCustomer.Id))
                _customerDictionary.Add(aCustomer.Id, aCustomer);
        }
        public Customer LookupCustomer(string id)
        {
            if (_customerDictionary.ContainsKey(id))
                return _customerDictionary[id];
            return null;
        }
        public void PrintCustomer()
        {
            foreach (Customer aCustomer in _customerDictionary.Values)
            {
                Console.WriteLine(aCustomer.ToString());
            }
        }
        public void UpdateCustomer(string id, Customer customerToUpdate)
        {
            if (_customerDictionary.ContainsKey(id))
                _customerDictionary[id] = customerToUpdate;
        }
        public void DeleteCustomer(string id)
        {
            _customerDictionary.Remove(id);
        }
    }
    

}
