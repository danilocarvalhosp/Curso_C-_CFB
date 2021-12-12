using System;

class Aula24{
    static void Main(){
        for(int i = 0; i < 1; i++){
            cfb();
        }

        int v1, v2;
        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, soma(v1, v2));
    }

    static void cfb(){
        System.Console.WriteLine("CFB Cursos");
        System.Console.WriteLine("Curso de C#");
        System.Console.WriteLine("youtube.com/cfbcursos");
    }

    static int soma(int n1, int n2) {
        int res = n1 + n2;
        return res;
    }

}