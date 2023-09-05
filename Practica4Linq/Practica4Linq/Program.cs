using Practica4Linq.Entities;
using Practica4Linq.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool exit = false;
            List<string> options = new List<string>() {
                "Query para devolver objeto customer",
                "Query para devolver todos los productos sin stock",
                "Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad",
                "Query para devolver todos los customers de la Región WA",
                "Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789",
                "Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.",
                "Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.",
            };

            while (!exit)
            {
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {options[i]}");
                }

                Console.Write("Ingresa un número (0 para salir): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Ingrese el Id del elemento a buscar");
                        string id = Console.ReadLine();
                        GetCustomer(id);
                        break;
                    case "2":
                        GetProductsWithOutStock();
                        break;
                    case "3":
                        GetProductsWithStockAndHigherPrice();
                        break;
                    case "4":
                        GetCustomerRegion("WA");
                        break;
                    case "5":
                        GetFirstElementOrNotNull();
                        break;
                    case "6":
                        GetCustomersWithLowerAndUpperName();
                        break;
                    case "7":
                        GetCustomersInWaWithOrdersAfter1997();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        public static void GetCustomer(string id)
        {
            CustomerLogic customersLogic = new CustomerLogic();
            var customer = customersLogic.GetElementById(id);

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
        public static void GetProductsWithOutStock()
        {
            ProductLogic productLogic = new ProductLogic();
            var products = productLogic.GetProductsWithOutStock();
            foreach ( var product in products )
            {
                Console.WriteLine($"-- Nombre producto: {product.ProductName}");
                Console.WriteLine($"-- Cantidad disponible: {product.UnitsInStock}");
            }
        }
        public static void GetProductsWithStockAndHigherPrice()
        {
            ProductLogic productLogic = new ProductLogic();
            var products = productLogic.GetProductsWithStockAndHigherPrice();
            foreach (var product in products)
            {
                Console.WriteLine($"-- Nombre producto: {product.ProductName}");
                Console.WriteLine($"-- Cantidad disponible: {product.UnitsInStock}");
                Console.WriteLine($"-- Precio por unidad: {product.UnitPrice}");
            }
        }
        public static void GetCustomerRegion(string region)
        {
            CustomerLogic customersLogic = new CustomerLogic();
            var customers = customersLogic.GetCustomerRegion(region);
            foreach (var customer in customers)
            {
                Console.WriteLine($"-- Nombre Cliente: {customer.ContactName}");
                Console.WriteLine($"-- Region: {customer.Region}");
            }
        }
        public static void GetFirstElementOrNotNull()
        {
            ProductLogic productLogic = new ProductLogic();
            var product = productLogic.GetFirstElementOrNull();
            if ( product == null)
            {
                Console.WriteLine("Product Null");
                return;
            }
            Console.WriteLine($"ID producto: {product.ProductID}");
            Console.WriteLine($"-- Nombre producto: {product.ProductName}");
        }
        public static void GetCustomersWithLowerAndUpperName()
        {
            CustomerLogic customersLogic = new CustomerLogic();
  
            foreach (var customer in customersLogic.GetUpperName())
            {
                Console.WriteLine($"-- Nombre Mayuscula: {customer}");
            }

            foreach (var customer in customersLogic.GetLowerName())
            {
                Console.WriteLine($"-- Nombre Minuscula: {customer}");
            }
        }

        public static void GetCustomersInWaWithOrdersAfter1997()
        {
            OrderLogic orderLogic = new OrderLogic();

            var customers = orderLogic.GetCustomersInWAWithOrdersAfter1997();

            foreach (var element in customers)
            {
                Console.WriteLine($"-- Nombre del cliente: {element.Customers.ContactName}");
                Console.WriteLine($"-- Fecha Orden: {element.OrderDate}");
                Console.WriteLine($"-- Region Cliente: {element.Customers.Region}");

            }
        }
    }
}
