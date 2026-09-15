using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.AntecedentesDTOs
{
    public record AntecedentesDTO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
        public List<PericiasEnum> PericiasOpcoes = new();
        public AtributosEnum atributoRecomendado { get; init; }
        public CaracteristicaEspecialDTO CaracteristicaEspecial { get; init; } = new();
    }
}
