using AgenciaBancaria.Cliete;
using AgenciaBancaria.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Repository
{
    public class ContaBancariaRepository
    {
        public static List<ContaBancaria> contasBancarias = new List<ContaBancaria>();

        public void AddContaBancaria(ContaBancaria conta)
        {
            contasBancarias.Add(conta);
        }

        public ContaBancaria ProcurarContaBancaria(string numeroConta)
        {
            return contasBancarias.FirstOrDefault(conta => conta.Numero== numeroConta);
        }

        public List<ContaBancaria> GetContasBancarias()
        {
            return contasBancarias;
        }

    }
}
