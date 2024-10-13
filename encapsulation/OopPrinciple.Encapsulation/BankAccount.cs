namespace OopPrinciple.Encapsulation
{
    public class BankAccount
    {
        private string accountNumber;
        private string accountName;
        private decimal balance;

        private const decimal zero = 0;

        public BankAccount(string accountNumber, string accountName, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
        }

        public string GetAccountName()
        {
            return accountName;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount, nameof(amount));

            balance += amount;
            Console.WriteLine($"Amount deposited successfully. New balance is: { balance }");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance)
                ArgumentOutOfRangeException.ThrowIfLessThan(amount, zero, nameof(amount));

            balance -= amount;
            Console.WriteLine($"Amount withdrawed scuusessfully. New balance is: {balance}");
        }
    }
}
