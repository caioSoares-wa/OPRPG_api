using Domain.ValueObjects.AntecedentesVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IAntecedentesRepository
    {
        Task<List<AntecedentesVO>> ObterTodosAntecedenteAsync();
    }
}
