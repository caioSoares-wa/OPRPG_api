using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.EspeciesDTOs
{
    public  record TracosDaEspecie
    {
        public List<TracoBeneficios> Beneficios { get; init; }
    }
}
