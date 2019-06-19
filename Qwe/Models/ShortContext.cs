using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Drawing;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Qwe.Models
{
    public class ShopShortContext : DbContext
    {
        public DbSet<Short> Shorts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}