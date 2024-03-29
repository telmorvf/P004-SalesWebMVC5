﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        // mdb em
        // C:\ProgramData\MySQL\MySQL Server 8.0\Data\sales
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVC.Models.Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SalesRecord { get; set; }

        //public DbSet<SalesWebMVC.Models.Enums.SaleStatus> SaleStatus { get; set; }
    }
}
