using System;

public class Conta{
    public int numero;
    public string titular;
    public double saldo;
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("-------abrindo contas--------\n");
        Conta c = new Conta();
        
        c.numero = 1;
        c.titular = "victor";
        c.saldo = 700.00;
        
        if(c.saldo >= 100.00){
            c.saldo = c.saldo - 30.0;
        }
        
            Console.WriteLine("numero da conta: " + c.numero);
            Console.WriteLine("titular: " + c.titular);
            Console.WriteLine("saldo = " + c.saldo);
    }
}
