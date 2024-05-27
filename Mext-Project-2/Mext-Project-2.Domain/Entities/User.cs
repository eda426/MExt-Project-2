﻿using Mext_Project_2.Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mext_Project_2.Domain.Entities
{
    public class User:EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
    }
}
