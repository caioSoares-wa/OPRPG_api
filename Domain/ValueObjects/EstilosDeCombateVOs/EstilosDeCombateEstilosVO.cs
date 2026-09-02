using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public record EstilosDeCombateEstilosVO
    {
        public string Nome { get; init; } = string.Empty;
        public int DadoDeVida { get; init; }
        public int PontosDeVidaNivel1 { get; init; }
        public EstilosDeCombateAtributoPrimarioVO AtributoPrimario { get; init; }
        public EstilosDeCombateSalvaguardasVO Salvaguardas { get; init; }
        public EstilosDeCombateProficienciasArmasVO ProficienciaArmas { get; init; }
        public EstiloDeCombateProficienciaPericiasVO ProficienciaPericias { get; init; }
        public EstiloDeCombateArmaFavoritaVO ArmaFavorita { get; init; }
        public EstiloDeCombateHabilidadeInataOpcoesVO HabilidadeInataOpcoes { get; init; }
        public EstiloDeCombateEquipamentoInicialVO EquipamentoInicial { get; init; }


    }
}
