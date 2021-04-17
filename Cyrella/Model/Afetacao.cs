using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrella.Model
{
    public class Afetacao
    {
        public int Id { get; set; }
        public string Bem { get; set; }
        public double ValorBem { get; set; }

        public int EmpreendimentoId { get; set; }
    }
}
