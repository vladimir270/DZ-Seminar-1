// Программа которая находит большее из трех чисел 
Console.WriteLine("Введите число,  ");
int namber_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число,  ");
int namber_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число,  ");
int namber_С = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (namber_A > namber_B)
{
    max = namber_A;
} else {
    max = namber_B;
}

if (max < namber_С)
{
    Console.WriteLine("Большее число найдено,  ");
    Console.WriteLine(namber_С);
} else {
    Console.WriteLine("Большее число найдено,  ");
    Console.WriteLine(max);           
}
