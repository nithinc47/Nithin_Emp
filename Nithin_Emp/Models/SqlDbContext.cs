using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nithin_Emp.Models
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConn")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }  
    
}