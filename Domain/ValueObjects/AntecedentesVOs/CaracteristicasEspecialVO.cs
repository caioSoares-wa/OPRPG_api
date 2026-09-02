using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.AntecedentesVO
{
    public record CaracteristicasEspecialVO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;


        public CaracteristicasEspecialVO()
        {
            
        }

    }
}
