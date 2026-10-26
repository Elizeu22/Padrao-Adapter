using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Padrao
{
    public class PagamentoAdapter:IPagamento
    {
        private readonly PagamentoAntigo _pagamentoAntigo;

        public PagamentoAdapter(PagamentoAntigo pagamentoAntigo)
        {
            _pagamentoAntigo = pagamentoAntigo;
        }

        public void Pagar(decimal valor)
        {
            _pagamentoAntigo.RealizarPagamento(125.32);

        }



    }
}
