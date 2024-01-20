class MyClass
{
    private int a;
    private int b;
    private int c;
    private int d;
    public MyClass()
    {
        Console.WriteLine("Введите значение для a:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для b:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для c:");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для d:");
        d = int.Parse(Console.ReadLine());
    }
    public MyClass(int aValue, int bValue, int cValue, int dValue)
    {
        a = aValue;
        b = bValue;
        c = cValue;
        d = dValue;
    }
    public double CalculateAverage()
    {
        return (a + b + c + d) / 4.0;
    }
    public int FindMaxNumber()
    {
        return Math.Max(Math.Max(a, b), Math.Max(c, d));
    }

    public string GetInfoString()
    {
        return $"a: {a}, b: {b}, c: {c}, d: {d}";
    }
}