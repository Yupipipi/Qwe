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
    public class PensContext : DbContext
    {
        public DbSet<Pens> Penses { get; set; }
        public DbSet<Purchasep> Purchasesp { get; set; }
    }
}