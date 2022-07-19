int n;
Console.WriteLine("Напишите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine(count);