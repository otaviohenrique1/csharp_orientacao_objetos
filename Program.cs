﻿// using bytebank;
using bytebank.Contas;
using bytebank.Titular;

class Program
{
  static void Main(string[] args)
  {
    // ContaCorrente contaCorrente = new ContaCorrente();
    // contaCorrente.Depositar(100);
    // if (contaCorrente.Sacar(100))
    // {
    //   Console.WriteLine(contaCorrente.getSaldo());
    // }
    // else {
    //   Console.WriteLine("Valor invalido");
    // }

    // ContaCorrente contaDaMaria = new ContaCorrente();
    // ContaCorrente contaDoAndre  = new ContaCorrente();

    // contaDoAndre.setTitular("André Silva");
    // contaDoAndre.setNumeroAgencia(15);
    // contaDoAndre.setConta("1010-X");
    // contaDoAndre.setSaldo(100);
    // Console.WriteLine("Saldo da conta do André = " + contaDoAndre.getSaldo());

    // contaDaMaria.setTitular("Maria Souza");
    // contaDaMaria.setNumeroAgencia(17);
    // contaDaMaria.setConta("1010-5");
    // contaDaMaria.setSaldo(350);
    // Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.getSaldo());

    // contaDoAndre.Transferir(50, contaDaMaria);

    // Console.WriteLine("Saldo da conta do André = " + contaDoAndre.getSaldo());
    // Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.getSaldo());

    // ContaCorrente contaDoPedro = new ContaCorrente();
    // contaDoPedro.setTitular("Pedro");
    // contaDoPedro.setNumeroAgencia(18);
    // contaDoPedro.setConta("1010-9");
    // contaDoPedro.setSaldo(0);
    // Console.WriteLine(contaDoPedro.getTitular());
    // Console.WriteLine(contaDoPedro.getNumeroAgencia());
    // Console.WriteLine(contaDoPedro.getConta());
    // Console.WriteLine(contaDoPedro.getSaldo());

    ContaCorrente contaDaMaria = new ContaCorrente();
    Cliente maria = new Cliente();
    maria.setNome("Maria Souza");
    maria.setCpf("3216549870");
    maria.setProfissao("Advogada");
    contaDaMaria.setTitular(maria);
    contaDaMaria.setNumeroAgencia(17);
    contaDaMaria.setConta("1010-X");
    contaDaMaria.setSaldo(350);
    Console.WriteLine(contaDaMaria.getSaldo());

    ContaCorrente contaDoAndre = new ContaCorrente();
    Cliente andre = new Cliente();
    andre.setNome("André Silva");
    andre.setCpf("0987654321");
    andre.setProfissao("Analista");
    contaDoAndre.setTitular(andre);
    contaDoAndre.setNumeroAgencia(18);
    contaDoAndre.setConta("1010-N");
    contaDoAndre.setSaldo(350);
    Console.WriteLine(contaDoAndre.getSaldo());

    // Console.WriteLine(maria.getNome());
    // Console.WriteLine(maria.getCpf());
    // Console.WriteLine(maria.getProfissao());
    // Console.WriteLine(contaDaMaria.getTitular().getNome());
    // Console.WriteLine(contaDaMaria.getTitular().getCpf());
    // Console.WriteLine(contaDaMaria.getTitular().getProfissao());
    // Console.WriteLine(contaDaMaria.getNumeroAgencia());
    // Console.WriteLine(contaDaMaria.getConta());
    // Console.WriteLine(contaDaMaria.getSaldo());
  }
}
