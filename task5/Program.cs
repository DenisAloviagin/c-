Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = -N;
while(temp <= N)
{
    Console.Write($"{temp} ");
    temp++;// temp = temp + 1
}