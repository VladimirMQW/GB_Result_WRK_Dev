System.Console.Write($"Введите элементы исходного массива через запятую в одну строчку без пробелов и кавычек(допускаютя цифры, символы латинского алфавита и знаки): ");
string word = Console.ReadLine();
if (word.Length >= 3)
{
    string[] CreateArray()      // Создаем массив из введенный элементов.
    {
        string[] arrayAll = word.Split(",");
        return arrayAll;
    }

    void PrintArray(string[] array)  // Ввод массива (Используется для финального массива.).
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                Console.Write($"{array[i]}, ");
            }
            else
            {
                Console.Write($"{array[i]}");
            }
        }
        Console.WriteLine("]");
    }


    string[] OutArray()  // Создание массива cогласно условиям.
    {
        string[] array = CreateArray();
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            { count++; }                        //Находим длинну результ. массива.
        }
        string[] result = new string[count];    //Создаем массив.
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[j] = array[i]; //Заполняем массив.
                j++;
            }
        }
        return result;
    }


    string[] array = CreateArray();
    //System.Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Исходный массив.
    System.Console.WriteLine($"Исходный массив: ");
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine($"Массив согласно условиям: ");
    PrintArray(OutArray()); // Финальнй массив.

}
else
{
    System.Console.WriteLine("Введено меньше 3 символов.");
}