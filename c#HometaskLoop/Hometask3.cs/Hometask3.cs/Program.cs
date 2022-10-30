using System;

class Hometask3  // 3 - Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın
{
    static void Main(String[] args)
    {
        int number = 3;
        bool check = false;
        if (number < 0)
        {
            Console.WriteLine("Enter positive number! ");
        }
        else if (number == 0 || number == 1)
        {
            Console.WriteLine("It is not Prime or Composite number");

        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number / i == 0)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                Console.WriteLine("Number is Composite number ");
            }
            else
            {
                Console.WriteLine("Number is Prime number ");
            }


        }
    }
}
