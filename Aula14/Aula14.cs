using System;

class Aula14{
    static void Main(){

        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        if(res >= 60){
            if(res >= 90){
                if (res >= 99){
                    resultado = "APROVADO COM SUPER LOUVOR";
                } else {
                    resultado = "APROVADO COM LOUVOR";
                }
            } else {
                resultado = "APROVADO";
            }
        } else {
            if(res >= 40){
                resultado = "RECUPERAÇÃO";
            } else {
                resultado = "REPROVADO";
            }
        }

        System.Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);
    }
}