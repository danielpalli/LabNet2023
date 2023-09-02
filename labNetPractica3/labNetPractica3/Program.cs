using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OrdersLogic ordersLogic = new OrdersLogic();
            CustomersLogic customersLogic = new CustomersLogic();

            //Console.WriteLine("-- Customers Address:");

            //foreach (Customers customer in customersLogic.GetAll())
            //{
            //    Console.WriteLine(customer.Address);
            //}
            //Console.ReadLine();

            bool active = false;
            List<string> options = new List<string>() { "Ver clientes", "Ver ordenes", "Insertar cliente", "Eliminar cliente", "Actualizar datos cliente", "salir" };

            while (!active)
            {
                for (int i = 0; i < options.Count ; i++)
                {
                    Console.WriteLine($"{i + 1} {options[i]}");
                }
                Console.WriteLine("Probando");
                //int optionMenu = int.Parse(Console.ReadLine());
                //Console.WriteLine("Probando");

                active = true;

            }
            Console.ReadKey();
        }
    }
}
