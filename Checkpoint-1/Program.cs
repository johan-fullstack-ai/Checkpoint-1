// Checkpoint 1, nivå 3


string[] products = new string[0];
int index = 0;

Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'");

while (true)
{
    Console.Write("Ange produkt: ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Du får inte ange ett tomt värde");
        Console.ResetColor();
        continue;
    }

    input = input.Trim();

    if (input.ToLower() == "exit")
        break;

    // Dela på bindestreck
    string[] parts = input.Split('-');
    if (parts.Length != 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt format: produkten måste innehålla ett bindestreck");
        Console.ResetColor();
        continue;
    }

    string left = parts[0].Trim();
    string right = parts[1].Trim();

    // Kontrollera vänstra delen: endast bokstäver
    if (left.Length == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt format på vänstra delen av produktnumret");
        Console.ResetColor();
        continue;
    }

    bool onlyLetters = true;
    foreach (char c in left)
    {
        if (!char.IsLetter(c))
        {
            onlyLetters = false;
            break;
        }
    }

    if (!onlyLetters)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt format på vänstra delen av produktnumret");
        Console.ResetColor();
        continue;
    }

    // Kontrollera högra delen: heltal
    bool isNumber = int.TryParse(right, out int number);
    if (!isNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt format på högra delen av produktnumret");
        Console.ResetColor();
        continue;
    }

    // Kontrollera intervall
    if (number < 200 || number > 500)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Den numeriska delen måste vara mellan 200 och 500");
        Console.ResetColor();
        continue;
    }

    // Lägg till i array
    Array.Resize(ref products, index + 1);
    products[index] = $"{left}-{number}";
    index++;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Produkten accepterad");
    Console.ResetColor();
}

// Sortera
Array.Sort(products);

Console.WriteLine("\nDu angav följande produkter (sorterade):");
foreach (var p in products)
{
    Console.WriteLine("* " + p);
}




