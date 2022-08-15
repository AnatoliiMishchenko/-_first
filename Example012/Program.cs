// Вид 1
void Method1()
{
    Console.WriteLine("Hello, World!");
}
//Method1();
//Вид 2
void Method2(string name, int count)
{
    for (int i = 1; i <= count; i++)
        Console.WriteLine(name);
}
// Method2(name: "Дима", count: 5);
// Method2( count: 2 , name: "Женя");
// Method2( " Ира", 4);


//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int date = Method3();
//Console.WriteLine(date);


//Вид 4
string Method4(string name, int count)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += name;
    }
    return result;
}
string res = Method4(" Коля ", 10);
//Console.WriteLine(Method4(" Коля ", 10));

// for(int i = 2 ; i <= 10 ; i ++){
//     for(int j = 2; j<= 10; j++){
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine("\n");

// }
string text = "лол ывапл ываибсло дыловс дт фор ф цров мтдовмр" +
              "дрфадф дфдс дрддт фдцц  жвйхз бсьз сгоцушст кмщшцгуйэвзь" +
              "э мщлцщй ЗВОЯЛ ТСЖФОРЦ   ХГМК ЭТЗЛ АЧКО";
string Reaples(string text, char oldChar, char newChar)
{
    string result = String.Empty;
    int lengthText = text.Length;
    for (int i = 0; i < lengthText; i++)
    {
        if (text[i] == oldChar) result += $"{newChar}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Reaples(text, ' ', '-');

// Console.WriteLine(newText);
// Console.WriteLine("\n");
// newText = Reaples(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine("\n");
// newText = Reaples(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine("\n");

int[] array = { 1, 2, 3, 1, 5, 6, 7, 5, 8, 5, 8, 9, 0 };

void printArray(int[] Array)
{

    int count = Array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine("\n");
}
void SelectionSort(int[] Array)
{
    for (int i = 0; i < Array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[j] > Array[minPos])
            {
                minPos = j;

            }
        }


        int temp = Array[i];
        Array[i] = Array[minPos];
        Array[minPos] = temp;


    }
}
printArray(array);
SelectionSort(array);
printArray(array);
