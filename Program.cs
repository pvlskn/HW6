using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. 
 Найти самое длинное слово в строке.
Определить является ли строка палиндромом без учёта пробелов и регистра*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение без знаков препинания");
        string Line = Console.ReadLine();
        string[] Words = Line.Split(' ');
        int MaxLenght = 0;
        string LongestWord = "";

        for (int i = 0; i < Words.Length; i++)

            if (Words[i].Length > MaxLenght)
            {
                MaxLenght = Words[i].Length;
                LongestWord = Words[i];
            }
        Console.WriteLine("{0} - самое длинное слово.", LongestWord);
        /*string LongestWords = "";
         for (int i = 0; i < Words.Length; i++) //если длинных слов больше одного, не работает(

           if (Words[i].Length == MaxLenght && Words[i] != LongestWord)
           {
               LongestWords = LongestWord + " " + Words[i];
           }*/
        string LinWoS = Line.Replace(" ","");
        char[] ReSt = LinWoS.ToCharArray();
        Array.Reverse(ReSt);
        string ReLinWoS = new string(ReSt);
        if (LinWoS == ReLinWoS)
        {
            Console.WriteLine("Предложение - полиндром");
        }
        else
        {
            Console.WriteLine("Предложение - не полиндром");
        }
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}
