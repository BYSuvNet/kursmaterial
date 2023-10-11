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

    static public void Run()
    {
        Player p = new Player();
        p.Position = Position.Goalkeeper;

        if (p.Position == Position.Goalkeeper)
        {

        }

        Day today = Day.Monday;

        Console.WriteLine(today);
        Console.WriteLine(today.ToString());

        Console.WriteLine((int)today);
        Console.WriteLine((int)Day.Sunday);

        //Från string via ReadLine, 
        //till int via Parse 
        //till Day-enum via casting
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine((Day)i);

        //Inbyggda enums
        Console.BackgroundColor = ConsoleColor.Green;
    }
}

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

enum Position
{
    Forward,
    Defender,
    Halfback,
    Midfielder,
    Goalkeeper
}

class Player
{
    public Position Position { get; set; }
}