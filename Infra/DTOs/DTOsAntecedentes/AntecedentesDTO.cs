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
        public List<string> PericiasOpcoes { get; init; } = new List<string>();
        public CaracteristicaEspecialDTO CaracteristicaEspecial { get; init; }
    }
}
