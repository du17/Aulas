using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//classe pessoa

public class Pessoa{

    public string nome, cpf;
    public int idade;

    public Pessoa(string nome, string cpf, int idade){

        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;

    }

    public void ler(){

        nome = Console.ReadLine();

    }

    public void imprimir(){

        Console.WriteLine("----------Informações do Cliente----------");
        Console.WriteLine("Nome: " + this.nome + "\n");
        Console.WriteLine("Idade: " + this.idade + "\n");
        Console.WriteLine("CPF: " + this.cpf + "\n");

    }

}

//principal

public class Teste{

    public static void Main(){

        Console.Clear();//limpa a tela

        Console.WriteLine("\n");

        Pessoa pessoa = new Pessoa();

        pessoa.imprimir();

        /*List<int> minhaLista = new List<int>();

        minhaLista.Add(10);
        minhaLista.Add(85);
        minhaLista.Add(30);

        Console.WriteLine("Elementos da lista: ");
        foreach(int i in minhaLista){

            Console.WriteLine(i);

        }

        Console.WriteLine("\n");

        List<int> numero = new List<int> {12, 36, 145, 58};

        Console.WriteLine("Elementos da lista antes da remoção: ");
        foreach(int i in numero){

            Console.WriteLine(i);

        }

        Console.WriteLine("\n");

        numero.Remove(145);

        Console.WriteLine("Elementos depois da remoção: ");

        foreach(int i in numero){

            Console.WriteLine(i);

        }*/

    }

}