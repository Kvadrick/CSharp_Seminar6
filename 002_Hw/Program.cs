double b1;
Console.WriteLine("Введите b1: ");
b1 = Convert.ToInt32(Console.ReadLine());

double k1;
Console.WriteLine("Введите k1: ");
k1 = Convert.ToInt32(Console.ReadLine());

double b2;
Console.WriteLine("Введите b2: ");
b2 = Convert.ToInt32(Console.ReadLine());

double k2;
Console.WriteLine("Введите k2: ");
k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"({x}; {y})");


