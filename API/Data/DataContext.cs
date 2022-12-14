// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

using System.Diagnostics;
using System.Diagnostics.Contracts;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}