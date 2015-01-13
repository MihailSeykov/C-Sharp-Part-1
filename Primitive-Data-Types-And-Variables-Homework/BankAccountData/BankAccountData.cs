using System;


    class BankAccountData
    {
        static void Main(string[] args)
        {
            string bank = "Fibank";
            string fname = "Ivan";
            string mname = "Ivanov";
            string lname = "Ivanov";
            string balance = "10000 leva";
            string iban = "BG20FINV91508947689506";
            string card1 = "7856 8957 5184 7836";
            string card2 = "8965 7412 8763 1235";
            string card3 = "7894 5612 1236 9874";
            object holdername = fname + " " + mname + " " + lname;

            Console.WriteLine("Bank: " + bank);
            Console.WriteLine("Holder name: " + holdername);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("Credit card number: " + card1);
            Console.WriteLine("Credit card number: " + card2);
            Console.WriteLine("Credit card number: " + card3);

        }
    }

