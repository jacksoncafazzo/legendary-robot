﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApplication5.Models;

namespace WebApplication5.DAL

    {
        public class MoviesContext : DbContext
        {

            public MoviesContext() : base("MoviesContext")
            {
            }

            public DbSet<Movie> Movies { get; set; }
           
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}
}