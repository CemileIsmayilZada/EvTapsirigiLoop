using System;

class Hometask1
{
    static void Main(String[] Args)
    {
        /* 1 - Verilmiş ədədin ikinin qüvvəti olub olmadığını yoxlayan alqoritm yazın */
        int givenNumber = 13;
        bool answer = false;
        int numb = 2;
        int index=0;
        if (givenNumber >= 0)
        {
            for (int i = 0; i <= (givenNumber / 2); i++)
            {
                /**tek 2,4 olanda yarsi qeder quvvet olur,diger hallarda
                 *  yarisindan az olur deye givenNumber/2 den <= yazdim 
                 *  bir de givenNumbere qeder axtarmasin ,vaxt ve yaddas itkisi olmasin
                */

                if ((numb ^ i) == givenNumber)
                {
                    answer = true ;
                    index=i;
                    break;
                }
                else
                {
                    answer=false;
                }



            }
            if (answer = true)
            {
                Console.WriteLine("this number is " + i + " times power of 2");
            }
            else
            {
                Console.WriteLine("this number is not any power of 2");
            }
            
        }
        else
        {
            Console.WriteLine("Your number must be positive!!!!");
        }

    }
}