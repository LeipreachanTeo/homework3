Console.WriteLine("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z2: ");
int z2 = int.Parse(Console.ReadLine());

var distanse = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)) + ((z2-z1)*(z2-z1)));
Console.WriteLine(distanse);