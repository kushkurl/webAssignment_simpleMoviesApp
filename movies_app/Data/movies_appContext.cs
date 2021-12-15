using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies_app.Models;

namespace movies_app.Data
{
    public class movies_appContext : DbContext
    {
        public movies_appContext (DbContextOptions<movies_appContext> options)
            : base(options)
        {
        }

        public DbSet<movies_app.Models.Movie> Movie { get; set; }
    }
}
