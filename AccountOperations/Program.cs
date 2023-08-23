using AccountOperations.Models;

Console.WriteLine("Начальный баланс");
var balance = Convert.ToDecimal(Console.ReadLine());

var account = new Account
{
    Id = 1,
    Name = "Счет карты",
    Balance = balance,
    Number = "2020_5252_1111_6666",
    BlockedBalance = 0,
    AccountType = ((int)AccountType.Map),
    Status = ((int)Status.Working),
};

var operation = new Operation();

Console.WriteLine("Снятие");
var amount = Convert.ToDecimal(Console.ReadLine());

operation.Withdraw(account, amount);

Console.WriteLine("Пополнение");
amount = Convert.ToDecimal(Console.ReadLine());

operation.Replenish(account, amount);

