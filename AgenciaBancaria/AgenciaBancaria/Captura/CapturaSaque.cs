using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Captura
{
    public class CapturaSaque : CapturaTrasferencia
    {

        public new void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite um valor!");
            this.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta origem!");
            this.Origin = Console.ReadLine();
        }


    }
}
