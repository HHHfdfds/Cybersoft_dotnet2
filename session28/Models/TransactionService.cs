public class TransactionService
{
    public decimal Balance { get; private set; } = 0;
    public List<Transaction> Transactions { get; private set; } = new();

    public void AddTransaction(string type, decimal amount)
    {
        if (type == "Withdraw" && amount > Balance)
            return;

        Balance += type == "Deposit" ? amount : -amount;
        Transactions.Add(new Transaction { Type = type, Amount = amount, Date = DateTime.Now });
    }
}
