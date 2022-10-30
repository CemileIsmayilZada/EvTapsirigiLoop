using System;

class Hometask4 // 4 - Ay(month) adı daxil edilir. Çıxışa hansı fəsil olduğunu yazdırsın (switch case ilə yazın) 

{
    static void Main(String[] args)
    {

       string monthName = "March";

        switch (monthName)
        {
            case "December":
            case "January":
            case "February":
                Console.WriteLine(" Season:  Winter");
                break;
            case "March":
            case "April":
            case "May":
                Console.WriteLine("Season : Spring ");
                break;
            case "June":
            case "July":
            case "August":
                Console.WriteLine("Season : Summer ");
                break;
            case "September":
            case "October":
            case "November":
                Console.WriteLine("Season : Autumn ");
                break;
            default: 
                Console.WriteLine(" please ,enter Month name correctly !");
                break;
        }
    }
}
