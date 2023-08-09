Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99)
{
    Console.WriteLine(" Третья цифра " + (number%10)%10);
}
else if (number<99)
{
    Console.WriteLine("Нет третьей цифры");
}