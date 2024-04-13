// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] your_array = {"Vsevolod","Car","!0_","Joke","XD","27364","Хай","No","Yes","Com puter"};

string[] newArray = FilterArray(your_array);

Console.WriteLine(string.Join(", ", newArray));

static string[] FilterArray(string[] Array)
{
    int count = 0;
    foreach (string str in Array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    string[] FinalArray = new string[count];

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