using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kerekes_Ida_Roberta_Lab2.Models;

namespace Kerekes_Ida_Roberta_Lab2.Data
{
    public class Kerekes_Ida_Roberta_Lab2Context : DbContext
    {
        public Kerekes_Ida_Roberta_Lab2Context (DbContextOptions<Kerekes_Ida_Roberta_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Kerekes_Ida_Roberta_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Kerekes_Ida_Roberta_Lab2.Models.Author>? Author { get; set; }
    }
}
