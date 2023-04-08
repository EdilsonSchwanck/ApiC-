using AgenciaBancaria.Cliete;
using AgenciaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgenciaBancaria.Contas
{
    public  class ContaBancaria
    {
        private static int generateNumber = 1;

        public int Id { get; private set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Cliente { get; set; }



        public ContaBancaria()
        {
        }


        public ContaBancaria(string numero, double saldo)
        {
            this.Id = generateNumber;
            generateNumber++;

            this.Numero = numero;
            this.Saldo = saldo;

        }


        public virtual void ImprimirExtrato()
        {
            Console.WriteLine("Extrato da Conta " + Numero + " - " + Cliente.Nome);
            Console.WriteLine("Saldo: R$ " + Saldo);
        }

        public void ImprimirExtrato(string numeroConta)
        {
            var conta = new ContaBancariaRepository().GetContasBancarias().FirstOrDefault(c => c.Numero == numeroConta);

            if (conta != null)
            {
                if (conta.Cliente != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Extrato da Conta " + conta.Numero + " - " + conta.Saldo);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Conta bancária não possui cliente associado.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Conta bancária não encontrada.");
            }
        }


    }

}

