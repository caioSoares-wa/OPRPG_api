using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public class EspeciesTracosDaEspecieVO
    {
        public List<EspeciesTracosDaEspecieBeneficioVO> Beneficios { get; init; }
        public List<EspeciesDificuldadesVO> Dificuldades { get; init; }
    }
}
