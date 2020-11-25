using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kotai_Melinda_Lab8.Models;

namespace Kotai_Melinda_Lab8.Data
{
    public class Kotai_Melinda_Lab8Context : DbContext
    {
        public Kotai_Melinda_Lab8Context (DbContextOptions<Kotai_Melinda_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Kotai_Melinda_Lab8.Models.Book> Book { get; set; }

        public DbSet<Kotai_Melinda_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Kotai_Melinda_Lab8.Models.Category> Category { get; set; }
    }
}
