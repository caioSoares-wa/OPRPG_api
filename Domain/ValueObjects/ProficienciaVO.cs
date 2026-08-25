using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class ProficienciaVO
    {

        public ProficienciaVO(int nivel)
        {
            this.Proficiencia = CalcularProficiencia(nivel);
        }

        public int Proficiencia { get; private set; }


        private int CalcularProficiencia (int nivel)
        {
            if (nivel > 0 && nivel <=4)
            {
                return 2;
            }else if (nivel > 4 && nivel <9)
            {
                return 3;
            }
            else if(nivel >=9 && nivel <13)
            {
                return 4;
            }else if(nivel >=13 && nivel < 17)
            {
                return 5;
            } else{
                return 6;
            }

            
        }

    }
}
