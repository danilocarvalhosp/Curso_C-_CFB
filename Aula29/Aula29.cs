using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

// CONSTRUTOR
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

// DESTRUTOR
    ~Jogador(){
        System.Console.WriteLine("Jogador {0} foi destruído", nome);
    }
}

class Aula29{
    static void Main(){

        string nome1;
        System.Console.Write("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();

        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador("Théo");

        Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
    }
}