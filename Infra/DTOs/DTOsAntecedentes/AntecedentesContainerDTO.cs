using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTOsAntecedentes
{
    public class AntecedentesContainerDTO
    {
        public List<AntecedentesDTO> Antecedentes { get; set; } = new();
    }
}
