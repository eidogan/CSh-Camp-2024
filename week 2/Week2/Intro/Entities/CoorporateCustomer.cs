﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class CoorporateCustomer : BaseCustomer
{
    public string Name { get; set; } //company name
    public string TaxNumber { get; set; }
}
