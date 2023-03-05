Console.WriteLine("Введите координаты точки X");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.Write($"расстояние между точками -> {Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate)}");


double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2))), 2);
}