using System;

class Aula03{
    static void Main(){
        byte n1 = 10; // armazena entre 0 e 255, apenas positivo
        int num = -10;
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Danilo";

        var aux1 = 10;
        var aux2 = "CFB Cursos";
        var aux3 = nome;

        int num1, num2, res;

        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        Console.WriteLine("O valor da variável: "+aux3+"...");

        Console.WriteLine("A multiplicação de "+num1+" com "+num2+" é igual a: "+res);
    }
}