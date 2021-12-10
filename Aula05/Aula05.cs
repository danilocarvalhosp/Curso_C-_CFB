using System;

class Aula05{

    static void Main(){

        int total = (10 + 5) * 2;
        System.Console.WriteLine(total);

        bool res = 10 < 5;
        System.Console.WriteLine(res);

        int num = 10;
        num++;      //  num += 1;    // num = num + 1;

        num+=2;     // num = num + 2;
        System.Console.WriteLine(num);

        // & = AND / E
        // | = OR / OU

        bool valor1 = (5 > 3) | (10 < 5);
        bool valor2 = (5 > 3) & (10 < 5);
        System.Console.WriteLine(valor1);
        System.Console.WriteLine(valor2);


    }
}