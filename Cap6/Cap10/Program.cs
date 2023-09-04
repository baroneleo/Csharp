using System;
using Cap10.Entities;
using Cap10.Exercise;
using System.Globalization;
using Microsoft.Win32;
using System.Drawing;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using Cap10.Exercise2;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Herança

            /*
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);

            // account.Balance = 200.00; -> Não é possíbel pois o Balance é protected set (só pode ser alterado em uma subclasse)
            */

            #endregion

            #region Upcasting / Downcasting

            /*
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // Subclasse
            Account acc3 = new SavingAccount(1004, "Ana", 0.0, 0.01); // Superclasse

            // DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2; -> Especificando antes
            //acc4.Loan(100.0);

            //BusinessAccount acc4 = acc2 as BusinessAccount; -> Especificando usando o "as"
            //acc4.Loan(100.0);
                        
            //BusinessAccount acc5 = acc3;
            
            // Verificando o tipo de instancia para poder verificar


            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount) acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount) acc3;
                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

            #endregion

            #region Sobreposição

            /*
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */

            #endregion

            #region Exercício Resolvido

            // ENUNCIADO

            /*
            Uma empresa possui funcionários próprios e terceirizados.
            Para cada funcionário, deseja - se registrar nome, horas
            trabalhadas e valor por hora.Funcionários terceirizados
            possuem ainda uma despesa adicional.
            O pagamento dos funcionários corresponde ao valor da hora
            multiplicado pelas horas trabalhadas, sendo que os
            funcionários terceirizados ainda recebem um bônus
            correspondente a 110 % de sua despesa adicional.
            Fazer um programa para ler os dados de N funcionários(N
            fornecido pelo usuário) e armazená-los em uma lista.Depois
            de ler todos os dados, mostrar nome e pagamento de cada
            funcionário na mesma ordem em que foram digitados.
            Construa o programa conforme projeto ao lado.Veja
            exemplo na próxima página.
            */

            // RESOLUÇÃO

            /*
            List<Employee> list = new List<Employee>();
                
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Employee {i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, valuePerHour, hours));
                }
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            #endregion

            #region Exercício de Fixação

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)");
                char type = char.Parse(Console.ReadLine());
                
                if(type == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufactured date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product prod in list)
            {
                Console.WriteLine(prod.Pricetag());
            }

            #endregion

        }
    }
}