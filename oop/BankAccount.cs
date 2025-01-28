namespace OOP
{
    public class BankAccount : CryptoWallet
    {
        //properties
        //fields
        //methods

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public decimal Balance { get; private set; }


        public BankAccount(string AccountName, string AccountNumber, decimal initialBalance)
        {
            this.AccountName = AccountName;
            this.AccountNumber = AccountNumber;
            this.Credit(initialBalance);
        }

        public BankAccount()
        {

        }


        public decimal Credit(decimal amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        public decimal Debit(decimal amount)
        {
            if (this.Balance <= 0)
                return 0;

            this.Balance -= amount;
            return this.Balance;
        }

    }
}