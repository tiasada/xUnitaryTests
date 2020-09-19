using System;
using System.Collections.Generic;
using System.Linq;

namespace Autotests
{
    class Arrays
    {
        public double[] Exercise1(double[] arsA, double[] arsB)
          //1. Leia dois arrays A e B com 15 elementos. 
          //Construir um array C, onde cada elemento de C é a subtração
          // do elemento correspondente de A com B.
        {
            var arsC = new double[15];
              //              tamanho do array(Length)
            for (int b = 0; b < arsC.Length; b++)
            {
                arsC[b] = arsA[b] - arsB[b];
            }
            return arsC;
        }
         static void Exercise2()
        //2. Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        {
            var arsA = new int[10];


            for (int a = 0; a < arsA.Length; a++)
            {
                System.Console.WriteLine("digite um número para A:");
                arsA[a] = int.Parse(System.Console.ReadLine());

            }
            for (int b = 0; b < arsA.Length; b++)
            {
                System.Console.WriteLine(arsA[b]);

            }
            // varrendo o array ao contrario.
            for (int c = arsA.Length-1; c >= 0; c--)
            {
                System.Console.WriteLine(arsA[c]);
            }
        }
        static void Exercise3()
        //3. Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um número qualquer
        // e pesquise no array se o número existe. 
        // Caso, sexa verdade imprima a mensagem: “O número existe no array” ,
        // caso contrário “Número inexistente”.
        {
            var arsA = new int[10];
            for (int a = 0; a < arsA.Length; a++)
            {
                System.Console.WriteLine("digite um número para A:");
                arsA[a] = int.Parse(System.Console.ReadLine());
            }
            System.Console.WriteLine("digite um número para saber  se está presente no conjunto A");
            var input =int.Parse(System.Console.ReadLine());
            for (int x = 0; x<arsA.Length; x++)
            {
                if(input==arsA[x])
                {
                    System.Console.WriteLine($"o {input} número está presente no array!");
                    break;
                }
                else
                {
                    System.Console.WriteLine($"o {input} número não está presente no array!");
                }
            }
        }
        static void Exercise4()
        //4. Leia dois arrays A e B com 10 elementos.
        //  Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.
        {
            var arsA = new int?[3];
            var arsB = new int?[3];
            var equals = false; 
            var equal =0 ;

            for (int a = 0; a < arsA.Length; a++)
            {
                System.Console.WriteLine("digite um número para A:");
                var inputA = System.Console.ReadLine();
                while (arsA[a] == null)
                {
                    try
                    {
                        arsA[a] = Int32.Parse(inputA);
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("O números está em formato inválido");
                        System.Console.WriteLine("digite um número para A:");
                        inputA = System.Console.ReadLine();
                            
                    }
                }
            }
            for (var j =0; j < arsA.Length; j++)
            {
                System.Console.WriteLine("digite um número para B:");
                var inputB = System.Console.ReadLine();
                while (arsB[j] == null)
                {
                    try
                    {
                        arsB[j] = Int32.Parse(inputB);
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("O números está em formato inválido");
                        System.Console.WriteLine("digite um número para A:");
                        inputB = System.Console.ReadLine();
                            
                    }
                }
                for (var i =0 ; i < arsB.Length; i++)
                {
                    if(arsA[i]==arsB[j])
                    {
                        equal ++;
                        arsA[i] = null;
                        break;
                    }
                }
                if (equal == arsB.Length)
                {
                    equals= true;
                }
            }
           var messenge = equals ? "os arrays são iguais." : "os arrays não são iguais.";
        }
        static void Exercise5()
        //5. Leia um array A com 15 elementos,
        // e calcule a média aritmética dos mesmos, em seguida,
        // diga quantos dos elementos lidos estão abaixo, acima e na média.
        {
            var arsA = new int[15];
            var mediaV = 0;
            var sumV = 0;
            var Ovmedia = 0;
            var Unmedia = 0;
            var Inmedia = 0;
            System.Console.WriteLine("calculando a média aritimética");
            System.Console.WriteLine("Insira 15 valores:");

            for (int a = 0; a < arsA.Length; a++)
           {
                System.Console.WriteLine($"digite o um número:");
                arsA[a] = int.Parse(System.Console.ReadLine());
            }
            for (int x = 0; x < arsA.Length; x++)
            {
                sumV = sumV + arsA[x];
            }
            mediaV = sumV/arsA.Length;
             System.Console.WriteLine($"a média é {mediaV}.");
            for (int y = 0; y < arsA.Length; y++)
            {
                if(arsA[y] < mediaV)
                {
                    Unmedia++;
                }
                else if(arsA[y] == mediaV)
                {
                    Inmedia++;
                }
                else 
                {
                    Ovmedia++;
                }
            }
            System.Console.WriteLine($"existem {Unmedia} valores abaixo da média");
            System.Console.WriteLine($"existem {Inmedia} valores na média");
            System.Console.WriteLine($"existem {Ovmedia} valores acima da média");
        }
        
