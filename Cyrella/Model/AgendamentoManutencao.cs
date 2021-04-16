using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrella.Model
{
    public class AgendamentoManutencao
    {
        public int Id { get; set; }
        public DateTime DtAberturaChamado { get; set; }
        public DateTime DtAgendamento { get; set; }
        public string ItemComDefeito { get; set; }
        public string DescricaoDefeito { get; set; }
        public string Comodo { get; set; }
        

        public ICollection<ImagemAgendamento> ImagensAnexas { get; set; }


        public AreaAssistencia AreaDeAssistencia { get; set; }
        public bool Recorrencia { get; set; }

        public enum AreaAssistencia
        {
            Eletrica,
            Hidraulica,
            Alvenaria,
            Pintura,
            Marcenaria
        }
    }
}
