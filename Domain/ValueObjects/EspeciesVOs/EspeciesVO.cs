using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public record EspeciesVO
    {
        public string Nome { get; init; } = string.Empty;
        public string AjusteDeAtributo { get; init; } = string.Empty;
        public string Preconceito { get; init; } = string.Empty;
        public int PontosDeVidaBase { get; init; } 

        public EspeciesTamanhoVO Tamanho { get; init; } 
        public EspeciesPesoVO Peso { get; init; }
        public float DeslocamentoMetros { get; init; }
        public float NadoMetros { get; init; }
        public EspeciesTracosDaEspecieVO TracosDaEspecie { get; init; }
        public EspeciesTracosCulturaisVO TracoCultural { get; init; }

        public EspeciesVarianteDaEspecieVO? VarianteDaEspecie { get; init; }
        public EspeciesAncestralidadeVO? Ancestralidade { get; init; }
        public List<EspeciesRegrasEspeciaisVO>? RegrasEspeciais { get; init; }


        


    }
}
