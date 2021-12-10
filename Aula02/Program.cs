using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB Cursos");
            if(args.GetLength(0) > 0){
                Console.Write(args.GetValue(0));
            }
        }
    }
}

// Criando programa C# .NET - no terminal, dentro da pasta do arquivo, digitar "dotnet new console"