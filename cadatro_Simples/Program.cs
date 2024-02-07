using System;
using System.Collections.Generic;


namespace cadatro_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var jogos = new List<string>();    

            while (true)
            {
                Console.WriteLine("---Menu Principal---");
                Console.WriteLine("1- Cadastrar Jogos");
                Console.WriteLine("2- Listar Jogos");
                Console.WriteLine("3- Remover Jogo");
                Console.WriteLine("0 - Sair");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do jogo.");

                        var nomeJogo = Console.ReadLine();  

                        jogos.Add(nomeJogo);

                        Console.WriteLine("Jogo cadastrado com sucesso.");
                        break;
                    case "2":
                        foreach (var jogo in jogos)
                        {
                            Console.WriteLine(jogos);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome do jogo.");

                        var jogoRemover = Console.ReadLine();

                        var sucesso = jogos.Remove(jogoRemover);

                        if (sucesso)
                        {
                            Console.WriteLine("Jogo removido com sucesso.");
                        } else
                        {
                            Console.WriteLine("jogo não encontrado.");
                        }

                        break;
                    case "0":
                        Console.WriteLine("Finalizando a aplicação...");

                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            }


        }
    }
}
