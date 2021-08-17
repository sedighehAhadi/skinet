﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreContext :DbContext
    {
        public StoreContext(  DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
