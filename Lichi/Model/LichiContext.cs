using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lichi.Model
{
    public class LichiContext : DbContext
    {
        public LichiContext(DbContextOptions<LichiContext> options) : base(options)
        {
        }
        public DbSet<TblEmployee> TblEmployee { get; set; }
        public DbSet<TblDesignation> TblDesignation { get; set; }
    }
}
