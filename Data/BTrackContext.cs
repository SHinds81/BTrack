using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTrack.Models;

namespace BTrack.Data
{
    public class BTrackContext : DbContext
    {
        public BTrackContext (DbContextOptions<BTrackContext> options)
            : base(options)
        {
        }

        public DbSet<BTrack.Models.Bugs> Bugs { get; set; } = default!;

        public DbSet<BTrack.Models.Account> Account { get; set; } = default!;

        public DbSet<BTrack.Models.Login> Login { get; set; } = default!;

        public DbSet<BTrack.Models.Update> Update { get; set; } = default!;
    }
}
