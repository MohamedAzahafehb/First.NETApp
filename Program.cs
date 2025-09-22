// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

//opdracht morgen: String omkeren
Console.WriteLine("Geef een woord in: ");
String woord = Console.ReadLine();

Array charWoord = woord.ToCharArray(); // method ToCharArray() gevonden op https://learn.microsoft.com/en-us/dotnet/api/system.string.tochararray?view=net-9.0
/*
foreach (var ch in charWoord)
{
    Console.WriteLine(ch);
}
Het werkt!
*/

Console.WriteLine("Welke omkeermethode kiest u? 1-4");
Console.WriteLine("1. for loop");
Console.WriteLine("1. while loop");
Console.WriteLine("3. do-while loop");
Console.WriteLine("4. recursie");
int keuze = Convert.ToInt16(Console.ReadLine());

int i = 1;

String newWoord = "";


switch (keuze)
{
    case 1:
        for (i = charWoord.Length -1; i >= 0; i--)
        {
            //Console.WriteLine("index: " + i);
            //Console.WriteLine(charWoord.GetValue(i));
            newWoord += charWoord.GetValue(i);
        }
        
        break;

    case 2:
        i = charWoord.Length-1;
        while (i >= 0)
        {
            newWoord += charWoord.GetValue(i);
            i--;
        }
        
        break;

    case 3:
        i = charWoord.Length - 1;
        do
        {
            newWoord += charWoord.GetValue(i);
            i--;
        }
        while (i >= 0);
        
        break;

    case 4:
        string keerWoordOm(string word) // code van: https://stackoverflow.com/questions/57800847/how-to-reverse-word-in-a-string-using-1-recursive-function-c-sharp
        {
            //Console.WriteLine(word);
            if (word[0] == word[word.Length - 1]) return word[0].ToString();
            if (word[0] == ' ') return word;
            return keerWoordOm(word.Substring(1)) + word[0];
        }

        newWoord = keerWoordOm(woord);
        break;

    default:
        Console.WriteLine("ongeldige keuze!");
        break;
}
Console.WriteLine("Het woord omgekeerd is:");
Console.WriteLine(newWoord);




/*
// overschreven van het bord:

/*
faculteit in:
1- for loop
2- while loop
3- do-while-loop
4- recursie
*/

/*

Console.WriteLine("Geef het getal: ");
int getal = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Geef de keuze aan: ");
int keuze = Convert.ToInt16(Console.ReadLine());


long nFaculteit = 1;
int i = 1;

switch (keuze)
{
    case 1:
        // fro-loop
        for(int index = getal; index > 1; index--)
        {
            nFaculteit += 1;
        }
        break;
    case 2:
        // while-loop
        while (i <= keuze)
        {
            nFaculteit += 1;
            i++;
        }
        break;
    case 3:
        // do while loop
        do
        {
            nFaculteit += i;
            i++;
        }
        while (i <= getal);
        break;
    case 4:
        // recursie
        long Faculteit(int n)
        {
            if (n <= 1) return 1;
            return n * Faculteit(n - 1);
        }
        nFaculteit = Faculteit(getal);
        break;
    default:
        Console.WriteLine("ongeldige keuze!");
        break;
}

Console.WriteLine(getal + "! = " + nFaculteit);
*/