        static void Exercise6()
        //6. Leia um array A com 4 elementos. Após sua leitura, colocar os seus elementos em ordem crescente.
        //Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente.
        //Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b.
        //Colocar em ordem crescente a matriz C e apresentar os seus valores.
        {
            var arsA = new int[4];
            System.Console.WriteLine("Criando um conjunto A de 12 valores:");
            for (int a = 0; a < arsA.Length; a++)
           {
                System.Console.WriteLine($"digite o um número:");
                arsA[a] = int.Parse(System.Console.ReadLine());
            }
            // colocando matrix A em ordem crescente
            for (int i = 1; i < arsA.Length; i++)
            {
                //proteção para não passar do limite do array.(x < arsA.Length - 1;)
                for (int x = 0; x < arsA.Length - 1; x++)
                {
                    if (arsA[x] > arsA[x + 1])
                    {
                        var temp = arsA[x+1]; 
                        arsA[x+1] = arsA[x];
                        arsA[x] = temp;
                    }            
                }
            }
            System.Console.WriteLine("Conjunto A em ordem crescente:");
            for (int x = 0; x < arsA.Length; x++)
            {
                System.Console.WriteLine(arsA[x]);
            }

            var arsB = new int[4];
            System.Console.WriteLine("Criando um conjunto B de 12 valores:");
            for (int b = 0; b < arsB.Length; b++)
           {
                System.Console.WriteLine($"digite o um número:");
                arsB[b] = int.Parse(System.Console.ReadLine());
            }
            
            // colocando matrix B em ordem crescente
            for (int i = 1; i < arsB.Length; i++)
            {

                for (int x = 0; x < arsB.Length - 1; x++)
                {
                    if (arsB[x] < arsB[x + 1])
                    {
                        var temp = arsB[x+1]; 
                        arsB[x+1] = arsB[x];
                        arsB[x] = temp;
                    }            
                }
            }
            System.Console.WriteLine("Conjunto B em ordem decrescente:");
            for (int x = 0; x < arsB.Length; x++)
            {
                System.Console.WriteLine(arsB[x]);
            }
            System.Console.WriteLine("Calculando o valor do conjunto C = A+B");
            var arsC = new int[4];
            for (int b = 0; b < arsB.Length; b++)
            {
                arsC[b] = arsA[b] + arsB[b];
            }
            // colocando matrix C em ordem crescente
            for (int i = 1; i < arsC.Length; i++)
            {
                //proteção para não passar do limite do array.(x < arsA.Length - 1;)
                for (int x = 0; x < arsC.Length - 1; x++)
                {
                    if (arsC[x] > arsC[x + 1])
                    {
                        var temp = arsC[x+1]; 
                        arsC[x+1] = arsC[x];
                        arsC[x] = temp;
                    }            
                }
            }
            System.Console.WriteLine("Conjunto C ordem crescente:");
            for (int x = 0; x < arsC.Length; x++)
            {
                System.Console.WriteLine(arsC[x]);
            }
            System.Console.WriteLine("fim.");
        }

    }
}