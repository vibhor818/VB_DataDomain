using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VB_DataDomain.Models;

namespace VB_DataContext.MyContexts
{
    public class VBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=empdb;trusted_connection=true");
        }
        public DbSet<Emp> Emp { get; set; }
    }
}
