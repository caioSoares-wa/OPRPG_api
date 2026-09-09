using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTOsConjuntoAtributos
{
    public class AtributosDTO
    {
        public AtributosEnum Nome { get; init; }
        public int ValorBase { get; init; }
        public int Modificador { get; init; }


    }
}
