using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record ProfissoesVO
    {
        public ProfissoesEnum Profissao { get; init; }

        public List<PericiasVO> PericiasPermitidas { get; init; } = new List<PericiasVO>();
        public List<PericiasEnum> PericasEscolhidas = new List<PericiasEnum>();
        public string Equipamentos { get; init; }



        public ProfissoesVO(ProfissoesEnum profissaoEscolhida, List<PericiasEnum> periciasEscolhidas)
        {
            this.Profissao = profissaoEscolhida;

            DefinirProfissao(profissaoEscolhida);


        }

        private void DefinirProfissao(ProfissoesEnum profissoes) {

          


            
            
        }
    }
}
