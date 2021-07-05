using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DapperORM
{
    class Program
    {
        public CustomManager manager;
        public Customer customer;
        public int id;

        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediginiz islemi seciniz: ");
            Console.WriteLine("1- Kayıt Sil ");
            Console.WriteLine("2- Tüm kayıtları listele ");
            Console.WriteLine("3- Kayıt ekle ");
            Console.WriteLine("4- Kayıt Güncelle");

            int selected = int.Parse(Console.ReadLine());

            switch (selected)
            {
                case 1:
                    DeleteCustomer();
                    break;
                case 2:
                    ListCustomers();
                    break;
                case 3:
                    Add_UpdateCustomer();
                    break;
                case 4:
                    Add_UpdateCustomer();
                    break;
            }


        }
        public static void DeleteCustomer()
        {
            Console.WriteLine("Silmek istediginiz müşteri ID :  ");
            int ID = int.Parse(Console.ReadLine());

            customer = new Customer()
            {
                CustomerID = id
            };
            manager = new CustomManager();
            manager.DeleteCustomer(customer);



        }
        public static void ListCustomers()
        {
            manager = new CustomManager();
            List<Customer> customers = manager.GetAll();

            foreach(var item in customers)
            {
                Console.WriteLine(item);
            }
        }
        public static void Add_UpdateCustomer()
        {
            Console.WriteLine("Müşteri Adı: ");
            string name = Console.ReadLine();

            Console.WriteLine("Müşteri Soyadı: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Müşteri Yaş: ");
            int age = int.Parse(Console.ReadLine());

            customer = new Customer()
            {
                CustomerID = id,
                CustomerName = name,
                CustomerSurname = surname,
                CustomerAge = age
            };

            if(id == 0)
            {
                manager = new CustomManager();
                manager.AddCustomer(customer);
                
            }
            else
            {
                manager = new CustomManager();
                manager.UpdateCustomer(customer);
            }

        }
    }
}
