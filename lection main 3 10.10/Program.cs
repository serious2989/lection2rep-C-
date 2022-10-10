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
 Console.WriteLine(year);