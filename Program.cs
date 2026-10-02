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

int age = 16;
double height = 1.4;
bool flag = false;
if (age >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
}else if(height <= 1.5 && flag == true)
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}