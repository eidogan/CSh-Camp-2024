using Intro.Entities;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5647895412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{

    Console.WriteLine(customer.CustomerNumber);
}