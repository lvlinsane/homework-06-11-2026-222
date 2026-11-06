class Manager : Employee
{
    public int TeamSize { get; set; }
    public double Bonus { get; set; }

    public Manager(string name, int age, double baseSalary,
                   int teamSize, double bonus)
        : base(name, age, baseSalary)
    {
        TeamSize = teamSize;
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override string GetPosition()
    {
        return "Manager";
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Количество подчинённых: " + TeamSize);
        Console.WriteLine("Премия: " + FormatMoney(Bonus));
        Console.WriteLine("Итоговая зарплата: " + FormatMoney(CalculateSalary()));
    }
}
