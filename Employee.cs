class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double BaseSalary { get; set; }

    public Employee(string name, int age, double baseSalary)
    {
        Name = name;
        Age = age;
        BaseSalary = baseSalary;
    }

    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }

    public virtual string GetPosition()
    {
        return "Employee";
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Сотрудник: " + Name);
        Console.WriteLine("Должность: " + GetPosition());
        Console.WriteLine("Возраст: " + Age);
        Console.WriteLine("Базовая зарплата: " + FormatMoney(BaseSalary));
    }

    public static string FormatMoney(double money)
    {
        return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture).Replace(',', ' ') + " KZT";
    }
}
