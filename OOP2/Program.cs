using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek musteri yucel taskiran
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Yucel";
            customer1.Surname = "Taskiran";
            customer1.IdentityNumber = "12345678910";


            //Tüzel müşteri - Kodlama.io
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
