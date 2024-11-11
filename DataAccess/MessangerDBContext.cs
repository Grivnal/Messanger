using ClientApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MessangerDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Messaging> Messagings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=MessangeerDatabase.mssql.somee.com;packet size=4096;user id=Grivnal_SQLLogin_1;pwd=ecauc15owm;data source=MessangeerDatabase.mssql.somee.com;persist security info=False;initial catalog=MessangeerDatabase;TrustServerCertificate=True");
            

        }
    }
}
