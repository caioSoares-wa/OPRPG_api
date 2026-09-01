using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesVO
    {
        public string Nome { get; init; } = string.Empty;
        public string AjusteDeAtributo { get; init; } = string.Empty;
        public string Preconceito { get; init; } = string.Empty;
        public int PontosDeVidaBase { get; init; } 

        public EspeciesTamanhoVO Tamanho { get; init; } 
        public EspeciesPesoVO Peso { get; init; }
        public int DeslocamentoMetros { get; init; }
        public int NadoMetros { get; init; }
        public EspeciesTracoDasEspeciesVO TracosDasEspecies { get; init; }
        public EspeciesTracosCulturaisVO TracoCultural { get; init; }

        public EspeciesVarianteDaEspecieVO? VarianteDaEspecie { get; init; }
        public EspeciesAncestralidadeVO? Ancestralidade { get; init; }
        public List<EspeciesRegrasEspeciaisVO>? RegrasEspeciais { get; init; }


        


    }
}
