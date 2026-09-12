//высокий

Console.Write("Введите х:");
double x = double.Parse(Console.ReadLine());
double K = (Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6 * x * x));
Console.WriteLine($"K={K:F2}");
