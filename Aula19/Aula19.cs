using System;

class Aula19{
    static void Main(){

        
        for(int num = 0; num < 10; num++){
            Console.WriteLine("Valor de num: {0} - CFB Cursos", num);
        }

        int[] num2 = new int[10];

        for(int i = 0; i < num2.Length; i++){
            num2[i] = 0;
            System.Console.WriteLine("Valor de num2 na pos{0}: {1}", i, num2[i]);
        }
    }
}