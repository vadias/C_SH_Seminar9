// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum = 0;
int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Recurse(int m, int n)
{
    sum = sum + m;
    if(m==n){
        System.Console.Write($"{sum}");
        return;
    }
    Recurse(m+1, n);  

}


int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
Recurse(M,N);