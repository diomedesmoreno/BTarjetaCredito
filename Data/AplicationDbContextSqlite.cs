using BTarjetasCreditos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTarjetaCredito.Data
{
    public class AplicationDbContextSqlite: DbContext
    {
        public AplicationDbContextSqlite(DbContextOptions<AplicationDbContextSqlite> options) : base (options){ }

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
    }
}
