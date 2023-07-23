﻿// сметан+кефир+йогурт - найдет тендеры, где встречаются все три слова в названии/в одном документе, в любом порядке.
// молочн++продукт - найдет тендеры, где встречаются слова молочные и продукты, расположенные относительно друг друга 
// в пределах 10 слов, в любом порядке (т.е. продукты молочные или молочные продукты).

string text = "сметан+кефир+йогурт - найдет тендеры, где встречаются все три слова в названии/в одном документе, в любом порядке. " +
    "молочн++продукт - найдет тендеры, где встречаются слова молочные и продукты, расположенные относительно друг друга " + 
    "в пределах 10 слов, в любом порядке (т.е. продукты молочные или молочные продукты).";

// string s = "qwerty"
//             012345    
// s[3]

string Replace(string x, char OldValue, char NewValue)
{
    string newtext = String.Empty;
    int length = x.Length;
    for(int i = 0; i < length; i++)
    {
        if (x[i] == OldValue) newtext = newtext + $"{NewValue}";
        else newtext = newtext + $"{x[i]}";
    }
    return newtext;
}

string Changed = Replace(text, ' ', '-');
Changed = Replace(Changed, 'м', 'М');
Console.WriteLine(Changed);
