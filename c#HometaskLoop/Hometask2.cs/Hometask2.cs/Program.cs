using System;

class Hometask2  // 2 - Daxil edilən müsbət tam ədədin palindrom olub-olmamasını yoxlayın
{
    static void Main(String[] arg)
    {
        int givenNumber = 128;
        int palindrom = 0;
        int myNumber = givenNumber;

        if (myNumber > 0)
        {
            while (givenNumber >= 1)
            {

                palindrom = palindrom * 10 + ((givenNumber % 10)); //8  2  1
                                                                   //Console.WriteLine(palindrom);
                givenNumber = ~~(givenNumber / 10); //12 1 

            }

            Console.WriteLine("our palindrom of " + myNumber + " is : " + palindrom);

            if (palindrom == myNumber)
            {
                Console.WriteLine("Due to this, this number has palindrom ");
            }
            else
            {
                Console.WriteLine("Due to this, this number has not  palindrom");

            }
        }
        else
        {
            Console.WriteLine(" Musbet eded daxil edin!");
        }

    }
}
