using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VAR

            /*
            var x = 10;
            var y = 10.2;
            var z = "Leo";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int w = z;
            */

            #endregion

            #region SWITCH CASE

            /*
            int x = int.Parse(Console.ReadLine());

            string day;

            // IF ELSE

            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3) 
            {
                day = "Tuesday";
            }
            else if (x == 4) 
            {
                day = "Wednesday";
            }
            else if(x == 5) 
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invlaid value";
            }

            Console.WriteLine("Dia: " + day);

            // SWITCH CASE

            switch (x)
            { 
                case 1:
                    day = "Sunday";
                    break;        
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;            
                case 4:
                    day = "Wednesday";
                    break;            
                case 5:
                    day = "Thursday";
                    break;            
                case 6:
                    day = "Friday";
                    break;            
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
            */

            #endregion

            #region CONDICIONAL TERNÁRIA

            /*
            Estrutura opcional ao if-else quando se deseja decidir um VALOR com base
            em uma condição
            */

            // SINTAXE

            // (condição) ? valor se verdadeiro : valor_se_falso

            // EXEMPLOS

            /*
            (2 > 4) ? 50 : 80;  ---------- > 80 (Como a expressão deu falso o cai para o 80)

            (10 != 3) ? "Maria" : "Alex"------------ > "Maria"; (Como a expressão deu verdadeiro o cai para o "Maria")
            */

            //  EXEMPLO IF ELSE

            /*
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);
            */

            // EXEMPLO CONDICIONAL TERNÁRIA

            /*
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
            */

            #endregion

            #region FUNÇÕES INTERESSANTES PARA STRING

            /*
            string original = "abcde FGHIJ ABC abc DEFG    ";
            string s1 = original.ToUpper(); // Transforma tudo pra maiúsculo
            string s2 = original.ToLower(); // Transforma tudo em minúsculo
            string s3 = original.Trim(); // Apaga os resultados em branco antes ou depois
            
            int n1 = original.IndexOf("bc"); // Descobre a primeira ocorrencia do que foi inserido como parâmetro baseado na posicão
            int n2 = original.LastIndexOf("bc"); // Descobre a ultima ocorrencia do que foi inserido como parâmetro baseado na posicão

            string s4 = original.Substring(3); // Cortar um pedaço da string a partir da posição informada como parametro
            string s5 = original.Substring(3, 5); // Cortar um pedaço da string a partir da posição informada como parametro, mas definindo quantos cortar

            string s6 = original.Replace("a", "x"); // Substituir uma parte da string por outra informando respectivamente no parametro 
            string s7 = original.Replace("abc", "xy"); // Substituir uma parte da string por outra informando respectivamente no parametro 

            bool b1 = String.IsNullOrEmpty(original); // Verifica se o conteúdo da variável é nulo ou vazio (Util para criação de formulário)
            bool b2 = String.IsNullOrWhiteSpace(original); // Verifica se o conteúdo da variável é nulo ou espaços em branco (Util para criação de formulário)

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf('bc'): -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");
            */

            #endregion

            #region DATETIME

            // CONSTRUTORES MAIS UTILIZADOS

            DateTime d2 = new DateTime(2018, 11, 25); // Instancia dia, mes e ano passados como parametro
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); // Instancia horas, minutos, segundos, dia, mes e ano passados como parametro
            Console.WriteLine(d3);

            // BUILDERS BÁSICOS

            DateTime d1 = DateTime.Now; // Horário atual local
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d4 = DateTime.Today; // Data de hoje mas com o horário 00:00
            Console.WriteLine(d4);

            DateTime d5 = DateTime.UtcNow; // Horário no meridiano de Greenwich UTC
            Console.WriteLine(d5);

            // PARSE

            DateTime d6 = DateTime.Parse("2000-08-15"); // Formato utilizado em banco de dados
            Console.WriteLine(d6);
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d9);

            // PARSEEXACT

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Passa o parametro no formato de banco de dados e como ele tem que ser analisado respectivamente
            Console.WriteLine(d10);
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

            #endregion

        }
    }
}