using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Ficha
    {
        public string NomePersonagem { get; private set; } = string.Empty;
        public int Vida { get; private set; }
        public int Proficiencia { get; private set; }

        public AntecedentesVO Antecedentes { get; private set; }

        public EspeciesVO EspeciesVO { get; private set }


        public  Ficha(string nome,int vida, AntecedentesVO antecedentes)
        {
            this.NomePersonagem = VerificarNome(nome);
            this.Vida = ImplementarVida(vida);
            this.Antecedentes = antecedentes;


        }



        private string VerificarNome(string nome)
        {

            return nome;
        }

        private int ImplementarVida(int vida)
        {

            return vida;
        }



    }
}
