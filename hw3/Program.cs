Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Этот день выходгой : да " );
}
else if (number<1 || number>7)
{
    Console.WriteLine("Это вообще не день недели");
}
else Console.WriteLine("Этот день не выходной : нет" );