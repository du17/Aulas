using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Funcionario{

    public string nome, cpf;
    public int idade, numInc, hora;
    public bool ponto;

    public Funcionario(string nome, string cpf, int idade, int numInc, int hora, bool ponto){

        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.numInc = numInc;
        this.hora = hora;
        this.ponto = ponto;
    }

    public void mostrarInformacoes(){
        
        Console.WriteLine("----------Informações do Funcionario---------");
        Console.WriteLine("Nome: " + this.nome + "\n");
        Console.WriteLine("Idade: " + this.idade + "\n");
        Console.WriteLine("CPF: " + this.cpf + "\n");
        Console.WriteLine("Numero da Inscrição: " + this.numInc + "\n");

    }

    public void apresentacao(){

        Console.WriteLine("----------Bem-Vindo!!!----------");

    }

    public void trabalhar(){

        this.hora = hora + 2;

            if(hora <= 9){

                Console.WriteLine("Horario: " + this.hora + " -> Hora de Trabalhar!!");

            }

            if(hora >= 18){

                 Console.WriteLine("Horario: " + this.hora + " -> Passou da hora do expediente!!!");

            }

    }

    public void baterPonto(){

        if(ponto == true){

            Console.WriteLine("\nBateu o ponto");

        }

        else{

            Console.WriteLine("\nNão bateu o ponto");

        }

    }

}

public class Tarefa{

    public static void Main(){

        Console.Clear();//limpa a tela

        Console.WriteLine("\n");

        //entrada

        Funcionario funcionario1 = new Funcionario("Jussara", "45555555", 45, 45795, 7, false);
        Funcionario funcionario2 = new Funcionario("Ulysses", "77777777", 22, 55454, 18, true);

        //informações

        funcionario1.apresentacao();
        Console.WriteLine("\n");

        funcionario1.mostrarInformacoes();
        funcionario1.trabalhar();

        funcionario1.baterPonto();

        Console.WriteLine("\n");

        funcionario2.apresentacao();
        Console.WriteLine("\n");

        funcionario2.mostrarInformacoes();
        funcionario2.trabalhar();

        funcionario2.baterPonto();

    }

}