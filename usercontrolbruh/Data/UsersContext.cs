using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usercontrolbruh.Models;

namespace usercontrolbruh.Data
{
    public class UsersContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public UsersContext() 
        {
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=SzervkereskedoBt;Trusted_Connection=True;");
        }


    }
}
