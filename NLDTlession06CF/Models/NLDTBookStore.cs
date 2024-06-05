using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NLDTlession06CF.Models
{
    public class NLDTBookStore:DbContext
    {
        public NLDTBookStore():base("LDTBookStoreConnectionString") { }
        // khai bao cac thuoc tinh tuong ung trong csdl
        public DbSet<NLDTCategory> NLDTCategories { get; set; }
        public DbSet<NLDTBook> NLDTBooks { get; set; }

    }
}