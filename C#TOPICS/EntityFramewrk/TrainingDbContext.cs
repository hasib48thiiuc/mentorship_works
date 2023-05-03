﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramewrk
{
    public  class TrainingDbContext:DbContext
    {
        private string _connectionString;
        private string _assemblyName;
        public DbSet<Students1> Students { get; set; }


        public TrainingDbContext()
        {
            _connectionString = "Server =DESKTOP-M6I5G2C\\SQLEXPRESS; Database =MainDb; User Id= hasib; Password = 999111;TrustServerCertificate=True;";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

    }
}
