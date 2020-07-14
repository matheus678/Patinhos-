using System;



namespace Patinhos

{

    class Program

    {

        static void Main(string[] args)
        /*
         [console: Patinhos] Exiba a letra da música "Cinco Patinhos" (versão brasileira gravada pela Xuxa de "Five little ducks" - The Wiggles). Seu programa deve perguntar quantos patinhos o usuário deseja (pelo menos 2).
         A canção começa assim:
         (N) patinhos foram passear
         Além das montanhas
         Para brincar
         A mamãe gritou: Quá, quá, quá, quá
         Mas só (N-1) patinhos voltaram de lá.
         Esse bloco se repete até nenhum patinho voltar. Ao final, todos os patinhos voltam:
         A mamãe patinha foi procurar
         Além das montanhas
         Na beira do mar
         A mamãe gritou: Quá, quá, quá, quá
         E os (N) patinhos voltaram de lá.
         Ex.:
         Quantos patinhos? 3

         3 patinhos foram passear
         Além das montanhas
         Para brincar
         A mamãe gritou: Quá, quá, quá, quá
         Mas só 2 patinhos voltaram de lá.

         2 patinhos foram passear
         Além das montanhas
         Para brincar
         A mamãe gritou: Quá, quá, quá, quá
         Mas só 1 patinho voltou de lá.

         1 patinho foi passear
         Além das montanhas
         Para brincar
         A mamãe gritou: Quá, quá, quá, quá
         Mas nenhum patinho voltou de lá.

         A mamãe patinha foi procurar
         Além das montanhas
         Na beira do mar
         A mamãe gritou: Quá, quá, quá, quá
         E os 3 patinhos voltaram de lá.
         */

        {

            bool fim = false;

            int npatos;

            // int será responsavel por armazenar a quatidade de patos que irão passear.

            while (!fim)

            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Quantos patinhos irão passear? (>=2) ");
                bool npatosbool = Int32.TryParse(Console.ReadLine(), out npatos);
                int todos = npatos;

                if (!npatosbool || npatos < 2)
                // este if terá a função de pedir para o usuário gitar novamente caso ele não digite um número
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    Console.WriteLine("VÔCÊ NÃO DIGITOU UM NÚMERO... DIGITE UM NÚMERO.");
                    Console.ReadKey();
                }

                for (int i = npatos; i > 1; i--)
                // contador
                {
                    Console.WriteLine($"{i} patinhos foram passear");
                    Console.WriteLine($"Além das montanhas");
                    Console.WriteLine($"Para brincar");
                    Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                    if (i <= 2)
                    {
                        Console.WriteLine($"Mas só {i-1} patinho voltou de lá.\n");
                    }
                    else
                    {
                        Console.WriteLine($"Mas só {i-1} patinhos voltaram de lá.\n");
                    }
                    
                }

                Console.WriteLine($"1 patinho foi passear");
                Console.WriteLine($"Além das montanhas");
                Console.WriteLine($"Para brincar");
                Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                Console.WriteLine($"Mas nenhum patinho voltou de lá.\n");

                Console.WriteLine($"A mamãe patinha foi procurar");
                Console.WriteLine($"Além das montanhas");
                Console.WriteLine($"Na beira do mar");
                Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                Console.WriteLine($"E os {todos} patinhos voltaram de lá.\n");

                Console.WriteLine("Pressione uma tecla para finalizar o programa.");

                Console.ReadKey();

                fim = true;

                // true encerra o progema sem que haja uma nova repetição

            }
            Console.ResetColor();

        }

    }

}
