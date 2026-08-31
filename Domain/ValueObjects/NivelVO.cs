using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record NivelVO
    {

        public int Nivel { get; init; } = 0;
        public bool EhNiveisEpicos { get; init; } = false;

        public NivelVO(int nivel, bool ehNiveisEpicos) {
            this.Nivel = VerificarNivel(nivel, ehNiveisEpicos);
            this.EhNiveisEpicos = ehNiveisEpicos;

        }


       private int VerificarNivel(int nivel,bool nivelEpicos)
        {

            if (nivel < 0)
            {
                throw new ArgumentException("O nível não pode ser menor do que 0");
            }else if (nivel > 20 )
            {
                if (!nivelEpicos)
                {
                    throw new ArgumentException("Nível maximo é 20 (Não usando mesa de: Níveis épicos)");
                }
            }

            return nivel;
        }

    }
}
