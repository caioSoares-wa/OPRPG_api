using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public class EspeciesContainerDTO
    {
        public List<EspeciesDTO> Especies { get; set; } = new();
    }
}
