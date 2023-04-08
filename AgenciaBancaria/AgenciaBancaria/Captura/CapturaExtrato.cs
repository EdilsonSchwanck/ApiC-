using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Captura
{
    public class CapturaExtrato : CapturaSaque
    {
        public new void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta ");
            this.Origin = Console.ReadLine();
        }

    }
}
