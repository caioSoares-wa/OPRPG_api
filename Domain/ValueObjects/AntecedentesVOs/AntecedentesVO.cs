using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.AntecedentesVO
{
    public record AntecedentesVO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
        public string AtributoRecomendado { get; init; } = string.Empty;
        public List<PericiasEnum> PericiasOpcoes { get; init; } = new();
        public CaracteristicasEspecialVO CaracteristicaEspecial { get; init; }


        public AntecedentesVO()
        {

        }
    }
}
