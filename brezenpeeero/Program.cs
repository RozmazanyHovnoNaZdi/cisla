Console.Write("input first number: ");
int redbull = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int monster = Convert.ToInt32(Console.ReadLine());


if (redbull > monster)
{
    Console.WriteLine($"Číslo {redbull} je větší než číslo {monster}");
}
else
{
    Console.WriteLine($"Číslo {monster} je větší než číslo {redbull}");
}