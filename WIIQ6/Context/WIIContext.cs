using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WIIQ6.Models;

namespace WIIQ6.Context
{
    public class WIIContext : DbContext
    {
        public WIIContext() : base("WII") { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}