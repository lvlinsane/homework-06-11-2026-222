Console.OutputEncoding = System.Text.Encoding.UTF8;

Developer dev = new Developer("Иванов Иван", 25, 400000, "C#", 3);
Manager man = new Manager("Сидорова Анна", 35, 500000, 10, 100000);
Accountant acc = new Accountant("Каримова Алия", 32, 300000, 4, "Высшая");

Employee simple = new Employee("Петров Пётр", 30, 200000);

simple.DisplayInfo();
Console.WriteLine();

dev.DisplayInfo();
Console.WriteLine();

man.DisplayInfo();
Console.WriteLine();

acc.DisplayInfo();
