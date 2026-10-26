using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Padrao
{
    public interface IPagamento
    {
        void Pagar(decimal valor);
    }
}
