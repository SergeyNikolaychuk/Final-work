// 1.Написать программму,которая из имеющегося массива строк формирует массив из строк,длина которых
// меньше либо равна 3 символам.
string[] word = { "123", "homer", ">/" };
List<string> filteredList = new List<string>();
for (int i = 0; i < word.Length; i++)//проходим по всему массиву
{
    if (word[i].Length <= 3)
    {
        filteredList.Add(word[i]);
    }

}
    string[] result = filteredList.ToArray();
    foreach (string a in result)
    {
        Console.WriteLine(a);
    }

