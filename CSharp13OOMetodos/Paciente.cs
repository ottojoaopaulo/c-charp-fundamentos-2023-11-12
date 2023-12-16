using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    //classe
    internal class Paciente
    {
        //Propriedades
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }
        
        //Metodo com retorno tipo double, sem retorno é tipo void
        public double CalcularImc()
        {
            double imc = Peso / (Altura * Altura);

            return imc;
        }
        public string ObterClassificacaoImc()
        {
            double imc = CalcularImc();

            string classificacao = "";

            if (imc < 18.5)
            {
                classificacao = "Baixo Peso";
            }
            else if (imc < 25)
            {
                classificacao = "Peso Normal";
            }
            else if (imc < 30)
            {
                classificacao = "Excesso de Peso";
            }
            else if (imc < 35)
            {
                classificacao = "Obesidade";
            }
            else
            {
                classificacao = "Obesidade extrema";
            }
            return classificacao;
        }

        public string ObterClassificacaoGeracao()
        {
            int anoNascimento = 2023 - Idade;
            string geracao = "";

            if (anoNascimento < 1960)
            {
                geracao = "baby boomers";
            }
            else if (anoNascimento < 1980)
            {
                geracao = "Geracao X";
            }
            else if (anoNascimento < 1995)
            {
                geracao = "Geracao Y";
            }
            else if (anoNascimento < 2010)
            {
                geracao = "Geracao Z";
            }
            else
            {
                geracao = "Geracao Alpha";
            }
            return geracao;
        }
    }
}
