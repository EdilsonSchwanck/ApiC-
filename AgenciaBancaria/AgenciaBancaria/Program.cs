// See https://aka.ms/new-console-template for more information
using AgenciaBancaria.AtualizarCliente;
using AgenciaBancaria.Contas;
using AgenciaBancaria.CriacaoDeObejtos;
using AgenciaBancaria.EstruturaInicial;
using AgenciaBancaria.InterfaceOpcao;
using AgenciaBancaria.printListaCliete;
using AgenciaBancaria.Repository;
using System.Globalization;


BemVindo bemVindo = new BemVindo();
bemVindo.BemVindos();

InterfaceOpcao interfaceOpcao = new InterfaceOpcao();
interfaceOpcao.interfaceUser();

int _operator = Convert.ToInt32(Console.ReadLine());
while (_operator != 0)
{
    switch (_operator)
    {
        case 0:
            Environment.Exit(0);
        break;
        case 1:
            CriacaoCliente cliente = new CriacaoCliente();
            cliente.CiracaoCliente();
        break;
        case 2:
            PrintListCliente print = new PrintListCliente();
            print.PrintCliente();
    
        break;
        case 3:
            AtualizarCliente atualizarCliente = new AtualizarCliente();
            atualizarCliente.Atualizar();
           
        break;
        case 4:
            Console.WriteLine( );
            Console.WriteLine("Dige o Id para excluir a conta");
            var numeroConta = Convert.ToInt32(Console.ReadLine());
            ClienteRepository clienteDelete = new ClienteRepository();
            clienteDelete.DeletarCliente(numeroConta);
            

        break;
        case 5:
            Extrato extrato = new Extrato();
            extrato.ExtratoDaConta();

        break;

        case 8:
            Saque saque = new Saque();
            saque.Sacar();


       break;

        case 9:
            Transefrir trasferir = new Transefrir();
            trasferir.Transferencia();
      
            
        break;


    }

    interfaceOpcao.interfaceUser();


    _operator = Convert.ToInt32(Console.ReadLine());
}