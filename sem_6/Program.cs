﻿// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы 
// двух других сторон



// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3= Convert.ToInt32(Console.ReadLine());

// if((num1<num2+num3)&&(num2<num1+num3)&&(num3<num1+num2))
// {
// Console.WriteLine("Существует");
// }
// else
// {
// Console.WriteLine("Такого треугольника не может быть");
// }





// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());


// string result = "";


// while (num > 0)
// {
//     result = num % 2 + result;
//     num = num / 2;
// }

// Console.WriteLine(result);




// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int firstNum = 0;
// int secondNum = 1;

// Console.WriteLine(firstNum + " " + secondNum + " ") ;

// for (int i = 3; i <= num; i++)
// {
//     int newNum = firstNum + secondNum;
//     Console.Write(newNum + " ");
//     firstNum = secondNum;
//     secondNum = newNum;
// }



// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



// int [] array = new int [] {1, 2, 3, 4, 5};


// for (int i = 0; i < array.Length; i++)
// {
//     int temp = array[i];
//     array[i] = array[array.Length -1 -i];
//     array [array.Length -1 - i] = temp;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.WriteLine(array[i] + " ");
// }