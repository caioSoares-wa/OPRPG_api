using Domain.Enums;
using Domain.ValueObjects.AntecedentesVO;
using Domain.ValueObjects.AtributosVOs;
using Domain.ValueObjects.EspeciesVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using Domain.ValueObjects.NivelVOs;
using Domain.ValueObjects.PericiasVOs;
using Domain.ValueObjects.VidaVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Ficha
    {
        public string NomePersonagem { get; private set; } = string.Empty;
        public int Nivel { get;private set; }
        public VidaVO Vida { get; private set; }
        public int Proficiencia { get; private set; }

        public AntecedentesVO Antecedentes { get; private set; }

        public EspeciesVO Especies { get; private set; }
        public EstilosDeCombateVO Estilo { get; private set; }
        public ProfissoesVO Profissoes { get; private set; }

        public ConjuntoAtributosVO Atributos { get; private set; }

        public ConjuntoPericiasVO Pericias { get;private set; }



        public  Ficha(string nome,int nivel, ConjuntoAtributosVO Atributos , AntecedentesVO antecedentes, EspeciesVO especies, EstilosDeCombateVO estilo, IEnumerable<PericiasEnum> periciasProficientes)
        {
            this.NomePersonagem = VerificarNome(nome);
            this.Nivel = VerificarNivel(nivel);
            this.Proficiencia = VerificarProficiencia(nivel);

            this.Antecedentes = antecedentes;
            this.Especies = especies;
            this.Estilo = estilo;
            this.Atributos = Atributos;


            periciasProficientes = VerificarPericias(Estilo,Especies,antecedentes,Profissoes) ;



            this.Pericias = new ConjuntoPericiasVO(Atributos,periciasProficientes);
        }



        private string VerificarNome(string nome)
        {

            return nome;
        }

        private int ImplementarVida(int vida)
        {

            return vida;
        }


        private int VerificarNivel(int nivel)
        {
            if (nivel > 30)
            {
                return 30;
            }
            else if (nivel <= 0)
            {
                return 1;
            }
            else
            {
                return nivel;
            }
        }

        private int VerificarProficiencia(int nivel)
        {
            if (nivel <= 4 )
            {
                return 2;
            }else if (nivel >4 && nivel <= 8)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }



        private IEnumerable<PericiasEnum> VerificarPericias()
        {



        }
    }
}
