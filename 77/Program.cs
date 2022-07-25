Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<=5)
{ 
    Console.WriteLine("рабочий");
}
if (number > 5 && number <= 7) 
{ 
    Console.WriteLine("да выходной");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}
