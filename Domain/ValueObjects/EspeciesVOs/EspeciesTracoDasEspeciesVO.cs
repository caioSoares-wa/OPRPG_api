using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public class EspeciesTracoDasEspeciesVO
    {
        public List<EspeciesTracoDasEspeciesBeneficioVO> Beneficios { get; init; }
        public List<EspeciesDificuldadesVO> Dificuldades { get; init; }
    }
}
