using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationRazorPagesTutorial.Models
{
    public class WebApplicationRazorPagesTutorialContext : DbContext
    {
        public WebApplicationRazorPagesTutorialContext (DbContextOptions<WebApplicationRazorPagesTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRazorPagesTutorial.Models.Movie> Movie { get; set; }
    }
}
