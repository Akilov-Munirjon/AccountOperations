namespace AccountOperations.Models
{
    public class Operation
    {   
        private decimal Commision;  

        public void ShowBalance(Account account, decimal amount)
        {
            Console.WriteLine($"На нашем счету: {account.Balance} smn");
        }
          
        public void Withdraw(Account account, decimal amount) 
        {           
            decimal sum = Convert.ToDecimal(amount);

            account.Status = (int)Status.Processed;

            if (sum > account.Balance)
            {
                account.Status = (int)Status.Denied;

                Console.WriteLine($"Недостаточно средств на балансе!! {account.Balance}");
            }
            else
            {
                if (account.AccountType == (int)AccountType.Map)
                {
                    Commision = sum * 0.002m;

                    account.Balance -= (sum + Commision);

                    Console.WriteLine($"Вы сняли с карты: {sum} smn");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Остаток баланса: {account.Balance} smn");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Kоммисия: {Commision} smn");
                    
                }
                else if (account.AccountType == (int)AccountType.Bonus_account)
                { 
                    Commision = sum * 0;
                    
                    account.Balance -= (sum + Commision);       

                    Console.WriteLine($"Вы сняли с карты: {sum} smn");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Остаток баланса: {account.Balance} smn");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Kоммисия: {Commision} smn");
                }
            }
            account.Status = (int)Status.Working;
        }

        public void Replenish(Account account, decimal amount) 
        {
            if (amount > 0)
            {
                account.Balance += amount;

                Console.WriteLine($"Начисление {amount} smn на карту успешно произведено");
                Thread.Sleep(2000);
                Console.WriteLine($"Balance {account.Balance} smn");
            }
        }

    }
}
