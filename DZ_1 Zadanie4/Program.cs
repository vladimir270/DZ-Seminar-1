Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1) 
{
    for(int i = 2; i <=N; i+=2)
    {
        Console.Write(i);
        Console.Write(",");
    }
}
if (N < -1);
{
    for (int i = -2; i >= N; i -=2)
    {
        Console.Write(i);
        Console.Write(",");
    }
}
if (N <= 1 && N >= -1) Console.WriteLine("Четных чисел нет");