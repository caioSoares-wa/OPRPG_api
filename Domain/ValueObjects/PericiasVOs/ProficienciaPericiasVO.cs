using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.PericiasVOs
{
    public  record ProficienciaPericiasVO
    {

        public int Quantidade { get; init; }
        public List<PericiasEnum>? Opcoes { get; init; }

    }
}
