using EntityFrameworkCore1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore1.Data
{
    public class EntityFrameworkCoreContext: DbContext
    {
        public EntityFrameworkCoreContext(DbContextOptions<EntityFrameworkCoreContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
