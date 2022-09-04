// Напишите программу, которая на вход получает число (N), а на выходе покузывает все целые числа в диапазоне от -N то N .
// N = 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// N = 2 -> "-2, -1, 0, 1, 2,"


int N = 0, not_N=0;
Console.Write("Введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());
if (N > 0) not_N = - N;
    else {not_N = N; N = - N;}
while (not_N <= N)
{
    Console.Write(not_N + " ");
    not_N++;

}
