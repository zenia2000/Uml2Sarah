using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//setup for one customer

namespace Uml2Sarah
{
    public class Customer
    {
        string _id;
        string _name;
        string _phone;
        string _address;

        public Customer(string id, string name, string phone, string address)
        {
            _id = id;
            _name = name;
            _phone = phone;
            _address = address;
        }
        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Phone { get { return _phone; } }
        public string Address { get { return _address; } }

        public override string ToString()
        {
            return $"Customer no. {_id}, {_name}. Phone: {_phone}. Address: {_address}";
        }
    }
}
