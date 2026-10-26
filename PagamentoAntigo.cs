using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Padrao
{
    public class PagamentoAntigo
    {
        public void RealizarPagamento(double quantia)
        {
            Console.WriteLine($"Pagamento de R${quantia:F2} realizado");
        }
    }
}
