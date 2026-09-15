using Services.DTOs.EstilosDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.Estilos
{
    public record EstilosDTO
    {

        public string Nome { get; init; } = string.Empty;
        public int DadoDeVida { get; init; }
        public List<string> AtributoPrimario { get; init; }
        public List<string> Salvaguardas { get; init; }
        public List<string> ProficienciaArmas { get; init; }
        public ProficienciaPericias ProficienciaPericias { get; init; }
        public ArmaFavorita ArmaFavorita { get; init; }
        public List<string> HabilidadeInataOpcoes { get; init; }
        public string EquipamentoInicial { get; init; }


    }
}
