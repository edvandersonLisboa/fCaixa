﻿using Domain.Entities;
using Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPaymentStatusRepository : IRepository<PaymentStatus>
    {
    }
}
