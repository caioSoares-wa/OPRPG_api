using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record AntecedentesVO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
        public string AtributoRecomendado { get; init; } = string.Empty;
        public List<string> PericiasOpcoes { get; init; } = new List<string>();
        public CaracteristicasEspecialVO CaracteristicaEspecial { get; init; }


        public AntecedentesVO()
        {

        }
    }
}
