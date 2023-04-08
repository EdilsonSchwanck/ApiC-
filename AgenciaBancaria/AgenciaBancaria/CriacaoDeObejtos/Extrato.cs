using AgenciaBancaria.Captura;
using AgenciaBancaria.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.CriacaoDeObejtos
{
    public class Extrato
    {           

        public void ExtratoDaConta()
        {
            CapturaExtrato extrato = new CapturaExtrato();
            extrato.Captura();

            ContaBancaria conta = new ContaBancaria();
            conta.ImprimirExtrato(extrato.Origin);
        }

    }
}
