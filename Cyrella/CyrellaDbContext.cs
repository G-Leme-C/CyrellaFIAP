using Cyrella.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrella
{
    public class CyrellaDbContext : DbContext 
    {
        public DbSet<AgendamentoManutencao> AgendamentoManutencao { get; set; }
        public DbSet<ImagemAgendamento> ImagensAgendamentos { get; set; }


        public CyrellaDbContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {
        }
    }
}
