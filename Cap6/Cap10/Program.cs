using System.Globalization;
using System.Drawing;
using Cap10.Exercise3;
using Cap10.Exercise4;
using System.Diagnostics.CodeAnalysis;
using Cap10.Entities;
using Cap10.Entities.Exceptions;

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

            /*
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
            */

            #endregion

            #region Classes Abstratas

            /*
            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = 0.0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Update balance for account: " 
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            #endregion

            #region Métodos Abstratos

            /*
            
            - São metodos que não possuem implementação.

            - Métodos precisam ser abstratos quando a classe
              é genérica demais para conter sua implementação.

            - Se uma classe possuir pelo menos um método
              abstrato, então esta classe também é abstrata.

            */

            #endregion

            #region Exercício Métodos e Classes Abstratas

            /*
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            #endregion

            #region Exercício proposto

            // ENUNCIADO

            /*
            Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais 
            podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um, 
            bem como o total de imposto arrecadado. 
            Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica 
            são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as 
            seguintes:
            Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com 
            renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50% 
            destes gastos são abatidos no imposto. 
            Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto 
            fica: (50000 * 25%) - (2000 * 50%) = 11500.00
            Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10 
            funcionários, ela paga 14% de imposto. 
            Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 
            400000 * 14% = 56000.00
            */

            // RESOLUÇÃO

            /*
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer {i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            
            double sum = 0.0;
            
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            
            foreach (TaxPayer payer in list)
            {
                double tax = payer.Tax();
                Console.WriteLine(payer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum =+ tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
            */

            #endregion

            #region Tratamento de exceções (Try-Catch)

            /*
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("Format error " + ex.Message);
            }
            */

            // Utilizando Finally

            /*
            FileStream fs = null;

            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            */

            #endregion

            #region Exercício de fixação

            /*
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            */

            #endregion

        }
    }
}