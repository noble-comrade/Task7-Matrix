void Printer(int[,] arr, int N) 
{
    // вывод
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] Completion(int a, int b, int N) 
{
    int[,] numbers = new int[N, N];
    var rand = new Random();
    // заполнение
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            numbers[i, j] = rand.Next(a, b);
        }
    }
    return numbers;
}
int[,] Summation(int[,] arr1, int[,] arr2,int N) 
{
    // сложение
    int[,] res = new int[N, N];
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            res[i, j] = arr1[i, j] + arr2[i, j];
        }
    }
    return res;
}
int[,] Difference(int[,] arr1, int[,] arr2, int N)
{
    // Вычитание
    int[,] res = new int[N, N];
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            res[i, j] = arr1[i, j] - arr2[i, j];
        }
    }
    return res;
}

Console.Write("Введите диапазон a;b>>");
string[] range = Console.ReadLine().Split(";");
Console.Write("Введите размерность квадратной таблицы N>>");
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = Completion(Convert.ToInt32(range[0]), Convert.ToInt32(range[1]), N);
int[,] matrix2 = Completion(Convert.ToInt32(range[0]), Convert.ToInt32(range[1]), N);

int[,] sum = Summation(matrix1, matrix2, N);
int[,] dif = Difference(matrix1, matrix2, N);

Console.WriteLine("Первая:");
Printer(matrix1, N);
Console.WriteLine("Вторая: ");
Printer(matrix2, N);
Console.WriteLine("Их сумма: ");
Printer(sum,N);
Console.WriteLine("Их разность: ");
Printer(dif,N);