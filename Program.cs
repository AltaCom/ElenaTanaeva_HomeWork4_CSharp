// Homework4
/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16


double Degree(double a, double b)
{
double degree = Math.Pow(a, b);
return degree;

}

Console.Write("Input number ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Input natiral degree ");
double deg = Convert.ToDouble(Console.ReadLine());

double result = Degree(num, deg);
Console.Write($"Number {num} in {deg} degree is {result}");
Console.WriteLine();
*/

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12


int DigitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
    int newNum = num / 10;
    num = num % 10;
    sum = sum + num;
    num = newNum;
    }
        
    return sum;

}

Console.Write("Input number: ");
int username = Convert.ToInt32(Console.ReadLine());

int digitSum = DigitSum(username);
Console.Write($"The sum of digits of {username} is {digitSum}");

Console.WriteLine();
*/


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


int[] CreatArray (int size)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write ("Imput the array element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();

}

Console.Write("Input the array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] userarray= CreatArray(arraySize);
ShowArray(userarray);

*/