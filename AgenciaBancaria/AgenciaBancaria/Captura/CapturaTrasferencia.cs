using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Captura
{
    public class CapturaTrasferencia
    {

        public double Valor { get;  set; }
        public string Origin { get;  set; }
        public string ContaDestino { get; set; }


        public void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite um valor!");
            this.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta de Destino!");
            this.ContaDestino = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta origem!");
            this.Origin = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
