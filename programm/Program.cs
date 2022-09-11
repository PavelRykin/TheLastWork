string[] array = {
    "Programm", "123", "Pro", "1234", "1", "What", "Why", "21d", "Questien"
};//заполненный массив
string[] newArray = new string[array.Length];// новый массив в котором будут строки содержащие не более 3 символов

PrintArray(FindString(array, newArray));

string[] FindString(string[] array, string[] newArray) // метод отсортировки символов
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

void PrintArray(string[] newArray)//метод вывода в консоли получившийся массив
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
}