using System;

class Aula20{
    static void Main(){

        int[] num = new int[10];
        int i = 0;

        while(i < 10){
            Console.WriteLine("CFB Cursos");
            i++;
        }

        System.Console.WriteLine("Fim do Loop");


        int[] num2 = new int[10];
        i = num.Length - 1;

        while(i > 0){
            num2[i] = 0;
            Console.WriteLine(num2[i]);
            i--;
        }

        System.Console.WriteLine("Fim do Loop");

    }
}