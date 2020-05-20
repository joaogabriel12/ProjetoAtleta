using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;

        private double altura;

        private double peso;

        private int idade;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }
        public double Altura
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");

                }
                else
                {
                    this.altura = value;
                }
            }
            get { return this.altura; }
        }
        public double Peso
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");

                }
                else
                {
                    this.peso = value;
                }
            }
            get { return this.peso; }
        }
        public int Idade
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");

                }
                else
                {
                    this.idade = value;
                }
            }
            get { return this.idade; }
        }





        public double Calcularimc()
        {
            return this.peso / (this.altura * this.altura);
        }

    }
}
