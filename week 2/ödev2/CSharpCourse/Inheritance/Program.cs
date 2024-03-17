using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "engin"
                },
                new Student
                {
                    FirstName = "derin"
                },
                new Person
                {
                    FirstName = "salih"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

    class Person2
    {
        
    }

class Customer : Person // person customerın babası gibi,
                        // istediğin kadar interface ekleyebilirsin
                        // inheritance önce yazılmak şartıyla
{
    public string City { get; set; }
}

class Student : Person //sadece bir inheritance alabilirsin, tek baban olabilir
{
    public string Department { get; set; }
}
}
