//Дано масив словників. Реалізувати пошук по ключах кожного словника і вивести кількість знайдених результатів на екран.
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

Dictionary<int,string>[] arrayOfDictionaries = new Dictionary<int,string>[3];
Dictionary<int,string> dictionary1 = new Dictionary<int,string>();
Dictionary<int,string> dictionary2 = new Dictionary<int,string>();
Dictionary<int,string> dictionary3 = new Dictionary<int,string>();
FillingDictionary1();
FillingDictionary2();
FillingDictionary3();
AddingDictionariesToArray();
GetKey();
void FillingDictionary1()
{   
    dictionary1.Add(1,"one");
    dictionary1.Add(2,"two");
    dictionary1.Add(3,"three");
}
void FillingDictionary2()
{   
    dictionary2.Add(4, "four");
    dictionary2.Add(5,"five");
    dictionary2.Add(6,"six");
}
void FillingDictionary3()
{
    dictionary3.Add(7,"seven");
    dictionary3.Add(8,"eight");
    dictionary3.Add(9,"nine");
}
void AddingDictionariesToArray()
{
    arrayOfDictionaries[0] = dictionary1;
    arrayOfDictionaries[1] = dictionary2;
    arrayOfDictionaries[2] = dictionary3;
}
void GetKey()
{
    while (true)
    {
        Console.Write("Уведiть ключ: ");
        string input = Console.ReadLine();
        int key;
        if (int.TryParse(input, out key))
        {
            SearchByKeys(key);
            break;
        }
        else
        {
            Console.WriteLine("Уведіть ціле числове значення!");
        }
    }
}
void SearchByKeys(int key)
{
    string value;
    for (int i = 0; i < arrayOfDictionaries.Length; i++)
    {
        if (arrayOfDictionaries[i].TryGetValue(key, out value))
        {
            Console.WriteLine($"Значення з ключем {key} у словнику {i+1} дорiвнює {value}.");
        }
        else
        {
            Console.WriteLine($"Елемент з ключем {key} не знайдено у словнику {i+1}.");
        }
    }
}

