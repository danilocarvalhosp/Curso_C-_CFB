using System;

class Aula21{
    static void Main(){

        int num = 5;

        // TESTA A CONDIÇÃO PRIMEIRO, DEPOIS EXECUTA (NÃO HÁ GARANTIA DE EXECUÇÃO)
        while(num < 5){
            System.Console.WriteLine("CFB Cursos");
        }

        // EXECUTA PRIMEIRO, DEPOIS ELE TESTA A CONDIÇÃO (GARANTIA DE EXECUTAR PELO MENOS UMA VEZ)
        do{
            System.Console.WriteLine("CFB Cursos");
        } while(num < 5);

        //------------------------------

        string senha = "123";
        string senhauser;
        int tentativas = 0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha:");
            senhauser = Console.ReadLine();
            tentativas++;
        } while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha Correta, tentativas {0}", tentativas);
    }
}