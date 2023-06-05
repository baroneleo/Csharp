using System.Net.Http.Headers;
using System;
using System.Globalization;
using Cap6;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

#region Nullable

            // NULLABLE

            /*            
            double? x = null;
            double? y = 10.0;

            if (x != null)
                {
                    Console.WriteLine("x possui um valor inteiro)
                }
            else
                {
                    Console.WriteLine("x possui um valor nulo")
                }


            Console.WriteLine(x.GetValueOrDefault()); // (O ? transforma a variável em nullable), como foi atribuido o valor mull ele traz o valor 0 por ser nulo
            Console.WriteLine(y.GetValueOrDefault()); // (O ? transforma a variável em nullable), como foi atribuido valor ele traz o valor 10

            // o método (GetValueOrDefaut) é usado quando um dado não for necessário

            Console.WriteLine(x.HasValue); // Mostra se tem valor ou é null (No x ele da false por não ter valor, ser nulo)
            Console.WriteLine(y.HasValue); // Neste caso como possui valor e não é null ele mostra True

            // O método (HasValue) serve pra mostrar se é nulo ou não, True pra não nulo e False pra null

            if (x.HasValue)
                Console.WriteLine(x.Value);
            
            else 
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);

            else
                Console.WriteLine("Y is null");

            // o método (Value) lança uma exceção se não houver valor

            O nullable não pode ser atribuido para um struct comum

            // OPERADOR DE COALESCÊNCIA NULA

            double? x = null;
            double? y = 10;

            double a = x ?? 5; // Vai atribuir o valor de x em a, mas se for nulo ele muda pra 5 -> como é nulo ele muda o valor
            double b = y ?? 5; // Vai atribuir o valor de y em b, mas se for nulo ele muda pra 5 -> como não [e nulo ele só atribui o valor de y

            Console.WriteLine(a);
            Console.WriteLine(b);

            */

#endregion
        
#region VETORES

#region Exercício 1

            // ENUNCIADO

            /*
            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            pessoas.

            ENTRADA:                    SAÍDA:

            3                           AVERAGE HEIGHT: 1.69
            1.72
            1.56
            1.80    
            */

            // RESOLUÇÃO

            /*
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; 

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */

#endregion

#region Exercício 2

            // ENUNCIADO

            /*
            Fazer um programa para ler um número inteiro N e os dados (nome 
            e preço) de N Produtos. Armazene os N produtos em um vetor.
            Em seguida, mostrar o preço médio dos produtos.
            */

            // RESOLUÇÃO

            /*
            int n = int.Parse(Console.ReadLine());
            
            Product[] vect = new Product[n];
            
            for (int i = 0; i < n; i++) 
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            
            for (int i = 0; i < n; i++) 
            {
                sum += vect[i].Price;
            }
            
            double avg = sum / n;
            
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */

#endregion

#endregion

        }
    }
}