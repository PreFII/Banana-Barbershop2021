using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Service
    {
        private static int cur_max_id = 0;

        public string name;
        public int price;
        private int id;

        public Service(string _name, int _price)
        {
            name = _name;
            price = _price;
            id = cur_max_id;
            cur_max_id++;
        }

        public void print()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("Услуга №" + id + ":");
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("___________________");
        }

        public bool is_compare(Service other)
        {
            if ((id == other.id) && (name == other.name) && (price == other.price))
            {
                return true;
            }
            return false;
        }
    }
}
