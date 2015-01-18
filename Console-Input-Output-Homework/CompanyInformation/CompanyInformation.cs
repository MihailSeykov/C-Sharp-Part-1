using System;

//Write a program that reads the information about a company and its manager and prints it back on the console.

class Program
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter comapny adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        string age = Console.ReadLine();
        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Addres: " + companyAdress);
        Console.WriteLine("Tel: " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine(firstName + " " + lastName + "(age: {0}, tel. {1})", age, managerPhone);


    }
}

 