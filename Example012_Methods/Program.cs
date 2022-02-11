// Вид 1

// чтобы создать метод
// void Method1()
// {
//     Console.WriteLine("Автор ");
// }
// // чтобы вызвать метод
// Method1();


// Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения msg");


// Вид 2.1

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//первый вариант вывода метода
//Method21("Текст сообщения", 4);
//второй вариант вывода метода
//Method21(count: 4, msg: "Текст сообщения");

// Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
//Console.WriteLine(year);


// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string result = Method4(10, "Данный текст, ");
// Console.WriteLine(result);


// Вид 4.1

// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string result = Method41(10, "A ");
// Console.WriteLine(result);


// Цикл for и цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Новая задача 1 Изменения в тексте

// string text = "Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);

// Новая задача 2 "Упорядочивание чисел"

// int[] array = { 8, 9, 6, 4, 2, 1, 7, 2, 1, 5 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(array);
// SelectionSort(array);

// PrintArray(array);