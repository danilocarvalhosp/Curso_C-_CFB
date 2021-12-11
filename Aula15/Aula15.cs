using System;

class Aula15{
    static void Main(){

        System.Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        System.Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [o] Ônibus ");

        int tempo = 0;
        char escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo = 0;
                break;
        }

        if(tempo == 0){
            System.Console.WriteLine("Transporte indisponível");
        } else {
            System.Console.WriteLine("Tempo para o transporte escolhido é de: {0} minutos", tempo);
        }
    }
}