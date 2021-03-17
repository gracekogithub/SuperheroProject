using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Superheros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Superheros.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Superhero> Superheros { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
    }
}
