class Operatorer
{
    static public void Run()
    {
        //Tilldelningsoperatorer: (likamedtecknet är tilldelningsoperatorn som tilldelar värdet 5 till a)
        int a = 5;
        Console.WriteLine($"a: {a}");

        //Aritmetiska operatorer (+, -, *, /, %)
        int sum = 5 + 10;  // 15
        int diff = 5 - 10; // -5
        int prod = 5 * 10; // 50
        int quot = 5 / 10; // 0
        int mod = 5 % 10;  // 5
        Console.WriteLine($"sum: {sum}, diff: {diff}, prod: {prod}, quot: {quot}, mod: {mod}");

        //Ökningsoperatorer (++, --)
        int i = 0;
        i++; // i = i + 1;
        i--; // i = i - 1;
        i += 5; // i = i + 5;
        i -= 5; // i = i - 5;
        i *= 5; // i = i * 5;
        i /= 5; // i = i / 5;
        i %= 5; // i = i % 5;
        Console.WriteLine($"i: {i}");

        //Jämförelseoperatorer (==, !=, >, <, >=, <=)  
        //Parenteserna behövs inte, de är bara med för att visa tydligare vad som hör ihop
        bool isEqual = (5 == 5);  // true
        bool isNotEqual = (5 != 10);  // true
        bool isGreaterThan = (10 > 5);  // true
        bool isLessThan = (5 < 10);  // true
        bool isGreaterThanOrEqual = (5 >= 5);  // true
        bool isLessThanOrEqual = (5 <= 10);  // true
        Console.WriteLine($"isEqual: {isEqual}, isNotEqual: {isNotEqual}, isGreaterThan: {isGreaterThan}, isLessThan: {isLessThan}, isGreaterThanOrEqual: {isGreaterThanOrEqual}, isLessThanOrEqual: {isLessThanOrEqual}");


        //Logiska operatorer (&&, ||, !)
        bool bothTrue = (5 < 10 && 3 < 5);  // true
        bool eitherTrue = (5 < 3 || 3 < 5);  // true
        bool notTrue = !(5 < 3);  // true
        Console.WriteLine($"bothTrue: {bothTrue}, eitherTrue: {eitherTrue}, notTrue: {notTrue}");

        //Ternary operator (?:)
        int x = 5;
        int y = (x == 5) ? 10 : 20;  // y = 10
        Console.WriteLine($"y: {y}");

        /* Utöver dessa finns också:
        
            ternary operator (?:)
            null-coalescing operator (??)
            null-conditional operator (?.)
            is, as, sizeof och typeof

            Se mer om dessa i OOP.cs
        */
    }
}