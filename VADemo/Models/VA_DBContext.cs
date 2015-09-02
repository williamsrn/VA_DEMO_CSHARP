namespace VADemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VA_DBContext : DbContext
    {
        
        public VA_DBContext() : base("name=VADemo")
        {
        }

        public System.Data.Entity.DbSet<VADemo.Models.Person> People { get; set; }

       
    }

}