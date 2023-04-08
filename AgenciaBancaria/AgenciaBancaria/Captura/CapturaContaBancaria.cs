using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Captura
{
    public class CapturaContaBancaria
    {
        public string Numero { get; private set; }
        public double Saldo { get; private set; }


        public void capturaConta()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o Numero da conta desejada!");
            this.Numero = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o Deposito da sua conta!");
            this.Saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();



        }




    }

}
