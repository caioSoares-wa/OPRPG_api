using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Antecedentes
{
    public record AntecedentesSub
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
        public List<PericiasEnum> PericiasOpcoes = new();
        public AtributosEnum atributoRecomendado { get; init; }
        public CaracteristicaEspecial CaracteristicaEspecial { get; init; } = new();





    }
}
