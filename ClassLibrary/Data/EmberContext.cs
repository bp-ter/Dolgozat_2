using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
    public class EmberContext : DbContext
    {
        public DbSet<Ember> Emberek { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=EmberDb;Trusted_Connection=True;");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string myConnectionString = "Server=127.0.0.1;User ID=root;  Password=;Database=EmberDb";
             optionsBuilder.UseMySql(myConnectionString, ServerVersion.AutoDetect(myConnectionString));
        }



    }
}
