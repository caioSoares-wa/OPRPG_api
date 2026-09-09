using Domain.Enums;
using System;

namespace Domain.ValueObjects.PericiasVOs
{
    public record PericiasVO
    {
        public PericiasEnum Pericia { get; init; }
        public AtributosEnum AtributoUtilizado { get; init; }
        public int ModificadorAtributo { get; init; }
        public int Total { get; init; }
        public int? OutrosBonus { get; init; }
        public bool EhProficiente { get; init; }

        public PericiasVO(PericiasEnum pericia, AtributosEnum atributoUtilizado, int modificadorDoAtributo, int? outrosBonus, bool proficiente)
        {
            this.Pericia = pericia;
            this.AtributoUtilizado = atributoUtilizado;
            this.OutrosBonus = outrosBonus;
            this.EhProficiente = proficiente;
            this.ModificadorAtributo = modificadorDoAtributo;
        }

        public PericiasVO AlterarProficiencia()
        {
            return new PericiasVO(Pericia, AtributoUtilizado, ModificadorAtributo, OutrosBonus, true);
        }

        // Helper para obter o nome em string se necessário (ex.: serialização)
        public string ObterNome() => Pericia.ToString();
    }
}