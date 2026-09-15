using Models.Entities.SubEntities.Antecedentes;
using Models.Entities.SubEntities.Especies;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Ficha
    {

        public string NomePersonagem { get; private set; } = string.Empty;
        public int Nivel { get; private set; }
        public int Vida { get; private set; }
        public int Proficiencia { get; private set; }

        public AntecedentesSub Antecedentes { get; private set; }

        public EspeciesSub Especies { get; private set; }
        public EstilosDeCombateEstilosSub Estilo { get; private set; }
        public ProfissaoVO Profissao { get; private set; }

        public ConjuntoAtributosVO Atributos { get; private set; }

        public ConjuntoPericiasVO Pericias { get; private set; }



        public List<PericiasEnum> PericiasEscolhidas { get; private set; }



        public Ficha(
            string nome,
            int nivel,
            ConjuntoAtributosSub atributos,
            ProfissaoVO profissao,
            AntecedentesVO antecedentes,
            EspeciesSub especies,
            EstilosDeCombateEstilosVO estilo,
            List<PericiasEnum> periciasEscolhidasDoEstilo,
            List<PericiasEnum> periciasEscolhidasDaProfissao,
            PericiasEnum periciaEscolhidaDoAntecedente

            )
        {
            this.NomePersonagem = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Nivel = VerificarNivel(nivel);
            this.Proficiencia = VerificarProficiencia(nivel);
            this.Atributos = atributos ?? throw new ArgumentNullException(nameof(Atributos));

            this.Estilo = estilo ?? throw new ArgumentNullException(nameof(estilo));
            this.Especies = especies ?? throw new ArgumentNullException(nameof(especies));
            this.Antecedentes = antecedentes ?? throw new ArgumentNullException(nameof(antecedentes));
            this.Profissao = profissao ?? throw new ArgumentNullException(nameof(profissao));

            this.Vida = VidaVO.CriarNivel1(Estilo, Especies, Atributos);

            var periciasCOnt = new PericiasProficientesVO(Estilo, Antecedentes, Profissao);

            ProficienciaDoEstiloDeCombate = periciasCOnt.DoEstilo;
            ProficienciaDoAntecedente = periciasCOnt.DoAntedente;
            ProficienciaDaProfissao = periciasCOnt.DaProfissao;


            PericiasEscolhidas = VerificarProficienciaDasPericias(periciasEscolhidasDaProfissao, periciaEscolhidaDoAntecedente, periciasEscolhidasDoEstilo);

            this.Pericias = new ConjuntoPericiasVO(Atributos, PericiasEscolhidas);


        }


        public void SubirNivel(bool ehRolagem, int novoNivel, int conModNoNivelAlvo)
        {
            if (novoNivel <= Nivel)
            {
                throw new Exception("Nivel Deve ser maior que o atual");
            }

            if (novoNivel < 1)
            {
                throw new Exception("Novo Nivel deve ser maior que 0");
            }

            Vida = Vida.SubirNivel(ehRolagem, novoNivel, conModNoNivelAlvo);
            Nivel = novoNivel;
            Proficiencia = VerificarProficiencia(novoNivel);
        }
        public void AtualizarAtributos(ConjuntoAtributosVO novosAtributos, int conModNoNivelAlvo)
        {
            Atributos = novosAtributos;

            var novaVida = VidaVO.CriarNivel1(Estilo, Especies, Atributos);

            for (int nv = 2; nv <= Nivel; nv++)
            {
                novaVida = novaVida.SubirNivel(false, nv, conModNoNivelAlvo);
            }


            Vida = novaVida;
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
            if (nivel <= 4)
            {
                return 2;
            }
            else if (nivel > 4 && nivel <= 8)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }



        public List<PericiasEnum> VerificarProficienciaDasPericias(List<PericiasEnum> profissao, PericiasEnum antecedente, List<PericiasEnum> estilo)
        {

            var listaAprovada = new List<PericiasEnum>();

            int quantidadeEscolhidaProfissao = 0;
            int quantidadeEscolhidaEstilo = 0;

            foreach (var i in profissao)
            {
                if (ProficienciaDaProfissao.Opcoes.Contains(i))
                {
                    if (!listaAprovada.Contains(i))
                    {
                        listaAprovada.Add(i);

                        quantidadeEscolhidaProfissao++;
                    }

                }


            }

            foreach (var i in estilo)
            {
                if (ProficienciaDoEstiloDeCombate.Opcoes.Contains(i))
                {
                    if (!listaAprovada.Contains(i))
                    {
                        listaAprovada.Add(i);

                        quantidadeEscolhidaEstilo++;
                    }

                }


            }

            if (listaAprovada.Contains(antecedente))
            {
                throw new Exception($"Pericia {antecedente} já escolhida");
            }
            else
            {
                listaAprovada.Add(antecedente);
            }



            this.QuantidadeDePericiasEscolhidasEstiloDeCombate = quantidadeEscolhidaEstilo;
            this.QuantidadeDePericiasEscolhidasProfissao = quantidadeEscolhidaProfissao;

            return listaAprovada;

        }

    }
}
