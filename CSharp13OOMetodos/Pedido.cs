using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Pedido
    {
        public string Nome { get; set; }

        public int Quantidade { get; set;}

        public double PrecoUnitario { get; set;}

        public void CalcularTotalPedido()
        {
             double total = quantidade * PrecoUnitario;

             return total;
        }
    }
}
