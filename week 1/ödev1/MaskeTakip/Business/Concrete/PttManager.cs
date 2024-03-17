﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //dependancy enjection
        private IApplicantService _applicantService;

        //design pattern
        public PttManager(IApplicantService applicantService) //constructor, new yapıldığında çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); // new kullanmak seni personmanager'a bağımlı kılar!
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}