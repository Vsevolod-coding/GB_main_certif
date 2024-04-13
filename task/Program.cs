// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Ввод исходного массива
string [] your_array = {"Vsevolod","Car","!0_","Joke","XD","27364","Хай","No","Yes","Com puter","-2","1"};

// Формирование нового массива строк
string[] newArray = FilterArray(your_array);

// Вывод результата
Console.WriteLine("Результат:");
Console.WriteLine(string.Join(", ", newArray));

// Метод для фильтрации массива строк
static string[] FilterArray(string[] Array)
{
    // Подсчет количества строк, удовлетворяющих условию
    int count = 0;
    foreach (string str in Array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    // Создание нового массива нужного размера
    string[] FinalArray = new string[count];

    // Заполнение нового массива строками
    int index = 0;
    foreach (string str in Array)
    {
        if (str.Length <= 3)
        {
            FinalArray[index] = str;
            index++;
        }
    }
    return FinalArray;
}