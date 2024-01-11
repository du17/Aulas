public class Professor : Pessoa{

    public string especialidade;
    public double salario;

    public void ministrarAula(){
        Console.WriteLine(this.nome + " Ministrando aula");
    }

    public void orientar(){
        Console.WriteLine("Orientando");
    }

}