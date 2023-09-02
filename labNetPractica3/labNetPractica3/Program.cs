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
                        AddNewCustomer(customersLogic);
                        break;
                    case "4":
                        DeleteCustomer(customersLogic);
                        break;
                    case "5":
                        UpdateCustomer(customersLogic);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
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

        public static void AddNewCustomer (CustomersLogic customersLogic)
        {
            Console.WriteLine("Ingrese el ID:");
            string customerId = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la compania:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del contacto:");
            string contactName = Console.ReadLine();
            Console.WriteLine("Ingrese el título del contacto:");
            string contactTitle = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion:");
            string address = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad:");
            string city = Console.ReadLine();
            Console.WriteLine("Ingrese la region:");
            string region = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo postal:");
            string postalCode = Console.ReadLine();
            Console.WriteLine("Ingrese el pais:");
            string country = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono:");
            string phone = Console.ReadLine();
            Console.WriteLine("Ingrese el fax:");
            string fax = Console.ReadLine();

            var newCustomer = new Customers
            {
                CustomerID = customerId,
                CompanyName = companyName,
                ContactName = contactName,
                ContactTitle = contactTitle,
                Address = address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax
            };

            customersLogic.Add(newCustomer);
        }

        public static void DeleteCustomer(CustomersLogic customersLogic)
        {
            Console.WriteLine("Ingrese el id del cliente a eliminar:");
            string id = Console.ReadLine();

            customersLogic.Delete(id);
        }

        public static void UpdateCustomer(CustomersLogic customersLogic)
        {
            Console.WriteLine("Ingrese el id del cliente a actualizar:");
            string id = Console.ReadLine();

            customersLogic.Update(id);   
        }

    }
}
