// Вид 1. Фунции

void Method1 ()

{
Console.WriteLine("Автор..");
}

//Method1() - зеленый чтобы работал второй метод 

// Вид 2
void Method2(string msq)

{
    Console.WriteLine(msq);
}

//Method2("Текст сообщения"); пока что убрал
Console.Clear();
void Method21(string msq, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msq);
        i++;
    }
}

//Method21(msq:"Текст сообщения",count: 4);
//Method21(count: 4, msq:"NEW TEKST");

//3 Вид

int Method3()
{
    return DateTime.Now.Year;
}

 int year = Method3();
 //Console.WriteLine(year); включить чтобы работало

 // 4 вид - принимают и возвращают
 /*Console.Clear();
 string Method4(int count, string text)
 {
    int i = 0;
    string result = String.Empty;// алилуя сто лет искал ошибку тут

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
 }
 string res = Method4(10, "newconsole");
 Console.WriteLine(res);
*/
Console.Clear();
 string Method4(int count, string text)
 {
    string result = String.Empty;// алилуя сто лет искал ошибку тут
    for (int i = 0; i < count; i++) //а здесь то же самое через "for"
    
    {
        result = result + text;
    }
    return result;
 }
 string res = Method4(10, "newconsole");
 //Console.WriteLine(res);

 //Таблица умножения

 for (int i = 2; i<=10; i++)
 {
    for (int j = 2; j<=10; j++)
    {
        //Console.WriteLine($"{i} * {j} = {i * j}");
    }
    //Console.WriteLine();
 }

 //Работа с текстом
 // Дан текст. В тексте нужно все пробелы заменить звездочками. 
 // маленькие буквы "к" заменить большой буквой "К",
 // А большие буквы "С" заменить маленькими "с".

string text =  "- Я думаю, - сказал князь, улыбаясь, - что "
            + "ежели бы Вас послали вместо нашего милого Венцегероде,"
            + "вы бы взяли приступов согласие прусского короля,"
            + "Вы так красноречивы. Вы дадите мне чаю? ";

 // string s = "qwerty"
 //             012345
 // s[3] // r

 string Replace (string text, char oldValue, char newValue)    
 {
    string result = String.Empty;

    int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
    
        }
    return result;
 }    
 string newText = Replace (text, ' ', '|');
 Console.WriteLine(newText); //разделили новыми символами. 
 // приступаем к замене букв
 Console.WriteLine();
    newText = Replace (newText, 'к', 'К');
    Console.WriteLine(newText);
    Console.WriteLine();
    newText = Replace (newText, 'С', 'с');
    Console.WriteLine();
