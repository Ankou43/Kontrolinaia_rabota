static string[] FilterStrings(string[] array)
{
    // Тут я сделал фильтр для слов <=3, count выполняет роль счетчика для нового массива. Trim избавляет нас от лишних пробелов
    int count = 0;
    foreach (var item in array)
    {
        if (item.Trim().Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива нужного размера
    string[] resultArray = new string[count];

    // Заполнение нового массива
    int index = 0;
    foreach (var item in array)
    {
        if (item.Trim().Length <= 3)
        {
            resultArray[index] = item.Trim();
            index++;
        }
    }

    return resultArray;
}

Console.WriteLine("Введите элементы массива строк, разделенные запятой:");

// Тут вы будете ввести ваш массив в терминале
string inputString = Console.ReadLine();

// Разбивка строки на элементы массива
string[] originalArray = inputString.Split(',');

// Создание нового массива
string[] newArray = FilterStrings(originalArray);

// Вывод нового массива
Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");