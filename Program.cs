using bytebank;

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

    ContaCorrente contaDaMaria = new ContaCorrente();
    ContaCorrente contaDoAndre  = new ContaCorrente();

    contaDoAndre.setTitular("André Silva");
    contaDoAndre.setNumeroAgencia(15);
    contaDoAndre.setConta("1010-X");
    contaDoAndre.setSaldo(100);
    Console.WriteLine("Saldo da conta do André = " + contaDoAndre.getSaldo());

    contaDaMaria.setTitular("Maria Souza");
    contaDaMaria.setNumeroAgencia(17);
    contaDaMaria.setConta("1010-5");
    contaDaMaria.setSaldo(350);
    Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.getSaldo());

    contaDoAndre.Transferir(50, contaDaMaria);

    Console.WriteLine("Saldo da conta do André = " + contaDoAndre.getSaldo());
    Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.getSaldo());

    ContaCorrente contaDoPedro = new ContaCorrente();
    contaDoPedro.setTitular("Pedro");
    contaDoPedro.setNumeroAgencia(18);
    contaDoPedro.setConta("1010-9");
    contaDoPedro.setSaldo(0);
    Console.WriteLine(contaDoPedro.getTitular());
    Console.WriteLine(contaDoPedro.getNumeroAgencia());
    Console.WriteLine(contaDoPedro.getConta());
    Console.WriteLine(contaDoPedro.getSaldo());
  }
}
