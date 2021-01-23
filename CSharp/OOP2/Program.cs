using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ayşe İlhanlı (Bireysel Müşteri)
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12324";
            customer1.Name = "Ayşe";
            customer1.LastName = "İlhanlı";
            customer1.TcNo = "11111111110";

            //Kodlama.io (Tüzel Müşteri)
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "123450";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "14564651651";

            //Gerçek Müşteri- Tüzel müşter 
            //SOLID

            Customer customer3 = new IndividualCustomer(); //Customer sınıfım parent olduğu için alt classların nesnesinide tuttmuş olur.
            //Bir yerde new var is bellekteki referans nosudur. Customer classı hem gerçek müşterinin hemde tüzel müşterinin refransını tutar. 
            Customer customer4 = new CorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);//Temel sınıfın onu kalıtım olarak alan classların referansını tutabiliyor.
        }
    }
}
