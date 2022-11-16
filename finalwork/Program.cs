// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Clear();
System.Console.WriteLine();

string[] array = Input();
string[] result = Condition(array, 4);
Console.WriteLine($"[{string.Join(", ", result)}]");

string[] Input()
{
    Console.Write("Введите данные через пробел:  ");
    return Console.ReadLine().Split(" ");
}

int OutputLength(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length < n)
            count++;
    }
    return count;

}

string[] Condition(string[] input, int n)
{
    string[] output = new string[OutputLength(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length < n)
        {
            output[j] = array[i];
            j++;
        }
    }
    return output;
} 