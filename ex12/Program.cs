// Дан текст. В тексте нужно все пробелы заменить знаками _. 
//Маленикие буквы к заменить большими буквами К
//Большие буквы С заменить маленькими буквами с

//
Console.Clear();
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Zamena(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
//char a = " ";
//char b = "_";
string newText = Zamena(text, ' ', '_');
Console.WriteLine(newText);
newText = Zamena(text, 'к', 'К');
Console.WriteLine(newText);
newText = Zamena(text, 'С', 'с');
Console.WriteLine(newText);
