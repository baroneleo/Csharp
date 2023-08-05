using System.Net.Http.Headers;
using System;
using System.Globalization;
using Cap6;
using System.Collections.Generic;

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

            #region FOREACH

            /*
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-----------------------");

            string[] vect2 = new string[] { "Maria", "Bob", "Alex" };

            foreach (string nome in vect)
            {
                Console.WriteLine(nome);
            }
            */

            #endregion

            #region LISTAS

            /*

            List<string> list = new List<string>();

            // ADD -> Adicionar na lista
            // INSERT -> Adicionar na lista em posição pré determinada

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: "+ list.Count);

            // FIND -> Encontrar o primeiro item da lista que vc determina na busca

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);
 
            // FINDLAST -> Encontrar o primeiro item da lista que vc determina na busca

            string s2 = list.FindLast(x => x[0] ==  'A');
            Console.WriteLine("First A: " + s1);

            // FINDINDEX -> Encontra a posição do primeiro item da lista que você determina na busca

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // FINDINDEX -> Encontra a posição do ultimo item da lista que você determina na busca

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            // FINDALL -> Criar uma nova lista contendo apenas os elementos que satisfaçam um predicado

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // REMOVEAT -> Remove o elemento pela posição dele
            // REMOVE -> Remove o elemento que você determinar

            list.Remove("Alex");
            Console.WriteLine("-----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // REMOVEALL -> Remove todos itens que satisfaçam o predicado

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */

            #endregion

            #region EXERCÍCIO LISTAS

            /*
            Console.Write("How many employees will be registered? "); // Pergunta quantos empregados serão registrados
            int n = int.Parse(Console.ReadLine()); // Usuario insere quantos empregados serão registrados

            List<Employee> list = new List<Employee>(); // Cria e instancia a lista

            for (int i = 1; i <= n; i++) // Inicia a criação dos dados
            {
                Console.WriteLine("Employee #" + i); // Printa o numero do usuário
                Console.Write("Id: "); // Pergunta o ID do usuário
                int id = int.Parse(Console.ReadLine()); // Usuário insere o número do ID
                Console.Write("Name: "); // Pergunta o nome do funcionário
                string name = Console.ReadLine(); // Usuário insere o nome do funcionário 
                Console.Write("Salary: "); // Pergunta o salário do funcionário
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Usuário insere o salário do funcionário
                list.Add(new Employee(id, name, salary)); // Adiciona as informações acima na lista
                Console.WriteLine(); // Pula linha
            }

            Console.Write("Enter the employee id that will have salary increase: "); // Pergunta qual o ID do funcionário que terá aumento de salário
            int searchId = int.Parse(Console.ReadLine()); // Usuário digita o ID do funcionário

            Employee emp = list.Find(x => x.Id == searchId); // Busca o ID na lista

            if (emp != null) // Cria condição de ID caso ele exista, diferente de nulo
            {
                Console.Write("Enter the percentage: "); // Pergunta qual a porcentagem do salário que vai ser aumentado
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Usuário digita a porcentagem
                emp.IncreaseSalary(percentage); // Chama a função na outra classe
            }
            else // Caso o ID não exista
            {
                Console.WriteLine("This id doesn't exist!"); // Printa que o ID não existe
            }

            Console.WriteLine(); // Pula linha

            Console.WriteLine("Updated list of employees: ");

            foreach(Employee obj in list) // Diferencia os funcionarios
            {
                Console.WriteLine(obj); // Printa todos os dados
            }
            */

            #endregion

            #region MATRIZES

            /*
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // Quantidade de dados
            Console.WriteLine(mat.Rank); // Quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); // Tamanho de matriz da primeira dimensão = linhas
            Console.WriteLine(mat.GetLength(1)); // Tamanho de matriz da segunda dimensão = coluna
            */

            #endregion

            #region EXERCÍCIO MATRIZES 1

            // ENUNCIADO

            /*
            Fazer um programa para ler um número inteiro N e uma matriz de
            ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            principal e a quantidade de valores negativos da matriz
            */

            // RESOLUÇÃO

            /*
            int n = int.Parse(Console.ReadLine()); // Usuário digita o numero de linhas e colunas

            int[,] mat = new int[n, n]; // Cria a matriz com o numero digitado N x N

            for (int i = 0; i < n; i++) // Adiciona os numeros da primeira linha
            {

                string[] values = Console.ReadLine().Split(' '); // Digita os valores dos numeros da primeira linha separado por espaço

                for (int j = 0; j < n; j++) // Separa os itens da linha por coluna
                {
                    mat[i,j] = int.Parse(values[j]); // Converte cada item de string para inteiro
                }
            }

            Console.WriteLine("Main diagonal"); // Printa a mensagem
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " "); // Printa os numeros da diagonal principal (que começa no 0,0)
            }

            Console.WriteLine(); // Pula linha

            int count = 0; // Cria a variável contadora

            for (int i = 0; i < n; i++) // Percorrer linhas
            {
                for(int j = 0; j < n; j++) // Percorrer colunas
                {
                    if (mat[i,j] < 0) // Vai verificar se o dado é menor que 0
                    {
                        count++; // Caso for menor que 0 ele adiciona na variável contadora
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count); // Printa a quantidade de numeros negativos
            */

            #endregion

            #region EXERÍCIO MATRIZES 2

            // ENUNCIADO

            /*
            Fazer um programa para ler dois números inteiros M e N, e depois ler
            uma matriz de M linhas por N colunas contendo números inteiros,
            podendo haver repetições. Em seguida, ler um número inteiro X que
            pertence à matriz. Para cada ocorrência de X, mostrar os valores à
            esquerda, acima, à direita e abaixo de X, quando houver, conforme
            exemplo.
            */

            // RESOLUÇÃO

            /*
            string[] line = Console.ReadLine().Split(' '); // Usuário digita numeros da dimensão da matriz 
            int m = int.Parse(line[0]); // Digita numero de linhas
            int n = int.Parse(line[1]); // Digita o numero de colunas

            int[,] mat = new int[m, n]; // Cria a matriz com base no digitado

            for (int i = 0; i < m; i++) // Percorre a matriz
            {
                string[] values = Console.ReadLine().Split(' '); // Usuário digita os números da linha e é transformado em string
                
                for(int j = 0; j < values.Length; j++) // percorre os numeros da linha em cada coluna
                {
                    mat[i,j] = int.Parse(values[j]); // Transforma os numeros de string pra inteiro
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0;i < m; i++)
            {
                for(int j = 0;j < x; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("position: " + i + "," + j + ":");
                        if( j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if( i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(j < n -1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if ( i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            */

            #endregion
        }
    }
}