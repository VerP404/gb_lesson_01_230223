Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1)
{
    Console.WriteLine($"День недели {day} понедельник");
}
else if(day == 2)
{
    Console.WriteLine($"День недели {day} вторник");
}
else if(day == 3)
{
    Console.WriteLine($"День недели {day} среда");
}
else if(day == 4)
{
    Console.WriteLine($"День недели {day} четверг");
}
else if(day == 5)
{
    Console.WriteLine($"День недели {day} пятница");
}
else if(day == 6)
{
    Console.WriteLine($"День недели {day} суббота");
}
else if(day == 7)
{
    Console.WriteLine($"День недели {day} воскресенье");
}
else
{
    Console.WriteLine($"Число {day} не является днем");  
}    
