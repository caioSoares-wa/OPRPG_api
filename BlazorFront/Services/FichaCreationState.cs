using System.Collections.Generic;
using Domain.Enums;
using Domain.ValueObjects.AtributosVOs;
using Domain.ValueObjects.EspeciesVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using Domain.ValueObjects.AntecedentesVOs;

namespace BlazorFront.Services
{
    public class FichaCreationState
    {
        // Step 1: Basic Info
        public string NomePersonagem { get; set; } = string.Empty;
        public int Nivel { get; set; } = 1;
        public ConjuntoAtributosVO Atributos { get; set; } = new(10, 10, 10, 10, 10, 10);
        
        // Step 2: Class/Species/Background
        public EstilosDeCombateEstilosVO? EstiloSelecionado { get; set; }
        public EspeciesVO? EspecieSelecionada { get; set; }
        public AntecedentesVO? AntecedenteSelecionado { get; set; }
        
        // Step 3: Skills & Extras
        public List<PericiasEnum> PericiasTreinadas { get; set; } = new();
        public bool TemHaki { get; set; }
        public bool TemAkumaNoMi { get; set; }
        public string AkumaNoMiNome { get; set; } = string.Empty;
        public List<string> Equipamentos { get; set; } = new();
        public string EquipamentosText { get; set; } = string.Empty;
        
        // Metadata
        public int CurrentStep { get; set; } = 1;
        public bool IsCompleted { get; set; } = false;
        
        // Catalog data (loaded from API)
        public List<EstilosDeCombateEstilosVO> EstilosDisponiveis { get; set; } = new();
        public List<EspeciesVO> EspeciesDisponiveis { get; set; } = new();
        public List<AntecedentesVO> AntecedentesDisponiveis { get; set; } = new();
        
        public void Reset()
        {
            NomePersonagem = string.Empty;
            Nivel = 1;
            Atributos = new(10, 10, 10, 10, 10, 10);
            EstiloSelecionado = null;
            EspecieSelecionada = null;
            AntecedenteSelecionado = null;
            PericiasTreinadas.Clear();
            TemHaki = false;
            TemAkumaNoMi = false;
            AkumaNoMiNome = string.Empty;
            Equipamentos.Clear();
            EquipamentosText = string.Empty;
            CurrentStep = 1;
            IsCompleted = false;
        }
        
        public bool CanProceedStep1()
        {
            return !string.IsNullOrWhiteSpace(NomePersonagem) 
                && Nivel >= 1 && Nivel <= 30
                && Atributos != null;
        }
        
        public bool CanProceedStep2()
        {
            return EstiloSelecionado != null 
                && EspecieSelecionada != null 
                && AntecedenteSelecionado != null;
        }
    }
}