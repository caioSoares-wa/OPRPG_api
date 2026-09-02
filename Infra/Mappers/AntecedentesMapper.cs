using Domain.ValueObjects;
using Domain.ValueObjects.AntecedentesVO;
using Infra.DTOs.DTOsAntecedentes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappers
{
    public static class AntecedentesMapper
    {
        //pega o antecedentesVO que veio diretamente do JSON e retorna um antecetendesVO
        public static AntecedentesVO ToDomain(this AntecedentesDTO dto)
        {
            //pega as caracteristicas que veio do dto e coloca em um novo objeto que sera retornado pelo metodo
            return new AntecedentesVO
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                AtributoRecomendado = dto.AtributoRecomendado,
                PericiasOpcoes = dto.PericiasOpcoes,
                CaracteristicaEspecial = new CaracteristicasEspecialVO
                {
                    Nome = dto.Nome,
                    Descricao = dto.Descricao,

                }
            };  

        }
    }
}
