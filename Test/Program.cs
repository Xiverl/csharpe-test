// See https://aka.ms/new-console-template for more information
using static System.Console;


static bool isPolindrom(string word)
{
    char[] reverse_arr = word.ToCharArray();
    Array.Reverse(reverse_arr);
    string reverse_word = new string(reverse_arr);
    if (reverse_word == word)
        return true;
    return false;
}

WriteLine("Введите слово: ");
string word = ReadLine().ToString();
if (isPolindrom(word))
    WriteLine("Это слово - полиндром");
else
    WriteLine("Это слово - НЕ полнидром");
ReadKey();