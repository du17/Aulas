using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Funcionario{

    public string nome, cpf;
    public int idade, numInc, hora, minuto;

    public Funcionario(string nome, string cpf, int idade, int numInc){

        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.numInc = numInc;
    }

    public void apresentacao(){

        Console.WriteLine("----------Bem-Vindo!!!----------\n");
        
        Console.WriteLine("----------Informações do Funcionario---------");
        Console.WriteLine("Nome: " + this.nome + "\n");
        Console.WriteLine("Idade: " + this.idade + "\n");
        Console.WriteLine("CPF: " + this.cpf + "\n");
        Console.WriteLine("Numero da Inscrição: " + this.numInc + "\n");

    }

    public void trabalhar(string funcao){

        Console.WriteLine("Trabalhando em " + funcao);

    }

    public void baterPonto(int hora, int minuto){

        this.hora = hora;
        this.minuto = minuto;

        Console.WriteLine("Ponto batido às: " + hora + ":" + minuto);

    }

}

public class Tarefa{

    public static void Main(){

        Console.Clear();//limpa a tela

        Console.WriteLine("\n");

        //entrada

        Funcionario funcionario1 = new Funcionario("Jussara", "45555555", 45, 45795);
        Funcionario funcionario2 = new Funcionario("Ulysses", "77777777", 22, 55454);

        //informações

        funcionario1.apresentacao();
        //string funcao = Console.ReadLine();
        funcionario1.trabalhar("desenvolvendo o retario");//(funcao)
        Console.WriteLine("\n");

        funcionario1.baterPonto(19, 12);

        Console.WriteLine("\n");

        funcionario2.apresentacao();

        funcionario2.trabalhar("fazendo nada");
        Console.WriteLine("\n");

        funcionario2.baterPonto(12, 00);

    }

}
