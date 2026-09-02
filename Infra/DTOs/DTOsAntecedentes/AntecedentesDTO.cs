using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTOsAntecedentes
{
    public class AntecedentesDTO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
        public string AtributoRecomendado { get; init; } = string.Empty;
        public List<PericiasEnum> PericiasOpcoes { get; init; } = new();
        public CaracteristicaEspecialDTO CaracteristicaEspecial { get; init; }
    }
}
