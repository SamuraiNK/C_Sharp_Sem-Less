﻿// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.




// int arrayLength= 12;

// int[] array = new int[arrayLength];

// int positiveNumber=0;
// int negNumber=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]= new Random().Next(-9, 10);
//     Console.Write(array[i]+" ");

//     if (array[i]>0)
//     {
//     // positiveNumber=positiveNumber+array[i];
//     positiveNumber+=array[i];
//     }
//     else
//     {
//     negNumber+=array[i];

//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных: {positiveNumber} и отрицательных: {negNumber}");





// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int arrayLength= 4;
// int[] array = new int[arrayLength];



// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(-9,10);
//    Console.Write(array[i]+" ");
// }


// Console.WriteLine();


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.Write(array[i]+" ");
// }



// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int arrayLength= 4;
// bool isFind=false;

// int[] array = new int[arrayLength];

// for (int i = 0; i < array.Length; i++)
// {
// array[i]= new Random().Next(-9, 10);
// Console.Write(array[i]+" ");

// if(num==array[i])
// {
// isFind=true;
// }
// }

// if (isFind==true)
// {
// System.Console.WriteLine( "Да");
// }
// else
// {
// System.Console.WriteLine( "Нет");
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int arrayLength= 5;
// int countNumber = 0;

// int[] array = new int[arrayLength];



// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(123);
//    Console.Write(array[i]+" ");

//    if ((array[i] > 9) && (array[i] < 100))
//    {
//     countNumber +=1;
//    }
// }

// System.Console.WriteLine("Колличество = " + countNumber);



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int arrayLength= 5;


int[] array = new int [arrayLength];
int [] array2 = new int [array.Length/2 + array.Length%2 ];


for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(10);
   Console.Write(array[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < array2.Length; i++)
{
  array2[i] = array[i]* array [arrayLength -1 - i];
  if (i == arrayLength -1 -i)
  {
    array2[i] = array[i];
  }
  Console.Write(array2[i]+" ");
}