﻿using SchoolOf.Common.Enums;
using SchoolOf.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Data.Models
{
    public class Cart : BaseEntityModel
    {
        CartStatus Status { get; set; }
        List<Product> Products { get; set; }
    }
}
