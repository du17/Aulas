using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Conta{
    public int numero;
    public string titular;
    public double saldo;
    
    public Conta(double saldo){
        this.saldo = saldo;
    }
    
    public bool saca(double valor){
        if(this.saldo >= valor){
            this.saldo -= valor;
            return true;
        }
        return false;
    }
    
    public bool deposito(double valor){
        if(this.saldo >= 0.50){
            this.saldo += valor;
            return true;
        }
        return false;
    }
    
    public void transfere(double valor, Conta destino){
        if(saca(valor)){
            destino.deposito(valor);
        }
        Console.WriteLine(valor);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------abrindo contas--------\n");
        
        Conta c = new Conta(700.00);
        Conta c2 = new Conta(800.00);
        
        c.numero = 1;
        c.titular = "victor";
        
        c.deposito(250);
        c.saca(45);
        
        c.transfere(100, c2);
        
            Console.WriteLine("numero da conta: " + c.numero);
            Console.WriteLine("titular: " + c.titular);
            Console.WriteLine("saldo = " + c.saldo);
            
            Console.WriteLine("saldo = " + c2.saldo);
    }
}
