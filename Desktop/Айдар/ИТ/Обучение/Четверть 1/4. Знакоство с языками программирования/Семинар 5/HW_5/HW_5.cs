// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateArray()
// {
//     System.Console.WriteLine("Введите длину массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     return array;
// }

// void FillAndPrintArray(int[] array, int min, int max)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(min, max);
//         System.Console.WriteLine(string.Join(",", array));
// }

// int FindTheNumberOfEvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// int[] Array = CreateArray();
// int Min = 100;
// int Max = 1000;
// FillAndPrintArray(Array, Min, Max);
// int Count = FindTheNumberOfEvenNumbers(Array);
// System.Console.WriteLine("Количество четных элементов в массиве равно: " + $"{Count}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateArray()
// {
//     System.Console.WriteLine("Введите длину массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     return array;
// }

// void FillAndPrintArray(int[] array, int min, int max)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(min, max);
//     System.Console.WriteLine(string.Join(",", array));
// }

// int SumOfUnevenIndex(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (i % 2 > 0)
//             summ += array[i];
//     return summ;
// }


// int[] Array = CreateArray();
// int Min = 0;
// int Max = 20;
// FillAndPrintArray(Array, Min, Max);
// int Summ = SumOfUnevenIndex(Array);
// System.Console.WriteLine("Сумма нечетных элементов равна: " + $"{Summ}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateArray()
// {
//     System.Console.WriteLine("Введите длину массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     double[] array = new double[size];
//     return array;
// }

// void FillAndPrintArray(double[] array, int min, int max)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Random rnd = new Random();
//         array[i] = rnd.NextDouble()*new Random().Next(min, max);

//     }
//     System.Console.WriteLine(string.Join(",", array));
// }

// double DifferenceBetweenMaximumAndMinimum(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     double result;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//             min = array[i];
//         else
//         if (array[i] > max)
//             max = array[i];
//     }
//     result = max - min;
//     return result;
// }

// double[] Array = CreateArray();
// int Min = -99;
// int Max = 100;
// FillAndPrintArray(Array, Min, Max);
// double Result = DifferenceBetweenMaximumAndMinimum(Array);
// System.Console.WriteLine("Разница между максимальным и минимальным значениями элементов массива равна: " + $"{Result}");




// ___________________ДОП ЗАДАЧА_____________________________________
// У нас есть массив с целыми числами, как положительными, так и отрицательными. все числа в массиве разные. 
// Если сложить или вычесть любые два числа из массива, они точно поместятся в стандартной целочисленной переменной. 
// Ещё у нас есть какое-то число - оно не в массиве, а само по себе, отдельной переменной. 
// Нужно вывести индексы тех двух элементов, которые в сумме дабт то самое отдельное число. 
// Например, если в массиве у нас (2,4,5,1,8), а число  - 5, то ответом будет пара 1 и 3, 
// потому что на этиз местах стоят числа 4 и 1 (и дают в сумме 5)

// void IndexNumbers(int[] array, int number)
// {
//     int Index1 = 0;
//     int Index2 = 0;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] + array[j] == number) 
//             {
//                 Index1 = i;
//                 Index2 = j;
//                 System.Console.WriteLine("Индекс первого элемента: " + Index1);
//                 System.Console.WriteLine("Индекс второго элемента: " + Index2);
//                 return;
//             }
//         }
//     }
//     if (Index1 == Index2)
//     System.Console.WriteLine("Элементы не найдены");
// }




// int[] Array = { -2, 3, 7, -4, 1, 5, -3 };
// int Number = 4;
// IndexNumbers(Array, Number);