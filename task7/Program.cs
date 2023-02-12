Console.Write("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int LastNamber = 0;
if(N > 99 && N < 1000)
{
    LastNamber = N%10;
    Console.Write(LastNamber);
}
else
{
    Console.Write("Некоректный ввод");
}