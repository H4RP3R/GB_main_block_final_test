class Program
{
    static string[] GetArray(string[] args)
    {
        if (args.Length > 0) { return args; }
        else
        {
            Console.Write("Введите длину массива: ");
            int arrLength = Convert.ToInt32(Console.ReadLine());

            string[] strArr = new string[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"Введите строку №{i + 1}: ");
                strArr[i] = Console.ReadLine();
            }
            return strArr;
        }
    }

    static void PrintArray(string message, string[] arr)
    {
        Console.Write($"{message}:\t");
        Console.WriteLine($"[ {string.Join(", ", arr.Select(s => "'" + s + "'"))} ]");
    }

    static string[] ThreeOrLessLettersArr(string[] arr)
    {
        string[] resArr = new string[arr.Length];

        int pos = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                resArr[pos] = str;
                pos++;
            }
        }
        Array.Resize(ref resArr, pos);
        return resArr;
    }

    static void Main(string[] args)
    {
        string[] inputArr = GetArray(args);
        PrintArray("Входные данные", inputArr);

        string[] newArr = ThreeOrLessLettersArr(inputArr);
        PrintArray("Результат", newArr);
    }
}
