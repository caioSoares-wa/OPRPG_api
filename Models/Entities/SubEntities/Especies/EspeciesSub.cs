using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Especies
{
    public record EspeciesSub
    {
        public string Nome { get; init; } = string.Empty;
        public string AjusteDeAtributo { get; init; } = string.Empty;
        public string Preconceito { get; init; } = string.Empty;
        public int PontosDeVidaBase { get; init; }
        public EspeciesTamanho Tamanho { get; init; }
        public string Peso { get; init; } = string.Empty;
        public float DeslocamentoMetros { get; init; }
        public float NadoMetros { get; init; }
        public TracosDaEspecie TracosDaEspecie { get; init; }
        public Dificuldades Dificuldades { get; init; }
        public TracoCultural TracoCultural { get; init; }

        public List<VarianteDaEspecie>? VarianteDaEspecie { get; init; }
        public string? Ancestralidade { get; init; }
        public RegrasEspeciais RegrasEspeciais { get; init; }

  
    }
}
