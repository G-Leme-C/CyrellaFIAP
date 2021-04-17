using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrella.Model
{
    public class Empreendimento
    {
        public int Id { get; set; }
        public int PercentualCompleto { get; set; }
        public string FaseAtual { get; set; }

        public DateTime DtLancamento { get; set; }
        public int QtUnidadesDisponiveis { get; set; }
        public double ValorInicial { get; set; }

        public ICollection<Afetacao> Afetacoes { get; set; }

        public ICollection<FaseObra> FasesObra { get; set; }

        public ICollection<ItemPersonalizacao> Personalizacao { get; set; }

        public DateTime DtInicioVistoria { get; set; }
        
        public DateTime DtAssembleia { get; set; }
        public string PautaAssembleia { get; set; }

        public DateTime DtEntregaChaves { get; set; }

        public DateTime DtDuracaoGarantia { get; set; }
        public string CoberturaGarantia { get; set; }

    }
}
