class Enums
{
    /*
        ENUM är en speciell datatyp som används för att 
        definiera en samling av namngivna konstanta värden. 
        
        enums kan användas för att ge mer läsliga namn till 
        uppsättningar av relaterade värden, 
        istället för att använda magiska tal eller strängar.
    */

    //En enum för dagarnas namn. Enklare att förstå än att använda siffror.
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static public void Run()
    {
        Day today = Day.Monday;
        Console.WriteLine(today);
        Console.WriteLine((int)today);
        Console.WriteLine(today.ToString());
        Console.WriteLine((int)Day.Sunday);
        Console.WriteLine((Day)6);

        //Inbyggda enums
    }
}