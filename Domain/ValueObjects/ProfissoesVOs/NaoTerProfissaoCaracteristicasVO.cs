using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.ProfissoesVOs
{
    public record NaoTerProfissaoCaracteristicasVO
    {

        public string Nome { get; init; }
        public string Descricao { get; init; }
    }
}
