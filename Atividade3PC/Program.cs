using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3PC
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Questao7();
        }

        static void Questao1()
        {
            int num = 0;
            int[] arrayA = new int[10];

            for(int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine($"Digite um número a preenchido na posição {i + 1} do array: ");
                num = int.Parse(Console.ReadLine());
                arrayA[i] = num;

            }

            int[] arrayB = new int[10];

            for(int j = 0; j < arrayB.Length; j++)
            {
                if(j <= 8)
                {
                    arrayB[j] = arrayA[j] * arrayA[j+1];
                }


                if(j == 9)
                {
                    arrayB[j] = arrayA[j] * 1;
                }

                Console.WriteLine(arrayB[j]);
            }
        }

        static void Questao2()
        {
            int num = 0;
            int[] array1 = new int[5];

            for(int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Digite o número da posição {i + 1} do array: ");
                num = int.Parse(Console.ReadLine());
                array1[i] = num;
            }

            int[] array2 = new int [5];

            for(int j = 0; j < array2.Length; j++)
            {
                int indice = (array1.Length - 1) - j;
                array2[j] = array1[indice];
            }

                Console.Write($"Os números do array 1 são: {array1[0]}, {array1[1]}, {array1[2]}, {array1[3]}, {array1[4]} ");
                Console.WriteLine();
                Console.WriteLine($"O array invertido é: {array2[0]}, {array2[1]}, {array2[2]}, {array2[3]}, {array2[4]}");
        }

        static void Questao3()
        {
            int num = 0;
            int[,] array1 = new int[4,4];
            int[,] array2 = new int[4,4];

            for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine($"Primeira matriz - Digite o número da {i+1}º linha, coluna {j+1} ");
                    num = int.Parse(Console.ReadLine());
                    array1[i, j] = num;
                }
            }

            for(int i = 0; i < array2.GetLength(0); i++)
            {
                for(int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine($"Segunda matriz - Digite o número da {i+1}º linha, coluna {j+1} ");
                    num = int.Parse(Console.ReadLine());
                    array2[i, j] = num;
                }
            }

            int[,] arraySoma = new int[4, 4];

            for(int i = 0; i < arraySoma.GetLength(0); i++)
            {
                for(int j = 0; j < arraySoma.GetLength(1); j++)
                {
                    arraySoma[i, j] = array1[i,j] + array2[i,j];
                }
            }

            foreach(int numeros in arraySoma)
            {
                Console.WriteLine($"A soma dos dois arrays é: {numeros}");
            }

        }

        static void Questao4()
        {
            double num = 0.0;
            double[,] produtos = new double[2, 4];

            double totalAno = 0.0;

            for(int i = 0; i < produtos.GetLength(0); i++)
            {
                for(int j = 0; j < produtos.GetLength(1); j++)
                {
                    Console.WriteLine($"Tabela de produtos - Digite o valor das vendas do {i+1}º mês na semana {j+1} ");
                    num = double.Parse(Console.ReadLine());
                    produtos[i, j] = num;
                }
            }

            for(int i = 0; i < produtos.GetLength(0); i++)
            {
                double totalMeses = 0.0;
                for(int j = 0; j < produtos.GetLength(1); j++)
                {
                    totalMeses += produtos[i,j];
                    
                }
                Console.WriteLine($"O valor do {i+1}º Mês é: {totalMeses}");
            }


            for(int l = 0; l < produtos.GetLength(1); l++)
            {
                double totalSemanas = 0.0;
                for(int c = 0; c < produtos.GetLength(0); c++)
                {
                    totalSemanas += produtos[c,l];
                    
                }
                Console.WriteLine($"O total da {l+1}º semana foi: {totalSemanas}");
            }

            for(int l = 0; l < produtos.GetLength(1); l++)
            {

                for(int c = 0; c < produtos.GetLength(0); c++)
                {
                    totalAno += produtos[c,l];
                    
                }
                
            }

            Console.WriteLine($"O total vendido no ano foi de: {totalAno}");

        }

        static void Questao5()
        {
            List<string> cores = new List<string>();
            cores.Add("Branco");
            cores.Add("Vermelho");
            cores.Add("Amarelo");
            cores.Add("Azul");
            cores.Add("Rosa");
            string[] coresBackup = cores.GetRange(0,3).ToArray();

            foreach(string cor in cores)
            {
                Console.Write($"{cor}");
            }

            Console.WriteLine();

            
            for(int i = 0; i < 3; i++)
            {
                cores.RemoveAt(0);
            }

            cores.AddRange(coresBackup);

            foreach(string cor in cores)
            {
                Console.Write($"Após remover as cores e remanejar elas, sobraram as cores: {cor}");
                Console.WriteLine();
            }
            
        }

        static void Questao6()
        {
            List<string> usuarios = new List<string>();

            MenuQuestao6(usuarios);
        }

        static void MenuQuestao6(List<string> temp)
        {
            int opcao = 99;
            do
            {
                Console.Clear();
                ExibirLista(temp);

                Console.Write("1 - Adiconar usuário");
                Console.Write("\n2 - Remover usuário");
                Console.Write("\n3 - Substituir usuário");
                Console.Write("\n4 - Limpar lista");
                Console.Write("\n0 - Sair do programa");
                Console.Write("\n Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
            {
                case 1:
                    AdicionarUsuarioQuestao6(temp);
                break;

                case 2:
                    RemoverUsuarioQuestao6(temp);
                break;

                case 3:
                    SubstituirUsuarioQuestao6(temp);
                break;

                case 4:
                    LimparListaQuestao6(temp);
                break;

                case 0:
                    Console.WriteLine("Saindo do programa...");
                    Thread.Sleep(800);
                break;

                default:
                    Console.WriteLine("Opção inválida, por favor, digite apenas as opções exibidas.");
                    Thread.Sleep(1500);
                break;
            }

            }while(opcao != 0);

            
        }

        static void ExibirLista(List<string> temp)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("=====Lista de Usuários=====");
            Console.WriteLine("===========================");

            if(temp.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado ainda");
            }
            else
            {
                for(int i =0; i < temp.Count; i++)
                {
                    Console.WriteLine($"{(i + 1).ToString()} - {temp[i]}");
                }
            }

            Console.WriteLine("===========================\n");
        }

        static void AdicionarUsuarioQuestao6(List<string> temp)
        {
            Console.WriteLine("Digite o nome do usuário que você deseja adicionar: ");
            string nome = Console.ReadLine();
            temp.Add(nome);
        }

        static void RemoverUsuarioQuestao6(List<string> temp)
        {
            Console.WriteLine("Digite o nome do usuário que você deseja remover: ");
            string nome = Console.ReadLine();

            if(temp.Contains(nome))
            {
                temp.Remove(nome);
                Console.WriteLine("Usuário removido com sucesso");
            }
            else
            {
                Console.WriteLine("Este usuário não existe.");
            }
        }

        static void SubstituirUsuarioQuestao6(List<string> temp)
        {
            Console.WriteLine("Digite o nome do usuário que você deseja Substituir: ");
            string nome = Console.ReadLine();

            if(temp.Contains(nome))
            {
                Console.WriteLine("Digite o usuário substituto: ");
                string novoUsuario = Console.ReadLine();
                temp.Insert(temp.IndexOf(nome), novoUsuario);
                temp.Remove(nome);
            }
            else
            {
                Console.WriteLine("Este usuário não existe.");
            }
        }

        static void LimparListaQuestao6(List<string> temp)
        {
            Console.WriteLine("Tem certeza que deseja limpar a lista? S/N");
            char opcao = Convert.ToChar(Console.ReadLine().ToUpper());

            if(opcao == 'S')
            {
                Console.WriteLine("Entendido, limpando lista...");
                for(int i = 0; i < temp.Count; i++)
                {
                    temp.Clear();
                }
            }
        }

        static void Questao7()
        {
            Stack<string> pratos = new Stack<string>();
            pratos.Push("prato 1");
            pratos.Push("prato 2");
            pratos.Push("prato 3");
            pratos.Push("prato 4");
            pratos.Push("prato 5");

            Console.WriteLine("A lista de pratos antes da remoção: ");
            foreach(string prato in pratos)
            {
                
                Console.WriteLine(prato);
            }

            pratos.Pop();
            pratos.Peek();
            pratos.Pop();
            pratos.Push("Prato 6");

            Console.WriteLine("A lista de pratos depois de remover dois itens e adicionar o 6º prato: ");
            foreach(string prato in pratos)
            {
                Console.WriteLine(prato);
            }

        }

        static void Questao8()
        {

        }
    }
}
