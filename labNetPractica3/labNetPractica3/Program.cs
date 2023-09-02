﻿using Entities;
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
            OrdersLogic ordersLogic = new OrdersLogic();
            CustomersLogic customersLogic = new CustomersLogic();

            bool exit = false;
            List<string> options = new List<string>() { "Ver clientes", "Ver ordenes", "Insertar cliente", "Eliminar cliente", "Actualizar datos cliente", "salir" };

            while (!exit)
            {
                for (int i = 0; i < options.Count ; i++)
                {
                    Console.WriteLine($"{i + 1} {options[i]}");
                }

                Console.Write("Ingresa un número (6 para salir): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        GetCustomerList(customersLogic);
                        break;
                    case "2":
                        GetOrderList(ordersLogic);
                        break;
                    case"3":
                        //AddNewCustomer(customersLogic);
                        break;
                    case "4":
                        //DeleteCustomer(customersLogic);
                        break;
                    case "5":
                        //UpdateCustomer(customersLogic);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void GetCustomerList(CustomersLogic customersLogic)
        {
            Console.WriteLine("Listado de clientes:");

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"ID: {customer.CustomerID}");
                Console.WriteLine($"-- Nombre Compania: {customer.CompanyName}");
                Console.WriteLine($"-- Nombre Contacto: {customer.ContactName}");
                Console.WriteLine($"-- Titulo Contacto: {customer.ContactTitle}");
                Console.WriteLine($"-- Direccion: {customer.Address}");
                Console.WriteLine($"-- Ciudad: {customer.City}");
                Console.WriteLine($"-- Region: {customer.Region}");
                Console.WriteLine($"-- Codigo Postal: {customer.PostalCode}");
                Console.WriteLine($"-- Pais: {customer.Country}");
                Console.WriteLine($"-- Telofono: {customer.Phone}");
                Console.WriteLine($"-- Fax: {customer.Fax}");
            }
        }
        public static void GetOrderList(OrdersLogic ordersLogic)
        {
            Console.WriteLine("Listado de ordenes:");

            foreach (Orders orders in ordersLogic.GetAll())
            {
                Console.WriteLine($"ID: {orders.OrderID}");
                Console.WriteLine($"-- Fecha de orden: {orders.OrderDate}");
            }
        }
    }
}
