try
{
    const double q = 2;
    const double b = 1.8;

    double t = Math.Pow(b, 3) + Math.Exp(Math.Sqrt(q));
    double x = Math.Pow(t, 3) + b * b;
    double y = Math.Pow(Math.Atan(Math.Abs(x)), 2);
    Console.WriteLine($"t={t:F2}, x={x:F2}, y={y:F2}");
}
catch
{
    Console.WriteLine("Введите правильно");
}