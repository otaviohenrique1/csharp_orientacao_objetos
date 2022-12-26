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
    private int numero_agencia = 0;
    private string conta = "";
    private Cliente titular = new Cliente();
    private double saldo = 100;

    public void Depositar(double valor)
    {
      this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
      if (valor <= this.saldo)
      {
        this.saldo -= valor;
        return true;
      }
      else { 
        return false;
      }
    }

    public void setSaldo(double saldo)
    {
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
      else { 
        this.saldo -= valor;
        destino.saldo += valor;
        return true;
      }
    }
    
    public void setNumeroAgencia(int numero_agencia)
    {
      this.numero_agencia = numero_agencia;
    }

    public void setConta(string conta)
    {
      this.conta = conta;
    }

    public void setTitular(Cliente titular)
    {
      this.titular = titular;
    }

    public int getNumeroAgencia()
    {
      return this.numero_agencia;
    }

    public string getConta()
    {
      return this.conta;
    }

    public Cliente getTitular()
    {
      return this.titular;
    }
  }
}
