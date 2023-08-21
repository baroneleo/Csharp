using System;
using System.Globalization;
using Cap9.Entities;
using Cap9.Entities.Enums;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ENUMERATE

            /*
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Convertendo string pra Enumerate

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Convertendo Enumerate pra string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            */

            #endregion

            #region Exercício Resolvido

            // ENUNCIADO

            /*
            Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
            do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo.
            */

            Console.Write("Enter department's name: ");
            string deptname = Console.ReadLine();
            
            Console.WriteLine("Enter worker data:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Level (Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Department dept = new Department(deptname);

            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            #endregion

        }
    }
}