//----------------------------------Exercise #34------------------------------
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//----------------------------------SOLUTION-----------------------------------
/*
int[] FIllArray(int N)
{
    int[] mass = new int[N];
    for (int i = 0; i < N; i++)
    {
        mass[i]= new Random().Next(100,1000);       
    }
    return mass;
}

int even(int[] mass)
{
    int i = 0;
    foreach (var item in mass)
    {
        if (item%2 == 0) i++;
    }
    return i;
}
System.Console.Write("Введите размерность массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] newMass = FIllArray(N);
System.Console.WriteLine("Получился следующий массив:");
System.Console.WriteLine(String.Join("|", newMass));
System.Console.WriteLine($"Четных элементов в массиве: {even(newMass)}");
*/

//----------------------------------Exercise #36------------------------------
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
//----------------------------------SOLUTION-----------------------------------
/*
int[] FIllArray(int N)
{
    int[] mass = new int[N];
    for (int i = 0; i < N; i++)
    {
        mass[i]= new Random().Next(1,100);       
    }
    return mass;
}

int evenSum(int[] mass)
{
    int sum = 0;
    foreach (var item in mass)
    {
       if (Array.IndexOf(mass, item)%2 >0)
       {
            sum += item;
       }
    }
    return sum;
}
System.Console.Write("Введите размерность массива = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] newMass = FIllArray(N);
System.Console.WriteLine("Получился следующий массив:");
System.Console.WriteLine(String.Join("|", newMass));
System.Console.WriteLine($"Сумма элементов на нечетных индексах равна : {evenSum(newMass)}");
*/
//----------------------------------Exercise #38------------------------------
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//----------------------------------SOLUTION-----------------------------------
double[] FIllArray(int N)
{
    double[] mass = new double[N];
    for (int i = 0; i < N; i++)
    {
        mass[i]= Math.Round(new Random().NextDouble()*100,2);       
    }
    return mass;
}

double diff(double[] mass)
{   
    double res;
    int max =0;
    int min =0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i]> mass[max]) max = i ;
        if (mass[i] <mass[min]) min = i;
        
    }
    res = mass[max]- mass[min];
    System.Console.WriteLine($"Наибольший элемент = {mass[max]}");
    System.Console.WriteLine($"Наименьший элемент = {mass[min]}");
    return res;
}
System.Console.Write("Введите размерность массива = ");
int N = Convert.ToInt32(Console.ReadLine());
double[] newMass = FIllArray(N);
System.Console.WriteLine("Получился следующий массив:");
System.Console.WriteLine(String.Join("|",newMass));
System.Console.WriteLine($"Разница между наибольшим и наименьшим элементами массива : {Math.Round(diff(newMass),2)}");


//System.Console.WriteLine($"Наибольший элемент = {mass[max]}");
// System.Console.WriteLine($"Наименьший элемент = {mass[min]}");