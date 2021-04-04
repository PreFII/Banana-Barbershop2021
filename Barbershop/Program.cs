using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Program
    {
        public static void print_menu()
        {
            Console.WriteLine("Привет ! Это симуляция работы Барбершопа");
            Console.WriteLine("Есть такие функции:");
            Console.WriteLine("Напечатать информацию о бабершопе - введите print_all");
            Console.WriteLine("Добавить клиента - введите all_custome name last_name");
            Console.WriteLine("Добавить услугу - введите add_service name price");
            Console.WriteLine("Выйти - введите q");
        }

        public static void add_customer(string[] user_input_array)
        {
            if(user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления клиента нужно имя и фамилия");
                return;
            }
            if(Barbershop.add_customer(user_input_array[1], user_input_array[2]))
            {
                Console.WriteLine("Клиент успешно добавлен");
            }
            else
            {
                Console.WriteLine("Клиент не был добавлен");
            }
        }

        public static void add_service(string[] user_input_array)
        {
            if (user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления услуги нужно название и цена");
                return;
            }

            int price;

            try
            {
                price = Convert.ToInt32(user_input_array[2]);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Цена должна быть целым числом");
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Цена слишком большая");
                return;
            }

            if(Barbershop.add_service(user_input_array[1], price))
            {
                Console.WriteLine("Услуга успешно добавлена");
            }
            else
            {
                Console.WriteLine("Услуга не была добавлена");
            }
            
        }

        static void Main(string[] args)
        {
            print_menu();
            string user_input = "";
            while (user_input != "q")
            {
                Console.WriteLine("Введите команду");
                user_input = Console.ReadLine();
                string[] user_input_array = user_input.Split(' ');
                if(user_input_array.Length == 0)
                {
                    Console.WriteLine("Пожалуйста введите команду!");
                    continue;
                }

                switch(user_input_array[0])
                {
                    case "print_all":
                        Barbershop.print();
                        break;
                    case "add_customer":
                        add_customer(user_input_array);
                        break;
                    case "add_service":
                        add_service(user_input_array);
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }

            }
        }
    }
}
