using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Especies
{
    public  record TracosDaEspecie
    {
        public List<TracoBeneficios> Beneficios { get; init; }
    }
}
