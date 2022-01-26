// See https://aka.ms/new-console-template for more information

Random random = new Random();
List<int> list = new List<int>();

Console.WriteLine("Original List:");
for (int i = 0; i < 20; i++)
{
    int num = random.Next(1, 50);
    list.Add(num);
    Console.Write($"{num} ");
}

List<int> squaredList = new List<int>();

Console.WriteLine("\n\nSquared List:");
foreach (int num in list)
{
    int squaredNum = num * num;
    squaredList.Add(squaredNum);
    Console.Write($"{squaredNum} ");
}

List<int> evenSquaredList = new List<int>();

Console.WriteLine("\n\nSquared List (even numbers only):");
foreach (int num in squaredList)
{
    if (num % 2 == 0)
    {
        evenSquaredList.Add(num);
        Console.Write($"{num} ");
    }
}
Console.WriteLine();