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
           
            Questao4();
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
            double[,] produtosColuna = new double[2,4];
            double [,] produtosLinhas = new double[2,4];
            double[,] totalProdutos = new double[2,4];

            double totalMeses = 0.0;
            double totalSemanas = 0.0;
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
                for(int j = 0; j < produtos.GetLength(1); j++)
                {
                    totalMeses += produtos[i,j];
                    
                }
                System.Console.WriteLine($"O valor do {i+1}º Mês é: {totalMeses}");
            }

                System.Console.WriteLine(totalMeses);

            for(int l = 0; l < produtos.GetLength(1); l++)
            {
                for(int c = 0; c < produtos.GetLength(0); c++)
                {
                    totalSemanas += produtos[c,l];
                    Console.WriteLine($"O total da {c+1}º semana foi: {totalSemanas}");
                }
            }
            
            System.Console.WriteLine(totalSemanas);
        }

        static void Questao5()
        {
            
        }
    }
}
