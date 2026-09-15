using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.EstilosDTOs
{
    public record ProficienciaPericias
    {
        public string Descricao { get; set; }
        public List<string>? Opcoes { get; init; }
        public int Quantidade { get; init; }
    }
}
