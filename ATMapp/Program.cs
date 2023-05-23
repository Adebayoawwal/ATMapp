public class cardHolder
{
    String cardnum;
    int pin;
    String FirstName;
    String LastName;
    double balance;
    public cardHolder(String cardnum, int pin, String FirstName, String lastName, double balance)
    {
        this.cardnum = cardnum;
        this.pin = pin;
        this.FirstName = FirstName;
        this.balance = balance;
        this.LastName = lastName;
    }

    public String getNum()
    {
        return cardnum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getLastName()
    {
        return LastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public String getFirstName()
    {
        return FirstName;
    }
    public void setNum(String newcardnum) 
    {
        cardnum = newcardnum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
        FirstName = newFirstName;
    }
    public void setLastname(String newLastName)
    {
        LastName = newLastName;
    }
    public void setbalance(double newBalance)
    {
        balance = newBalance;
    }
    public static void main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would like to deposit:");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setbalance(deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is:" + currentUser.getBalance());
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would like to withdraw:");
            double withdraw = Double.Parse(Console.ReadLine());
            if (currentUser.getBalance() > withdraw)
            {
                Console.WriteLine("Insufficient balance: (");
            }
            else
            {
                currentUser.setbalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You're good to go! Thank you: )");
            }

        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance :" + currentUser.getBalance());
        }
        List<cardHolder> cardHolder = new List<cardHolder>();
        cardHolder.Add(new cardHolder("346656878687898989756", 1234, "john", "khadjat", 150.1));
        cardHolder.Add(new cardHolder("346656878687898989756", 1234, "aishat", "ade", 1230.31));
        cardHolder.Add(new cardHolder("346656878687898989756", 1234, "Frida", "adebayo", 140.31));
        cardHolder.Add(new cardHolder("346656878687898989756", 1234, "Muneeb", "salaudeen", 130.31));
        cardHolder.Add(new cardHolder("346656878687898989756", 1234, "Dawn", "bayo", 1340.31));

        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card:");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolder.FirstOrDefault(a => a.cardnum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognied.Please try again."); }
            }
            catch { Console.WriteLine("Card not recognied.Please try again."); }
        }
        Console.WriteLine("Please enter your pin:");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin.Please try again."); }
            }
            catch { Console.WriteLine("Incorrect pin.Please try again."); }
        }

        Console.WriteLine("Welcome" + currentUser.getFirstName() + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }

            catch { }
            if (option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! have a nice day :)");
    }   
}