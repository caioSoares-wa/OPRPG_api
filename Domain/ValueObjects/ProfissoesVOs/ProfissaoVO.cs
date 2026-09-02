using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.ProfissoesVOs
{
    public record ProfissaoVO
    {
        public string Nome { get; set; }
        public string ExemplosDeUso { get; set; }
        public List<string> PericiasElegiveis { get; set; }
        public int QuantidadeDeEscolhas { get; set; }
        public string FerramentasEEquipamento { get; set; }

    }
}
