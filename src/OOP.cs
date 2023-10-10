
/*
    OBJEKTORIENTERAD PROGRAMMERING

    INKAPSLING: * Handlar om att gruppera data (attribut) och metoder som opererar på datan
                  i en enhet kallad en klass.
                * Kontrollerar åtkomst till objektens inre tillstånd genom publika, privata och 
                  skyddade åtkomstmodifierare (public, private, protected).
                * Döljer komplexitet och detaljer genom att endast exponera det som är nödvändigt 

    ARV: * Gör det möjligt för en klass att ärva egenskaper och metoder från en annan klass.
         * En klass som ärver från en annan klass kallas för subklass, underklass, barnklass eller underklass.
         * En klass som en annan klass ärver från kallas för basklass, superklass, förälderklass.
    
    POLYMORFISM: * Ett koncept där objekt kan hanteras som instanser av deras basklass 
                   eller subklass snarare än deras faktiska datatyp.
                 * En metod kan ha flera implementeringar beroende på objektet det kallas på.

    ABSTRAKTION: * Abstraktion är en av de viktigaste principerna i OOP.
                 * Handlar om att representera komplexa verkliga föremål eller system 
                   som programmeringsmässiga entiteter (klasser).
                 * Dölj onödiga detaljer och fokuserar på högnivåfunktionalitet.
                 * Hjälper till att bryta ner komplexa system i mindre, mer hanterbara delar.
                 * -> Inkapsling, arv och polyorfism möjliggör Abstraktion.

*/

// static, konstruktorer och arv, base, virtual/override, overload, abstract, this, 
class OOP
{
    public static void Run()
    {

    }
}

//En vanlig klass med några properties (data, information) och metoder (funktion, beteende)
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

//Studentklassen ärver från Person
class Student : Person
{
    public string School { get; set; }
}