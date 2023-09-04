using System;
using Cap10.Entities;

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

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            #endregion

        }
    }
}