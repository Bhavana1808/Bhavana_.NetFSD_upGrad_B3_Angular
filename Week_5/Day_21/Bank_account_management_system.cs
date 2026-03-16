namespace ConsoleApp9 { 
        
class BankAccount
        {
            private int accountNumber;
            private double balance;

            public int AccountNumber
            {
                get { return accountNumber; }
                set { accountNumber = value; }
            }

            public double Balance
            {
                get { return balance; }
                private set { balance = value; }
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine("Deposit Successful");
                }
                else
                {
                    Console.WriteLine("Invalid Deposit Amount");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient Balance");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful");
                }
            }

            public void ShowBalance()
            {
                Console.WriteLine("Current Balance = " + balance);
            }
        }

        class Program
        {
            static void Main()
            {
                BankAccount acc = new BankAccount();

                acc.AccountNumber = 101;

                acc.Deposit(5000);
                acc.Withdraw(2000);

                acc.ShowBalance();
            }
        }
    }
    

