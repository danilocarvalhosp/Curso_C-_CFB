using System;

class Veiculo{ // CLASSE BASE
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVelMax(){
        return velMax;
    }
}

class Carro : Veiculo { // CLASSE DERIVADA DE VEÍCULO
    public string nome;

    public Carro(string nome, int vm) : base(vm){
        this.nome = nome;
        ligado = true;
    }
}

class Aula36{
    static void Main(){
        Carro carro = new Carro("Bonitão", 120);

        System.Console.WriteLine("Nome...........: {0}", carro.nome);
        System.Console.WriteLine("Vel. Máxima....: {0}", carro.getVelMax());
        System.Console.WriteLine("Ligado.........: {0}", carro.getLigado());
    }
}