using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.ProfissoesVOs
{
    public record NaoTerProfissaoVO
    {
        public string Descricao { get; init; }
        public List<NaoTerProfissaoCaracteristicasVO> Caracteristicas { get; init; }
    }
}
