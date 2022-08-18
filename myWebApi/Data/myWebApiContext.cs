using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myWebApi.Data
{
    public class myWebApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public myWebApiContext() : base("name=myWebApiContext")
        {
        }

        public System.Data.Entity.DbSet<myWebApi.Models.Employee> Employees { get; set; }

        public string connString
        {
            get
            {
                return "localhost;Integrated Security=True";
            }
        }
    }
}
