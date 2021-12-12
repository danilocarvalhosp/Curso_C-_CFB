using System;

class Aula22{
    static void Main(){
        int[] num = new int[3] { 11, 22, 33};

    // LEITURA DE ELEMENTOS USANDO FOR
        for(int i = 0; i < num.Length; i++){
            System.Console.WriteLine(num[i]);
        }

    // LEITURA DE ELEMENTOS USANDO FOREACH
        foreach(int n in num){
            System.Console.WriteLine(n);
        }
    }
}