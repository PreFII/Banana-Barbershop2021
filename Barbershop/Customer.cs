using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Customer
    {
        private static int cur_max_id = 0;

        public string name;
        public string last_name;
        private int id;

        public Customer(string _name, string _last_name)
        {
            name = _name;
            last_name = _last_name;
            id = cur_max_id;
            cur_max_id++;
        }

        public void print()
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Клиент № " + id + ":");
            Console.WriteLine(name + " " + last_name);
            Console.WriteLine("________________________");
        }

        public bool is_compare(Customer other)
        {
            if((id == other.id) && (name == other.name) && (last_name == other.last_name))
            {
                return true;
            }
            return false;
        }


    }
}
