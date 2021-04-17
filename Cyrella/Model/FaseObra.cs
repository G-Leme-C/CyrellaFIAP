using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrella.Model
{
    public class FaseObra
    {
        public int Id { get; set; }
        public string Fase { get; set; }
        public int Percentual { get; set; }

        public int EmpreendimentoId { get; set; }
    }
}
