Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int [] array = new int [N];
int index = 0;
int number = 1;

while(index < N)
{
    array[index] = number * number * number;
    Console.Write(array[index] + " ");
    number += 1;
    index += 1;
}
