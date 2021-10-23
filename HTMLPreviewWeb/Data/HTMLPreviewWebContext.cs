using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HTMLPreviewWeb.Models;

namespace HTMLPreviewWeb.Data
{
    public class HTMLPreviewWebContext : DbContext
    {
        public HTMLPreviewWebContext (DbContextOptions<HTMLPreviewWebContext> options)
            : base(options)
        {
        }

        public DbSet<HTMLPreviewWeb.Models.HTMLContent> HTMLContent { get; set; }
    }
}
