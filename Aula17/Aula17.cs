using System;

class Aula17{
    static void Main(){

    // PRIMEIRA FORMA DE DECLARAR ARRAY
        // int n1, n2, n3, n4, n5;
        int[] n = new int [5];

        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine(n [0]);

    // SEGUNDA FORMA DE DECLARAR ARRAY
        int[] num = new int [3] {55, 77, 99};

        Console.WriteLine(num[2]);

    // TERCEIRA FORMA DE DECLARAR ARRAY
        int[] num2 = {55, 77, 99};

        Console.WriteLine(num2 [1]);
    }
}