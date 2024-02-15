using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_CRUD_EF.Models
{
    public class Context : DbContext
    {
        public Context() : base("CrudContextDemo")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}