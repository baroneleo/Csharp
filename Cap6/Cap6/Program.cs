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

            #region NULLABLE

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

            #region Exercício 3

            // ENUNCIADO

            /*
            A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos
            identificados pelos números 0 a 9.
            
            Fazer um programa que nicia com todos os dez quartos vazios, e depois leia uma quantidade N
            representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida,
            registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do
            estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um
            quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato,
            por ordem de quarto, conforme exemplo.
            
            EXEMPLO:

            How many rooms will be rented? 3

            Rent #1:
            Name: Maria Green
            Email: maria@gmail.com
            Room: 5

            Rent #2:
            Name: Marco Antonio
            Email: marco@gmail.com
            Room: 1

            Rent #3:
            Name: Alex Brown
            Email: alex@gmail.com
            Room: 8

            Busy rooms:
            1: Marco Antonio, marco@gmail.com
            5: Maria Green, mariagmail.com
            8: Alex Brown, alex@gmail.com
            */

            // RESOLUÇÃO

            /*
            Estudante[] vect = new Estudante[10];

            Console.Write("How many rooms will be rent? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();                
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Estudante(name, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");
            for(int i = 0;1 < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            */

            #endregion

            #endregion

            #region PARAMS

            /*
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            */

            #endregion

            #region MODIFICADOR REF

            /*
            int a = 10;

            Calculator.Triple(ref a);
            Console.WriteLine(a);
            */

            #endregion

            #region MODIFICADOR OUT

            /*
            O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável 
            original), mas não exige que a variável original seja iniciada.
            */

            /*
            int a = 10;
            int triple;

            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
            */


            // CONSIDERAÇÕES

            /*
            Diferença:
            A variável passada como parâmetro ref DEVE ter sido iniciada
            A variável passada como parâmetro out não precisa ter sido iniciada
            
            Conclusão: ambos são muito similares, mas ref é uma forma de fazer 
            o compilador obrigar o usuário a iniciar a variável.
            
            Nota: ambos são considerados "code smells" (design ruim) e devem 
            ser evitados
            */

            #endregion

        }
    }
}