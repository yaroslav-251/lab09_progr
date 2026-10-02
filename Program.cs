// int totalExercises = 1;
// for (int number = 8; number >= totalExercises; number-=1)
// {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Домашнее задание готово");
// for (int room = 5; room <=50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }
// int totalWeeks = 3;
// for (int week = 1; week <= totalWeeks; week++)
// {

//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//         if (day == 5)
//     {
//         Console.WriteLine("^_^");
//     }
//     }
// }
// int ch = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         ch += 1;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}, пропущено {ch}");
//     break;
// }
//Самостоятельные задачи
//Задача А
// int n = 100;
// for (int ch = 1; ch <= n; ch += 2)
// {
//     Console.WriteLine(ch);
// }
//Задача В
// for (int n = 1; n <= 9; n++)
// {
//     for (int m = 1; m <= 9; m++)
//     {
//         Console.WriteLine($"{n} * {m} = {n * m}");
//     }
// }
// //6 вариант
// for (int n = 1; n <= 30; n++)
// {
//     if (n % 4 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine(n);
// }
// // 10 вариант
// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= 5; j++)
//     {
//         if (j + i == 6)
//         {
//             Console.WriteLine($"{i}, {j}");
//         }
//         break;
//     }
// }
// Допзадание
int u = 0;
int N = Convert.ToInt32(Console.ReadLine());
for (int c = 1; c <= N; c++)
{
    if (u == 20)
    {
        break;
    }
    for (int n = 1; n <= 7; n++)
    {
        if (n == 7)
        {
            continue;
        }
        u += 1;
    }


}
Console.WriteLine(u);