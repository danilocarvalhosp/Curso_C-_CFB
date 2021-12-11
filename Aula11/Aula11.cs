using System;

class Aula11{
    static void Main(){

        // CONVERSÃO IMPLÍCITA (SEGURA)

        int n1 = 10;
        float n2 = n1;

        System.Console.WriteLine(n2);


        // CONVERSÃO EXPLÍCITA

        float n3 = 10.5f;
        int n4 = (int) n3; // typecast

        System.Console.WriteLine(n4);
    }
}