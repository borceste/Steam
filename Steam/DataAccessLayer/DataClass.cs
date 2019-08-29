using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Steam.Models;

namespace Steam.DataAccessLayer
{
    public class DataClass : DbContext
    {
        public DataClass() : base("DataClass")
        {

        }
        public DbSet<Game> Games { get; set; }

        
    }
}