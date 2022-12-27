using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
  public class ContaCorrente
  {
    public static int TotalDeContasCriadas { get; set; }
    private int numero_agencia;
    public int Numero_Agencia
    {
      get { return this.numero_agencia; }
      private set
      {
        if (value > 0)
        {
          this.numero_agencia = value;
        }
      }
    }

    // private string conta = "";
    // Propriedades autoimplementadas
    public string Conta { get; set; }

    // private Cliente titular = new Cliente();

    public Cliente Titular { get; set; }

    private double saldo = 100;

    public void Depositar(double valor)
    {
      if (valor < 0)
      {
        return;
      }
      this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
      if (valor <= this.saldo)
      {
        this.saldo -= valor;
        return true;
      }
      else
      {
        return false;
      }
    }

    public void setSaldo(double saldo)
    {
      if (saldo < 0)
      {
        return;
      }
      this.saldo = saldo;
    }

    public double getSaldo()
    {
      return this.saldo;
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
      if (this.saldo < valor)
      {
        return false;
      }
      else
      {
        this.saldo -= valor;
        destino.saldo += valor;
        return true;
      }
    }

    // public void setConta(string conta)
    // {
    //   this.conta = conta;
    // }

    // public void setTitular(Cliente titular)
    // {
    //   this.titular = titular;
    // }

    // public string getConta()
    // {
    //   return this.conta;
    // }

    // public Cliente getTitular()
    // {
    //   return this.titular;
    // }

    public ContaCorrente(double saldo, string Conta/* , int Numero_Agencia, Cliente Titular */) {
      this.saldo = saldo;
      this.Conta = Conta;
      TotalDeContasCriadas++;
      // this.numero_agencia = Numero_Agencia;
      // this.Titular = Titular;
    }

    // Método construtor padrão
    // public ContaCorrente() {}
  }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
  public class ContaCorrente
  {
    private int numero_agencia;
    public int Numero_Agencia
    {
      get { return this.numero_agencia; }
      set
      {
        if (value > 0)
        {
          this.numero_agencia = value;
        }
      }
    }

    // private string conta = "";
    // Propriedades autoimplementadas
    public string Conta { get; set; }

    // private Cliente titular = new Cliente();

    public Cliente Titular { get; set; }

    private double saldo = 100;


    public void Depositar(double valor)
    {
      if (valor < 0)
      {
        return;
      }
      this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
      if (valor <= this.saldo)
      {
        this.saldo -= valor;
        return true;
      }
      else
      {
        return false;
      }
    }

    public void setSaldo(double saldo)
    {
      if (saldo < 0)
      {
        return;
      }
      this.saldo = saldo;
    }

    public double getSaldo()
    {
      return this.saldo;
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
      if (this.saldo < valor)
      {
        return false;
      }
      else
      {
        this.saldo -= valor;
        destino.saldo += valor;
        return true;
      }
    }

    // public void setConta(string conta)
    // {
    //   this.conta = conta;
    // }

    // public void setTitular(Cliente titular)
    // {
    //   this.titular = titular;
    // }

    // public string getConta()
    // {
    //   return this.conta;
    // }

    // public Cliente getTitular()
    // {
    //   return this.titular;
    // }

    public ContaCorrente(double saldo, string Conta) {
      this.saldo = saldo;
      this.Conta = Conta;
    }
  }
}
*/