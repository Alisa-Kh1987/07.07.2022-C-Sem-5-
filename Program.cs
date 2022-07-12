// See https://aka.ms/new-console-template for more information

// Примеры форматирования

//string name = "Имя";
//int age = 99;
//Console.WriteLine("Имя: {0}  Возраст: {1}", name, age);
//
//int number = 23;
//string result = string.Format("{0:f}", number);
//
//Console.WriteLine(result);

//double number2 = 45.08;
//string result2 = string.Format("{0:f5}", number2);
//Console.WriteLine(number2);
//Console.WriteLine(result2);
//
//string name = "Имя";
//int age = 99;
//Console.WriteLine($"Имя: {name}  Возраст: {age}");
//int x = 7;
//int y = 8;
//string result = $"{x} + {y} = {x + y}";
//Console.WriteLine(result);
//
//string name = "Елена";
//int age = 99;
//
//Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); // пробелы после
//Console.WriteLin($"Имя: {name, 15} Возраст: {age}"); // пробелы до

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
//int[] CreateRandomArray(int size, int min, int max)
//{
//    int[] array = new int[size];
 //   for (int i = 0; i < size; i++)
 //   {
 //       array[i] = new Random().Next(min, max + 1);
 //   }
 //   return array;
//}
//
//void ShowArray(int[] array)
//{
//
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//}
//
//int[] myArray = CreateRandomArray(12, -9, 9);
//ShowArray(myArray);
//
//int sum_pos = 0;
//int sum_neg = 0;
//
//for (int i = 0; i < myArray.Length; i++)
//{
//    if (myArray[i] > 0)
//        sum_pos += myArray[i];
//    else
//        sum_neg += myArray[i];
//}
//
//Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

//Задача 32
//int[] CreateRandomArray(int size, int min, int max)
//{
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//        array[i] = new Random().Next(min, max + 1);
//        Console.Write($"{array[i]}, ");
//    }
//    return array;
//}
//
//void ShowArray(int[] array)
//{
//     Console.Write("-> [ ");
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.WriteLine($"{array[i] *-1}, ");
//    }
//    Console.Write(" ]");
//}

//Задача 33. есть ли число в рандомном массиве


//Задача 35
//    int[] CreateRandomArray(int size, int min, int max)
//    {
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = new Random().Next(min, max + 1);
//        }
//        return array;
//    }
//    void ShowArray(int[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write(array[i] + " ");
//        }
//        Console.WriteLine();
//    }
//    int[] myArray = CreateRandomArray(5, 0, 500);
//    ShowArray(myArray);
 //   int N = 0;
 //   for (int i = 0; i < myArray.Length; i++)
 //   {
 //       if (myArray[i] > 9 && myArray[i] < 100)
 //       {
 //           N = N + 1; //N++  //N +=1
 //       }
 //   }
 //   Console.WriteLine(N);




///else if (str_len % 2 == 1)
      //  {
      //      //если нечётное количество сиволов, то есть явная середина
      //      int middle = str_len/2,
      //          i = 1; //!1 из-за нечётного количеста символов
      //      //идём влево и вправо от середины с шагом 1
      //      while (result && i<middle)
      //      {
      //          if(str[middle-i] != str[middle+i])
      //          {      
       //             result = false;  
       //         }
       //         i++; 
       //     }
      //  }
       // else
       // {
       //     //если чётное количество сиволов, то нет явной середины
       //     int middle = str_len/2,
       //         i = 0; //!0 из-за чётного количеста символов
       //     //идём слева и справа к середине с шагом 1
       //     while (result && i<middle)
       //     {
       //         if(str[i] != str[(str_len-1)-i])
       //         {   result = false;  }
       //         i++;
       //     }
       // }


//Практическое задание к семинару № 5 по C# (07.07.2022).

//Задача № 34. 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
{
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
         {
            array[i] = new Random().Next(min, max + 1);
         }
      return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, 100, 999);
ShowArray(myArray);

int even_nums = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i]%2 == 0)
    {
        even_nums += 1;
    }
    else
        {even_nums += 0;
        }
}

Console.WriteLine(even_nums);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int min, int max)
{
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
         {
            array[i] = new Random().Next(min, max + 1);
         }
      return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, -10, 20);
ShowArray(myArray);

int sum_odd_index_nums = 0;

for (int i = 1; i < myArray.Length; i=i+2)
{
    sum_odd_index_nums += myArray[i];
}
    
Console.WriteLine(sum_odd_index_nums);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size, int start, int end)
{
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
         {
            array[i] = new Random().Next(start, end + 1);
         }
      return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(15, 10, 99);
ShowArray(myArray);

int max = myArray[0];
int min = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] >= max)
    {max = myArray[i];}   
}

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] <= min)
    {min = myArray[i];}
}
Console.WriteLine(max);
Console.WriteLine (min);
Console.WriteLine(max-min);