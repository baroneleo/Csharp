using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

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

            /*
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
            */

            #endregion

            #region TIMESPAN

            /*
            Um objeto TimeSpan internamente armazena uma duração na forma
            de ticks (100 nanosegundos)
            */

            /*
            TimeSpan t1 = new TimeSpan(0, 1, 30); // Passando horas, minutos e segundos
            Console.WriteLine(t1); // Imprime no modo 1:30:00
            Console.WriteLine(t1.Ticks); // Imprime em Ticks (nanosegundos)
            
            TimeSpan t2 = new TimeSpan(); // Sem parametro passa valor (00:00:00
            Console.WriteLine(t2); // Imprime 00:00:00

            TimeSpan t3 = new TimeSpan(900000000); // Passa o valor em nanosegundos
            Console.WriteLine(t3); // Imprime no formato padrão 1:30:00

            TimeSpan t4 = new TimeSpan(1, 2, 30, 30); // Passando dia, hora, minuto e segundo
            Console.WriteLine(t4); // O dia pra hora é impresso de maneira diferente 1.2:30:30

            TimeSpan t5 = new TimeSpan(1, 2, 30, 30, 321); // Passando dia, hora, minuto, segundos e milisegundos
            Console.WriteLine(t5); //  Os milisegundos também é impresso de maneira diferente 1.2:30:30

            // TimeSpan com propriedades diferentes

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromTicks(900000000);
            Console.WriteLine(t11);
            */

            #endregion

            #region PROPRIEDADES COM DATETIME

            /*
            DateTime d = new DateTime(2023, 8, 05);

            DateTime d2 = new DateTime(2023, 8, 12);

            TimeSpan t = d2.Subtract(d);
            */

            /*
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Milisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine(d.ToLongDateString());
            */

            /*
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            */

            //  OPERAÇÕES COM DATETIME

            //DateTime d2 = d.Add(TimeSpan);

            /*
            DateTime d3 = d.AddDays(34);
            Console.WriteLine(d3);

            DateTime d4 = d.AddHours(7);
            Console.WriteLine(d4);

            DateTime d5 = d.AddMilliseconds(123546);
            Console.WriteLine(d5);

            DateTime d6 = d.AddMinutes(37);
            Console.WriteLine(d6);

            DateTime d7 = d.AddMonths(16);
            Console.WriteLine(d7);

            DateTime d8 = d.AddSeconds(4568);
            Console.WriteLine(d8);

            DateTime d9 = d.AddTicks(15044354198465);
            Console.WriteLine(d9);

            DateTime d10 = d.AddYears(54);
            Console.WriteLine(d10);
            */

            /*
            DateTime x = DateTime.Now;
            Console.WriteLine(x);

            DateTime y = x.AddDays(7);
            Console.WriteLine(y);
            */

            #endregion

            #region PROPRIEDADES COM TIMESPAN



            #endregion

        }
    }
}