using System;
    class TheHorror
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long length = number.ToString().Length;
            long digitSum = 0;
            long digitsAmount = 0;
            long digit = 0;
            for (long position = 1; position <= length; position++)
            {
                if (number == 0)
                {
                    break;
                }
                digit = number % 10;
                if (position % 2 == 0)
                {
                    digitSum = digitSum + digit;
                    digitsAmount++;
                }
                number = number / 10;
            }
            Console.WriteLine("{0} {1}", digitsAmount, digitSum);
            Main();
        }
       
    }

