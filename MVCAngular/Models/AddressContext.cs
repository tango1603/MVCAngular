using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAngular.Models
{
    public class AddressContext : DbContext
    {
        public DbSet<Address> Addreses { get; set; }
    }
}