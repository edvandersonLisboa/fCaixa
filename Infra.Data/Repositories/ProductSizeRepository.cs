﻿using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ProductSizeRepository : Repository<ProductSize>, IProductSizeRepository
    {
        public ProductSizeRepository(AppSqliteContext dbContext) : base(dbContext)
        { }
    }
}
