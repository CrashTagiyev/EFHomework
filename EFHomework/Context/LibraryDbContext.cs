using EFHomework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework.Context
{
    internal class LibraryDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HFMQLBA\\MSSQLSERVER01;Initial Catalog=ShopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<BookTypes> BookTypes { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<StudentBook> StudentBooks { get; set;}



    }
}
