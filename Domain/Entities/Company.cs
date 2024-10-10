﻿
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company : Entity
    {
       
        public string Name { get; set; } = string.Empty;
        public ICollection<Branch> Branches { get; set; } = [];
        public ICollection<User> Users { get; set; } = [];
    }
}
