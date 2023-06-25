using System;
using System.Globalization;

using Cap5;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício Produto cap. 4

            /*
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            */

            #endregion

            #region Exercício remodelado com construtores

            /*
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            */

            #endregion

            #region Exercício remodelado com Sobrecarga

            /*
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            */

            #endregion

            #region Exercício remodelado com Sobrecarga "Sintaxe alternativa"

            /*
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 900.00, 
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            */

            #endregion

            #region Exercicio remodelado referenciando um um construtor com outro construtor 

            /*
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 900.00,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            */

            #endregion

            #region Utilização de encapsulamento

            /*
            Produto p = new Produto("TV", 900.00, 10);

            p.SetNome("T"); // A condição na propriedade não permite a mudança no set
            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K"); // Aqui ja permite a mudança no set
            Console.WriteLine(p.GetNome());

            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
            */

            #endregion

            #region Utilização de Properties

            /*
            Produto p = new Produto("TV", 900.00, 10);

            p.Nome = "T";
            
            Console.WriteLine(p.Nome); // Aqui não permite a mudança no set
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            */

            #endregion

            #region Utilização de autoproperties

            /*
            Produto p = new Produto("TV", 900.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome); // Aqui não permite a mudança no set
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            */

            #endregion

            #region Ordem sugerida para estrutura da classe

            /*
             * ATRIBUTOS PRIVADOS
             * AUTO PROPERTIES
             * CONSTRUTORES
             * PROPRIERTIES CUSTOMIZADAS
             * OUTROS METODOS DA CLASSE
            */

            #endregion

            #region Exercício Conta Bancária

            /*
            ContaBancaria conta;

            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados:");
            Console.Write(conta);

            Console.Write("Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);

            Console.Write(conta);
            */

            #endregion



        }
    }
}