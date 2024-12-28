using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace asp.net.Data
{
    public class ApplicationDBContext : DbContext
    {
        //We are using base to pass an object of DbContextOptions to DbContext (the parent class)
        public ApplicationDBContext(DbContextOptions DbContextOptions): base(DbContextOptions)
        {
            

        }

        public DbSet<Stock> Stock {get; set;}
        public DbSet<Comment> Comments {get; set;}
        
    }
}