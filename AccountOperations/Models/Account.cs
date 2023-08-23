namespace AccountOperations.Models
{
    public class Account
    {
        public int Id;
        public string Name { get; set; } 
        public string Number = "20202972123456123";
        public decimal Balance;
        public decimal BlockedBalance;
        public int Status;
        public int AccountType;
    }
}
ё