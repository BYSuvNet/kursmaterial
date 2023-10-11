
/*
    OBJEKTORIENTERAD PROGRAMMERING

    INKAPSLING: * Handlar om att gruppera data (attribut) och metoder som opererar på datan
                  i en enhet kallad en klass.
                * Kontrollerar åtkomst till objektens inre tillstånd genom publika, privata och 
                  skyddade åtkomstmodifierare (public, private, protected).
                * Döljer komplexitet och detaljer genom att endast exponera det som är nödvändigt 

    ARV: * Gör det möjligt för en klass att ärva egenskaper och metoder från en annan klass.
         * En klass som ärver från en annan klass kallas för subklass, underklass, barnklass.
         * En klass som en annan klass ärver från kallas för basklass, superklass, förälderklass.
    
    POLYMORFISM: * Ett koncept där objekt kan hanteras som instanser av deras basklass 
                   eller subklass snarare än deras faktiska datatyp.
                 * En metod kan ha flera implementeringar beroende på objektet det kallas på.
                 * Method Overloading och Method Overriding är polymorfiska begrepps

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
    //Vi skapar tre studenter
    string input = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    Student student1 = new Student(input, age, "BY");

    input = Console.ReadLine();
    Student student2 = new Student(input, 30, "BY");

    Student student3 = new Student("gunnel", 40, "BY");

    //Och en lärare
    Teacher teacher1 = new Teacher("gus", 42);

    Console.WriteLine($"Totalt {Person.Count} personer finns");

    //Vi skapar en lista som kan innehålla objekt av Person-typ eller objekt som ärver från Person-klassen
    List<Person> people = new();

    //Iom att student och teacher ärver från Person kan de läggas i listan
    people.Add(student1);
    people.Add(student2);
    people.Add(student3);
    people.Add(teacher1);

    foreach (Person item in people)
    {
      //Skicka alla personer till WriteLine()
      //WriteLine tar emot objekt av typen 'object'
      //Object-klassen definierar en metod som heter ToString()
      //Den används för att skriva ut objekten till terminalen
      //Vi anänder en override i Student och Teacher för att ändra standardbeteendet.
      Console.WriteLine(item);
    }

  }
}

//En vanlig klass med några properties (data, information) och metoder (funktion, beteende)
class Person
{
  public static int Count { get; set; } = 0;
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
    Count++;
  }
}

//Studentklassen ärver från Person
class Student : Person
{
  public string School { get; set; }

  public Student(string name, int age, string school) : base(name, age)
  {
    School = school;
  }

  public override string ToString()
  {
    return $"{Name} is {Age} years of age.";
  }
}

class Teacher : Person
{
  public int Salary { get; set; }

  public Teacher(string name, int age) : base(name, age)
  { }

  public override string ToString()
  {
    return "TEACHER!";
  }
}