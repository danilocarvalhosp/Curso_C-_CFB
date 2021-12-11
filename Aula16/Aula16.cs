using System;

class Aula16{
    static void Main(){

        inicio: 
        Console.Clear();

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

        System.Console.Write("\nCalcular outro transporte? [s / n] = ");
        escolha = char.Parse(Console.ReadLine());
        
        if(escolha == 's' || escolha == 'S'){
            goto inicio;
        } else {
            Console.Clear();
            System.Console.WriteLine("Fim do Programa");
        }
    }
}