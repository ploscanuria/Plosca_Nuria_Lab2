using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plosca_nuria_lab2.Models;

namespace Plosca_nuria_lab2.Data
{
    public class Plosca_nuria_lab2Context : DbContext
    {
        public Plosca_nuria_lab2Context (DbContextOptions<Plosca_nuria_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Plosca_nuria_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Plosca_nuria_lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Plosca_nuria_lab2.Models.Author> Author { get; set; } = default!;
    }
}
