using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Ficha
    {
        public string NomePersonagem { get; set; } = string.Empty;
        public NivelVO Nivel { get; set; }
        
        public ProficienciaVO Proficiencia { get; set; }
        public EspeciesVO Especie { get; set; }
        public AntecedentesVO Antecedentes { get; set; }
        public AkumaNoMiVO AkumaNoMi { get; set; }
        public ProfissoesVO Profissoes { get; set; }
        public DeslocamentoVO Deslocamento { get; set; }
        public int Vida { get; set; }
        public EstiloDeCombateVO Estilo { get; set; }
        public ClasseDeResistenciaVO ClasseDeResistencia { get; set; }
        public ClasseDeDificuldadeVO ClasseDeDificuldade { get; set; }

        public int PontosDePoder { get; set; }


        public AtributosVO Atributos { get; set; }
        public PericiasVO Pericias { get; set; }
        


        private Ficha(int nivel, bool mesaComNiveisEpicos, AtributosVO atr, EstiloDeCombateVO estilo)
        {
            this.Nivel = ImplementarNivel(nivel, mesaComNiveisEpicos);
            this.Proficiencia = ImplementarProficiencia(this.Nivel);


            Estilo = ImplementarEstilo(estilo);

            Atributos = CalcularAtributos(atr);

            Pericias = CalcularPericias();
            CalcularVida();
            CalcularClasseDeDificuldade();
            CalcularClasseDeResistencia();
            

        }

        private EstiloDeCombateVO ImplementarEstilo(EstiloDeCombateVO estilo, List<PericiasEnum> periciasEscolhidas)
        {
            if (periciasEscolhidas.Count() >=3 || periciasEscolhidas )
            {

            }

            var estiloFeito = new EstiloDeCombateVO();
            return estiloFeito;
        }

        private NivelVO ImplementarNivel(int nivel, bool ehMesaComNiveisEpicos)
        {
            var nivelTotal = new NivelVO(nivel, ehMesaComNiveisEpicos);
            return nivelTotal;
        }

        private ProficienciaVO ImplementarProficiencia(NivelVO nivel)
        {
            var proficiencia = new ProficienciaVO(nivel.Nivel);

            return proficiencia;

        }
        private AtributosVO CalcularAtributos(AtributosVO atr)
        {
            var atributos = new AtributosVO(atr.Forca, atr.Destreza,atr.Constituicao,atr.Sabedoria, atr.Presenca, atr.Vontade);

            return atributos;
        }

        private PericiasVO CalcularPericias()
        {

            return new PericiasVO();
        }


        private int CalcularVida()
        {
            return 0;
        }

        private int CalcularClasseDeResistencia()
        {
            return 0;
        }
        private int CalcularClasseDeDificuldade()
        {
            return 0;
        }


    }
}
