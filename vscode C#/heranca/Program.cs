using System;
public class Program
{
    public static void Main()
    {
        
        Aluno a1 = new Aluno();
        Funcionario f1 = new Funcionario();
        Professor p1 = new Professor();
        Pessoa pessoa = new Pessoa();

        p1.nome = "Antonio";
        p1.ministrarAula();
        p1.estudar();

        f1.nome = "Carlos";
        f1.idade = 25;

        a1.nome = "Joao";
        a1.curso = "Informatica";

    }
}
