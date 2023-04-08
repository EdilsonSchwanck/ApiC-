using AgenciaBancaria.Captura;
using AgenciaBancaria.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.CriacaoDeObejtos
{
    public class Transefrir
    {
        public void Transferencia()
        {
            CapturaTrasferencia captura = new CapturaTrasferencia();
            captura.Captura();

            ContaCorrente conta = new ContaCorrente();
            conta.Transferir(captura.Valor, captura.ContaDestino, captura.Origin);

        }
    }
}
