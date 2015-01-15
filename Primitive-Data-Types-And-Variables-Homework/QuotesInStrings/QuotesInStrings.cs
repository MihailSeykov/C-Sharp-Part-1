using System;

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined..

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string quotedString = "The \"use\" of quotations cause difficulties.";
            Console.WriteLine(quotedString);
            string notQuotedString = "The use of quotations cause difficulties.";
            Console.WriteLine(notQuotedString);
        }
    }
}
