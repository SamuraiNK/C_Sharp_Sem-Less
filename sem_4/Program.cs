// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// тип возвращающего значение + название + ( ) + { }



// Console.WriteLine ( "Введите число" );
// int number = Convert.ToInt32 (Console.ReadLine());

// int GetSumNumber ()
// {
//     int sum = 0;
//     int count = 1;

//     while (number > count)
//     {
//         sum = sum + count;
//         count = count +1;
//     }

//     return sum;
// }

// int result = GetSumNumber ();
// Console.WriteLine(result);


// {
// int sum = 0;
// for (int count = 0; count <= number; count++)
// {
//     sum = sum + count;
// }
// return sum;
// }

// int result = GetSumNumber ();



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine(" Введите число");
// int number = Convert.ToInt32 (Console.ReadLine());

// int GetCountNumber()
// {
//     int count = 0;

//     while (number >0)
//     {
//         number = number/10;
//         count = count +1;
//     }

//     return count;
// }

// Console.WriteLine(GetCountNumber());



// Задача 28: Напишите программу, которая принимает на вход число 
// N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



// Задача 28: Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int arrayLength = 8;
int [] array = new int [arrayLength];



GetRandomArray();
void GetRandomArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.WriteLine(array [i]+ " ");
    }

   
}

