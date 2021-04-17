using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrella.Model
{
    public class ItemPersonalizacao
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double Valor { get; set; }

        public int EmpreendimentoId { get; set; }

    }
}
