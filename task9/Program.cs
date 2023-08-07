/*// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void ShowNum (int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1);
}
ShowNum(num);
*/
/*//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SumN(num1,num2);

int SumNum(int num1, int num2)
{
    int res = num1;
    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        res = num1 + SumNum(num1, num2);
        return res;
    }
}
void SumN( int num1, int num2)
{
    Console.Write(SumNum(num1 - 1, num2));
}

*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int fAkkerman = Akker(m, n);

Console.Write($"Функция Аккермана = {fAkkerman} ");

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akker(m - 1, 1);
    else return Akker(m - 1, Akker(m, n - 1));
}
