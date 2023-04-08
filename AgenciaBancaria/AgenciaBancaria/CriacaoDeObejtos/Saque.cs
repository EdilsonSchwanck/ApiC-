using AgenciaBancaria.Captura;
using AgenciaBancaria.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.CriacaoDeObejtos
{
    public class Saque
    {

        public void Sacar()
        {
            CapturaSaque caputura = new CapturaSaque();
            caputura.Captura();

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Sacar(caputura.Origin, caputura.Valor);
        }

    }
}
