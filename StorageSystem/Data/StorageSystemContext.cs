using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StorageSystem.Models;

namespace StorageSystem.Data
{
    public class StorageSystemContext : DbContext
    {
        public StorageSystemContext (DbContextOptions<StorageSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StorageSystem.Models.Product> Product { get; set; } = default!;
        public DbSet<StorageSystem.Models.ProductViewModel> ProductViewModel { get; set; } = default!;
    }
}
