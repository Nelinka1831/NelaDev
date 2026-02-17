
int[] numbers = { 5, 3, 8, 5, 2, 3, 9, 1, 4, 8, 8, 6, 2, 7, 5, 3, 10, 9, 1, 5 };

// Seznam unikátních hodnot z původního seznamu
var uniqueValues = numbers.Distinct();

// Opakující se hodnoty v seznamu
var repeatedValues = numbers.GroupBy(x => x).Where(x => x.Count() > 1);

// Výpis unikátních hodnot
Console.WriteLine($"Seznam unikátních hodnot: [ {String.Join(", ", uniqueValues)} ]\n");

// Výpis hodnot, které se opakují a kolikrát
foreach (var r in repeatedValues)
{
    Console.WriteLine($"Hodnota {r.Key} se v původním seznamu opakuje {r.Count()}x.");
}

// Druhá možnost výpisu hodnot
Console.WriteLine();
var cnt = repeatedValues.GroupBy(x => x.Count());
foreach (var c in cnt)
{
   string text = c.Count() == 1 ? "opakuje číslo" : "opakují čísla";
   Console.WriteLine($"V původním seznamu se {c.Key}x {text}: {String.Join(", ", c.Select(x => x.Key))}");
}
