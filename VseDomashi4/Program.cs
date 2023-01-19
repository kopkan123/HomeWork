Console.WriteLine("Введите номер одной из трех домашних: ");
int caseess = Convert.ToInt32(Console.ReadLine());
switch(caseess){
     case 1:
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
     break;

     case 2:
Console.WriteLine("Введите размер массива");
int sizez = Convert.ToInt32(Console.ReadLine());
int[] number = new int[sizez];
FillArrayRandomNumber(number);
Console.WriteLine("Вот наш массив: ");
PrintArra(number);
int sum = 0;

for (int z = 0; z < number.Length; z+=2)
    sum = sum + number[z];

    Console.WriteLine($"всего {number.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumber(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArra(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
     break;

     case 3:
     Console.WriteLine("Введите размер массива");
int sizes = Convert.ToInt32(Console.ReadLine());
double[] numberz = new double[sizes];
FillArrayRandomNumberss(numberz);
Console.WriteLine("Вот наш массив: ");
PrintArrayy(numberz);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numberz.Length; z++)
{
    if (numberz[z] > max)
        {
            max = numberz[z];
        }
    if (numberz[z] < min)
        {
            min = numberz[z];
        }
}

Console.WriteLine($"всего {numberz.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumberss(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArrayy(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
     break;
}