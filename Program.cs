// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray() 
// { 
//     Console.WriteLine("Введите количество элементов массива"); 
//     int size = Convert.ToInt32(Console.ReadLine()); 
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     {    
//         Console.WriteLine($"Введите {i+1} элемент массива"); 
//         array[i] = Convert.ToInt32(Console.ReadLine()); 
//     } 
//     return array; 
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int YaZakipel(int[] array){
//     int yazakipel = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       yazakipel++;
//     }
//   }
//   return yazakipel;
// }

// Console.Clear();
// int[] myArray = CreateArray(); 
// ShowArray(myArray);

// int yazakipel = YaZakipel(myArray);
// Console.WriteLine($"Количество чётных чисел в массиве: {yazakipel}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Clear();
// Console.Write($"Введи количество элементов массива: ");
// int N = Convert.ToInt32(Console.ReadLine()); 

// int RandomArray(int N, int min, int max)
//   {
//   int[] randomArray = new int[N];
//   int sumArray = 0;
//   Console.Write("Массив: ");

//     for (int i = 0; i <randomArray.Length; i++ )
//     {
//       randomArray[i] = new Random().Next(min, max);

//       Console.Write(randomArray[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumArray = sumArray + randomArray[i];
//       }
//     }
//   return sumArray;
//   }

// int randomArray =  RandomArray(N, -100, 100);

// Console.WriteLine($"  -  " + "cумма элементов, стоящих на нечётных позициях: " + randomArray);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int[] arrayNumbers = new int[6];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(-50, 100);
    Console.Write(arrayNumbers[i] + " ");
  }

int maxNum = arrayNumbers[0];
int minNum = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
        if (maxNum < arrayNumbers[i])
    {
      maxNum = arrayNumbers[i];
    }
        if (minNum > arrayNumbers[i])
    {
      minNum = arrayNumbers[i];
    }
  }
  int result = maxNum - minNum;
  Console.WriteLine($"Разница между максимальным и минимальным элементами: {result}");