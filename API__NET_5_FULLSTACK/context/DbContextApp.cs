using API__NET_5_FULLSTACK.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API__NET_5_FULLSTACK.context
{
    public class DbContextApp : DbContext
    {
        public DbContextApp(DbContextOptions<DbContextApp> options): base(options)
        {

        }

        public DbSet<PlayerNba> PlayerNba { get; set; }
    }
}
