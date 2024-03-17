using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;

class Customer
{
    //field
    //public string FirstName;

    //property : nesne : özellik
    public int Id { get; set; }

    //autopropertynin çalışma mantığı , solid'in s'ine aykırıdır
    private string _firstName; // field
    public string FirstName
    {
        get { return "Mr." + _firstName; };
        set { _firstName = value; };
    }

    //autoproperty
    public string LastName { get; set; }
    public string City { get; set; }

}

