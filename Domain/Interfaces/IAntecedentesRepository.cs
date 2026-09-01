using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IAntecedentesRepository
    {
        Task<List<AntecedentesVO>> ObterTodosAsync();
    }
}
