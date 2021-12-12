using System;

class Aula23{
    static void Main(){

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5] {{11, 22, 33, 44, 55},{66, 77, 88, 99, 00}};

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++){
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

    // PUBLIC STATIC INT BINARYSEARCH(ARRAY, VALOR)
        System.Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        System.Console.WriteLine("Valor {0} está na posiçao {1}", procurado, pos);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC STATIC VOID COPY(ARRAY_ORIGEM, ARRAY_DESTINO, QTDE_ELEMENTOS)
        System.Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2) {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC VOID COPYTO(ARRAY_DESTINO, A_PARTIR_DESTA_POSIÇÃO)
        System.Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach(int n in vetor3) {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC LONG GETLONGLENGTH(DIMENSÃO)
        System.Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        System.Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC INT GETLOWERBOUND(DIMENSÃO)
        System.Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        System.Console.WriteLine("Menor índice do vetor1 {0}", MenorIndiceVetor);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC INT GETUPPERBOUND(DIMENSÃO)
        System.Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        System.Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceVetor);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC OBJECT GETVALUE(LONG ÍNDICE)
        System.Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        System.Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC STATIC INT INDEXOF(ARRAY, VALOR)
        System.Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        System.Console.WriteLine("Índice do último valor 33: {0}", indice1);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC STATIC INT LASTINDEXOF(ARRAY, VALOR)
        System.Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        System.Console.WriteLine("Índice do último valor 33: {0}", indice2);
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC STATIC VOID REVERSE(ARRAY)
        System.Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC VOID SETVALUE(OBJECT VALOR, LONG POS)
        System.Console.WriteLine("SetValue");
        vetor2.SetValue(99,0);
        for(int i=0; i<vetor2.Length; i++){
            vetor2.SetValue(0,i);
        }
        System.Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("--------------------------------------------");

    // PUBLIC STATIC VOID SORT(ARRAY)
        System.Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        System.Console.WriteLine("Vetor1");
        foreach(int n in vetor1){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("Vetor2");
        foreach(int n in vetor2){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("Vetor3");
        foreach(int n in vetor3){
            System.Console.WriteLine(n);
        }        
        System.Console.WriteLine("--------------------------------------------");
    }
}