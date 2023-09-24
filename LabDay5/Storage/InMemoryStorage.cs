using LabDay5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay5.Storage
{
    public class InMemoryStorage : DbContext, IStorage
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostAttachment> PostAttachments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
