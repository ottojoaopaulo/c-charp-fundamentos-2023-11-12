using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Pedido
    {
        //propriedades do Pedido
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        //Metodo para calcular o total do pedido, desta forma centralizando o calculo da quantidade * preco

        public double CalcularTotalPedido()
        {
            double total = Quantidade * PrecoUnitario;

            //Retorna o valor calculado do total, para que seja possivel obter
            //o valor calculado por quem chama esse metodo
            return total;
        }

       
    }

}
