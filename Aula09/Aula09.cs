using System;

class Aula09{
    static void Main(){
        int num = 20;

        int num1 = num << 1;
        int num2 = num >> 1;

        Console.WriteLine(num1);
        Console.WriteLine(num2);

        int num3 = num << 2;
        int num4 = num >> 2;

        Console.WriteLine(num3);
        Console.WriteLine(num4);

        // Bitwise "<<" - dobra o valor do número
        // Bitwise ">>" - resulta na metade do valor do número
    }
}