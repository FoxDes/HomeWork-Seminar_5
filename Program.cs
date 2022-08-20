// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray() 
{ 
    Console.WriteLine("Введите количество элементов массива"); 
    int size = Convert.ToInt32(Console.ReadLine()); 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
    {    
        Console.WriteLine($"Введите {i+1} элемент массива"); 
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    } 
    return array; 
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

int YaZakipelSuka(int[] array){
    int yazakipel = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      yazakipel++;
    }
  }
  return yazakipel;
}

Console.Clear();
int[] myArray = CreateArray(); 
ShowArray(myArray);

int yazakipel = YaZakipelSuka(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {yazakipel}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.





// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
