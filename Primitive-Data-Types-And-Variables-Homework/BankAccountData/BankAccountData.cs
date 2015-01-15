using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and 
//descriptive names.

class BankAccountData
{
    static void Main()
    {
        string bank = "Fibank";
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        string balance = "10000 leva";
        string iBan = "BG20FINV91508947689506";
        string card1 = "7856 8957 5184 7836";
        string card2 = "8965 7412 8763 1235";
        string card3 = "7894 5612 1236 9874";
        object holderName = firstName + " " + middleName + " " + lastName;

        Console.WriteLine("Bank: " + bank);
        Console.WriteLine("Holder name: " + holderName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("IBAN: " + iBan);
        Console.WriteLine("Credit card number: " + card1);
        Console.WriteLine("Credit card number: " + card2);
        Console.WriteLine("Credit card number: " + card3);

    }
}

