using Domain.ValueObjects.EspeciesVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IEspeciesRepository
    {
        public Task<List<EspeciesVO>> ObterTodasEspeciesAsync();
    }
}
