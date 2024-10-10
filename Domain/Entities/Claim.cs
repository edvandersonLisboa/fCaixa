﻿using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Claim : Entity
    {

        public string Type { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public ICollection<UserClaim> UserClaims { get; set; } = [];
    }
}
