using Domain.Interfaces;
using Domain.ValueObjects.AntecedentesVO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases
{
    public class ObterTodosAntecedentesUseCase
    {
        //guardamos nossa interface do repositorio
        private readonly IAntecedentesRepository _repository;

        //pedindo a interface no construtor do use case
        public ObterTodosAntecedentesUseCase(IAntecedentesRepository repository)
        {
            _repository = repository;
        }

        //Metodo que a api vai chamar
        public async Task<List<AntecedentesVO>> ExecutarAsync()
        {
            //pede ao repositorio os dados
            List<AntecedentesVO> antecedentes = await _repository.ObterTodosAntecedenteAsync();

            //ordernar por ordem alfabetica
            var antecedenteOrdenados = antecedentes.OrderBy(a => a.Nome).ToList();

            //retornamos os dados prontos
            return antecedenteOrdenados;
        }
    }
}
