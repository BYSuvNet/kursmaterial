class Casting
{
    /*
        Casting är processen att omvandla en variabel från en datatyp till en annan. 
        Det är som att säga till datorn: "Även om du ser denna data som en typ av värde, 
        vill jag att du behandlar den som en annan typ för tillfället."

        ? När kan casting vara bra att använda?
        ? Vad är skillnaden mellan implicit och explicit casting?
        ? Vad är upcasting och downcasting?
        ? Vad är skillnaden mellan casting och parsning?
    */

    static public void Run()
    {
        //Det finns implicit (automatisk) casting:
        {
            int i = 65;
            float f = i; //från int till float tappar vi ingen information
            Console.WriteLine($"i: {i}   f: {f:f1}");
        }

        //Sen finns det explicit (manuell) casting:
        {
            float f = 1.23f;
            //från float till int tappar vi information
            int i = (int)f;
            Console.WriteLine($"f: {f} i: {i}");
            //Exempel som delar int med int och sen castar: (imp. och exp. casting)
            Console.WriteLine((float)1 / 2);
        }

        //Fler exempel på casting:
        {
            //sätt en int till 65
            int i = 65;
            //sätt en char till A och skriv ut
            char c = 'A';
            Console.WriteLine($"i: {i}   c: {c}");
            Console.WriteLine($"i: {(char)i}   c: {(int)c}");
        }

        //Casting och egna objekt
        {
            //Upcasting: Säkert och implicit. deklarera Person-variabel, casta ett Person-objekt till Student

            //Downcasting: Osäkert och explicit. Deklarera Student-variabel, casta ett Student-objekt till Person

            //as-operatorn jämfört med cast-operatorn
        }
    }
}