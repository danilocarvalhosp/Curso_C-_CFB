using System;

class Aula25{
    static void Main(){
        int num1 = 10;
        int num2 = 10;
        dobrar1(ref num1);
        dobrar2(num2);

        System.Console.WriteLine(num1);
        System.Console.WriteLine(num2);
    }

    static void dobrar1(ref int valor){
        valor *= 2;
    }

    static void dobrar2(int valor){
        valor *= 2;
    }
}