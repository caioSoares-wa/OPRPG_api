using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public class EspeciesDTO
    {
        public string Nome { get; init; } = string.Empty;
        public string AjusteDeAtributo { get; init; } = string.Empty;
        public string Preconceito { get; init; } = string.Empty;
        public int PontosDeVidaBase { get; init; }

        public EspeciesTamanhoDTO Tamanho { get; init; }
        public EspeciesPesoDTO Peso { get; init; }
        public float DeslocamentoMetros { get; init; }
        public float NadoMetros { get; init; }
        public EspeciesTracosDaEspecieDTO TracosDaEspecie { get; init; }
        public EspeciesTracosCulturaisDTO TracoCultural { get; init; }

        public EspeciesVarianteDaEspecieDTO? VarianteDaEspecie { get; init; }
        public EspeciesAncestralidadeDTO? Ancestralidade { get; init; }
        public List<EspeciesRegrasEspeciaisDTO>? RegrasEspeciais { get; init; }
    }
}
