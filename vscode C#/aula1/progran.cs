// dia 08/01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Carro{

    public string modelo;
    public int ano, velocidade;

    //jeito 2
    public Carro(string modelo, int ano){

        this.modelo = modelo;
        this.ano = ano;
    }

    public void mostrarInformacoes(){
        
        Console.WriteLine("----------Informações do carro---------");
        Console.WriteLine("Carro modelo: " + this.modelo);
        Console.WriteLine("Ano: " + this.ano);

    }

    public void Ligar(){
        Console.WriteLine("ligando o carro");
        Console.WriteLine("vrumm");
    }

    public void Acelerar(){
        this.velocidade = this.velocidade + 10;
        Console.WriteLine("Acelerando...." + this.velocidade + "Kh/h");

        if(this.velocidade >= 100){
            Console.WriteLine("cuidado!!! velocidade acima do normal");
        }
    }

}

public class Pessoa{

    public string nome, profissao;
    public int idade;

    public Pessoa(string nome, int idade, string profissao){

        this.nome = nome;
        this.idade = idade;
        this.profissao = profissao;
    }   
}

public class HelloWord{

    public static void Main(){

        /*string nome = "gabriel";
        string sobrenome = " mesquita";
        //string complemento = nome + sobrenome; tambem funciona
        string usuarioNome;
        string usuarioSobrenome;
        int idade = 28;

        Console.WriteLine(nome + sobrenome);
        Console.WriteLine(idade);

        Console.WriteLine("\nDigite seu nome: ");
        usuarioNome = Console.ReadLine();

        Console.WriteLine("\nsobrenome: ");
        usuarioSobrenome = Console.ReadLine();

        Console.WriteLine(usuarioNome + " " + usuarioSobrenome);*/

        /*string[] carros = {"volvo", "bmw", "ford", "mazda"};

        for(int i = 0; i < carros.Length; i++){
            
            Console.WriteLine(carros[i]);
        }*/

        //Console.WriteLine(carros.Length); -> tamanho do vetor

        // dia 09/01

        /*List<int> minhaLista = new List<int> {13, 20, 30, 40, 50 };

        Console.WriteLine("elementos da lista antes da remoção: ");
        foreach(int item in minhaLista){
            Console.WriteLine(item);
        }

        minhaLista.Remove(30);

        Console.WriteLine("\nelementos da lista depois da remoção: ");
        foreach(int item in minhaLista){
            Console.WriteLine(item);
        }*/


        Console.Clear();//limpa a tela

        Console.WriteLine("\n");

        //jeito 2 construtor

        Carro meuCarro = new Carro("fusca", 1979);
        Carro meuCarro2 = new Carro("sedan", 2020);

        //jeito 3

        meuCarro.mostrarInformacoes();
        Console.WriteLine("\n");
        meuCarro2.mostrarInformacoes();

        meuCarro.Ligar();
        meuCarro.Acelerar();


        /*Console.WriteLine("Modelo: " + meuCarro2.modelo);
        Console.WriteLine("Ano: {0}", meuCarro2.ano);

        Console.WriteLine("\n");

        /*Pessoa pessoa1 = new Pessoa("joao", 15, "eletricista");
        Pessoa pessoa2 = new Pessoa("ana", 53, "secretaria");
        Pessoa pessoa3 = new Pessoa("carlos", 30, "couth");

        //jeito 1

        /*pessoa1.nome = "joao";
        pessoa1.idade = 15;

        pessoa2.nome = "ana";
        pessoa2.idade = 53;

        pessoa3.nome = "carlos";
        pessoa3.idade = 30;*/

        /*Console.WriteLine(" nome: " + pessoa1.nome + "\n idade: " + pessoa1.idade + "\n profissão: " + pessoa1.profissao + "\n");
        Console.WriteLine(" nome: " + pessoa2.nome + "\n idade: " + pessoa2.idade + "\n profissão: " + pessoa2.profissao + "\n");
        Console.WriteLine(" nome: " + pessoa3.nome + "\n idade: " + pessoa3.idade + "\n profissão: " + pessoa3.profissao + "\n");*/

    }

}