// int age = 15;
// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ запрещен");
//     Console.WriteLine($"Осталось до совершеннолетия: {18 - age}");
// }

// int age = 16;
// if(age < 13)
// {
//     Console.WriteLine("Ребёнок");
// }else if(age < 18){
//     Console.WriteLine("Подросток");
// }else if(age <= 59)
// {
//     Console.WriteLine("Взрослый");
// }
// else
// {
//     Console.WriteLine("Пенсионер");
// }

// int age = 16;
// double height = 1.4;
// bool flag = false;
// if (age >= 14 && height >= 1.5)
// {
//     Console.WriteLine("Можно кататься");
// }else if(height <= 1.5 && flag == true)
// {
//     Console.WriteLine("Можно кататься");
// }
// else
// {
//     Console.WriteLine("Пока нельзя");
// }

// //Задача Г
// Console.Write("Введите год: ");
// int year = int.Parse(Console.ReadLine());

// if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
// {
//     Console.WriteLine("Високосный год");
// }
// else
// {
//     Console.WriteLine("Не високосный год");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// //Вариант 2
// Console.Write("ведите возраст: ");
// int age = int.Parse(Console.ReadLine());
// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// else
// {
//     Console.WriteLine("Доступ запрещен");
// }

//Вариант 9
Console.WriteLine("Добро пожаловать в игру «Камень, Ножницы, Бумага»");
Console.Write("Игрок 1, введите (К, Н, Б): ");
string player1 = Console.ReadLine();

Console.Write("Игрок 2, введите (К, Н, Б): ");
string player2 = Console.ReadLine();

if (player1 == player2)
{
    Console.WriteLine("Ничья!");
}
else if ((player1 == "К" && player2 == "Н") ||(player1 == "Н" && player2 == "Б") || (player1 == "Б" && player2 == "К"))
{
    Console.WriteLine("Игрок 1 победил!");
}
else if ((player2 == "К" && player1 == "Н") || (player2 == "Н" && player1 == "Б") || (player2 == "Б" && player1 == "К"))
{
    Console.WriteLine("Игрок 2 победил!");
}
else
{
    Console.WriteLine("Ошибка: нужно ввести только К, Н или Б.");
}
