using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Museums_Backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        : base("name=DefaultConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public DbSet<BesucherAnzahlA> AnzahlA { get; set; }
        public DbSet<BesucherAnzahlB> AnzahlB { get; set; }
        public DbSet<Öffnungszeiten> Anzahl { get; set; }
    }
}