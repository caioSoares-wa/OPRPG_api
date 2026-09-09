using Domain.Enums;
using Domain.ValueObjects.AntecedentesVOs;
using Domain.ValueObjects.EspeciesVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using Domain.ValueObjects.ProfissoesVOs;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Domain.ValueObjects.PericiasVOs
{
    public record PericiasProficientesVO
    {

        public ProficienciaPericiasVO DoEstilo { get; init; }
        public ProficienciaPericiasVO DoAntedente { get; init; }
        public ProficienciaPericiasVO DaProfissao { get; init; }


        public PericiasProficientesVO(EstilosDeCombateEstilosVO estilo,AntecedentesVO antecedente,ProfissaoVO profissao)
        {
            List<PericiasEnum> TodasAsPericias = new List<PericiasEnum> {
                        PericiasEnum.ACROBACIA,
                        PericiasEnum.ATLETISMO,
                        PericiasEnum.ATUACAO,
                        PericiasEnum.ENGANACAO,
                        PericiasEnum.FURTIVIDADE,
                        PericiasEnum.HAKI,
                        PericiasEnum.HISTORIA,
                        PericiasEnum.INTIMIDACAO,
                        PericiasEnum.INTUICAO,
                        PericiasEnum.INVESTIGACAO,
                        PericiasEnum.MEDICINA,
                        PericiasEnum.NATUREZA,
                        PericiasEnum.PERCEPCAO,
                        PericiasEnum.PERSUASAO,
                        PericiasEnum.PRESTIDIGITACAO,
                        PericiasEnum.PROVOCACAO,
                        PericiasEnum.SOBRENATURAL,
                        PericiasEnum.SOBREVIVENCIA,
                        PericiasEnum.SORTE
            };


            if (estilo == null)
            {
                throw new ArgumentNullException(nameof(estilo), "Informe um Estilo de Combate.");

            }

            if (antecedente == null)
            {
                throw new ArgumentNullException(nameof(antecedente),"Informe um Antecedente");
            }

            if (profissao == null)
            {
                throw new ArgumentNullException(nameof(profissao),"Informe uma Profissão");
            }




            if (estilo.ProficienciaPericias.Opcoes == null)
            {
                DoEstilo = new ProficienciaPericiasVO {
                    Opcoes = TodasAsPericias,
                    Quantidade = estilo.ProficienciaPericias.Quantidade
                };
            }
            else
            {
                DoEstilo = new ProficienciaPericiasVO { 
                    Opcoes = estilo.ProficienciaPericias.Opcoes,
                    Quantidade = estilo.ProficienciaPericias.Quantidade
                };
            }



            DoAntedente = new ProficienciaPericiasVO {
                Opcoes = antecedente.PericiasOpcoes ,
                Quantidade = 1
            };

            DaProfissao = new ProficienciaPericiasVO {
                Opcoes = profissao.PericiasElegiveis,
                Quantidade = profissao.QuantidadeDeEscolhas

            };

        }
    }
}
