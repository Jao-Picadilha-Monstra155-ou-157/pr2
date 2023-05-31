using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] vet2;
            //float media = 0;
            //Console.WriteLine("Entre com o tamanho: ");
            //int T = int.Parse(Console.ReadLine());
            //vet2 = new int[T];
            //Random rand = new Random();

            //for (int i = 0; i < T; i++)
            //{

            //    vet2[i] = rand.Next(10, 50);
            //    media = media + vet2[i];
            //}
            //for (int i = 0; i < T; i++)
            //{
            //    Console.WriteLine("Digite o valor do posição [{0}] = {1}", i, vet2[i]);

            //}
            //Console.WriteLine(media / (float)T);

            int[] vet2;
            int numI = 0;
            int numP = 0;
            Console.WriteLine("Entre com o tamanho: ");
            int T = int.Parse(Console.ReadLine());
            vet2 = new int[T];
            Random rand = new Random();

            for (int i = 0; i < T; i++)
            {

                vet2[i] = rand.Next(2,10);
                if(vet2[i] % 2 == 0)
                {
                    numP = numP +vet2[i];
                }
                else
                {
                    numI = numI + vet2[i];
                }
            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("Digite o valor do posição [{0}] = {1}", i, vet2[i]);

            }
            Console.WriteLine("Numeros pares são :", numP = numP + vet2[i]);

            Console.WriteLine("Numeros impares são :", numI = numI + vet2[i] );
        }
    }
}
