//----------------------------------Exercise #34------------------------------
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//----------------------------------SOLUTION-----------------------------------
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
