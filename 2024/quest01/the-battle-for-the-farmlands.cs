int PotionCost(char c) => Math.Max((c - 'A') * 2 - 1, 0);

int Compute(string input, int size)
{
    int cost = 0;
    for (int i = 0; i < input.Length; i += size)
    {
        int enemies = 0;
        for (int j = 0; j < size; j++)
        {
            if (input[i + j] != 'x')
            {
                cost += PotionCost(input[i + j]);
                enemies++;
            }
        }
        if (enemies == 3) cost += 6;
        if (enemies == 2) cost += 2;
    }
    return cost;
}

Console.WriteLine(Compute(File.ReadAllText("p1.txt").Trim(), 1));
Console.WriteLine(Compute(File.ReadAllText("p2.txt").Trim(), 2));
Console.WriteLine(Compute(File.ReadAllText("p3.txt").Trim(), 3));
