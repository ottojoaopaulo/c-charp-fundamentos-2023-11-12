using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Aluno
    {
        public double LogicaNota1 { get; set; }
        public double LogicaNota2 { get; set; }
        public double LogicaNota3 { get; set; }
        public double BancoDadosNota1 { get; set; }
        public double BancoDadosNota2 { get; set; }
        public double BancoDadosNota3 { get; set; }

        public double CalcularMediaLogica()
        {
            double mediaLogica = (LogicaNota1 + LogicaNota2 + LogicaNota3) / 3;

            return mediaLogica;
        }

        public double CalcularMediaBancoDados()
        {
            double mediaBanco = (BancoDadosNota1 + BancoDadosNota2 + BancoDadosNota3) / 3;

            return mediaBanco;
        }
        public string ObterStatusLogica()
        {
            double mediaLogica = CalcularMediaLogica();
            string classificacao = "";

            if (mediaLogica < 5)
            {
                classificacao = "reprovado";
            }
            else if (mediaLogica < 7)
            {
                classificacao = "Em Exame";
            }
            else 
            {
                classificacao = "Aprovado";
            }
            return classificacao;
        }
        public string ObterStatusBancoDados()
        {
            double mediaBanco = CalcularMediaBancoDados();
            string classificacao = "";

            if (mediaBanco < 5)
            {
                classificacao = "reprovado";
            }
            else if (mediaBanco < 7)
            {
                classificacao = "Em exame";
            }
            else
            {
                classificacao = "Aprovado";
            }
            return classificacao;
        }
        public string ObterStatus()
        {
            string statusLogica = ObterStatusLogica();
            string statusBancoDados = ObterStatusBancoDados();

            string status = "";
            if(statusLogica == "Aprovado" && statusBancoDados == "Aprovado")
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }
            return status;
        }

     }
}
