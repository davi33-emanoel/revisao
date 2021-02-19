using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1-Inserir novo aluno ");
            Console.WriteLine("2 listar alunos ");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opçaoUsuario = Console.ReadLine();

            while (opçaoUsuario.ToUpper() != "X")
            {
                 switch(opçaoUsuario)
                 {
                     case "1":
                        //TODO: adicionar aluno
                     break;

                     case "2":
                           //TODO: listar alunos
                     break;

                     case "3":
                          //Calcular media geral
                     break;

                     default:
                        throw new ArgumentOutOfRangeException();
           
                 }
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1-Inserir novo aluno ");
            Console.WriteLine("2 listar alunos ");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            opçaoUsuario = Console.ReadLine();
            }

        }
    }
}
