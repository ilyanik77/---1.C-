// Напишите программу,которая принимает на вход одно число (N),а на выходе
// показывает все целые числа в интервале от -N до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = - N; i <= N; i++ ) {
    Console.WriteLine(i);
}