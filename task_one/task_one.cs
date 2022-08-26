Console.Write("Введите пятизначное число: ");
int number = Int32.Parse(Console.ReadLine());
int reverse = 0;
int identical_number = number;
while(identical_number > 0)
{
    reverse = reverse*10 + identical_number % 10;
    identical_number /= 10;
}
if (number > 9999 && number < 100000)
{
    if(number == reverse)
    {
        Console.WriteLine("Число является палиндром");
    }
    else
    {
        Console.WriteLine("Число не является палиндром");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
