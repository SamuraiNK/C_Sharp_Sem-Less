// Задача 17

// Console.WriteLine(" Введите X ");
// int X = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine(" Введите Y ");
// int Y = Convert.ToInt32 (Console.ReadLine ());

// if (( X > 0 ) && (Y > 0 ))
// {
//     Console.WriteLine(" Первая четверть ");
// }
// else if  (( X < 0 ) && (Y > 0 ))
// {
//     Console.WriteLine(" Вторая четверть ");
// }
// else if  (( X < 0 ) && (Y < 0 ))
// {
//     Console.WriteLine(" Третья  четверть ");
// }
// else if  (( X > 0 ) && (Y < 0 ))
// {
//     Console.WriteLine(" Четвёртая четверть ");
// }





// Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32 (Console.ReadLine ());

// if ( number == 1 )
// {
//     Console.WriteLine( " X > 0 , Y > 0 ");
// }
// else if ( number == 2 )
// {
//     Console.WriteLine(" X < 0 , Y > 0 ");
// }
// else if ( number == 3 )
// {
//     Console.WriteLine(" X < 0 , Y < 0 ");
// }
// else if ( number == 4 )
// {
//     Console.WriteLine(" X > 0 , Y < 0 ");
// }
// else 
// {
//     Console.WriteLine("Такой четверти у нас нет");
// }




// Задача 21  



// Console.WriteLine("Введите координату Х для первой точки");
// int X1 = Convert.ToInt32 (Console.ReadLine ());

// Console.WriteLine("Введите координату Y для первой точки");
// int Y1 = Convert.ToInt32 (Console.ReadLine ());

// Console.WriteLine("Введите координату Х для второй точки");
// int X2 = Convert.ToInt32 (Console.ReadLine ());

// Console.WriteLine("Введите координату Y для второй точки");
// int Y2 = Convert.ToInt32 (Console.ReadLine ());



// double result = Math.Sqrt ((Math.Pow ((X2-X1),2))  +  
// (Math.Pow ((Y2-Y1),2)));



// result = Math.Round(result,3);
// Console.WriteLine( result );


Console.WriteLine("Введите цифру");
int num = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}