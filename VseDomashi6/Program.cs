Console.WriteLine("Введите номер одной из трех домашних: ");
int caseess = Convert.ToInt32(Console.ReadLine());
switch(caseess){
case 1:
Console.WriteLine("введите количество строк");
int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int chislo2 = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[chislo, chislo2];
FillArra(numbers);
PrintAr(numbers);

void FillArra(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintAr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
break;

case 2:
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] number = new int [10,10];
FillArray(number);

if (n > number.GetLength(0) || m > number.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {number[n-1,m-1]}");
}

PrintArr(number);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
break;

case 3:
Console.WriteLine("введите количество строк");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numb = new int[c, b];
FillArrayy(numb);


for (int j = 0; j < numb.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numb.GetLength(0); i++)
    {
        avarage = (avarage + numb[i, j]);
    }
    avarage = avarage / c;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArrayy(numb);



void FillArrayy(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayy(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
break;
}