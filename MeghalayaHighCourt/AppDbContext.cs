﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeghalayaHighCourt
{
    public class AppDbContext:DbContext
    {
        public DbSet<caseDetail> CaseDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=MeghalayaCourt;User Id=postgres;Password=root;");
        }
    }
}
