using System;
using System.Collections.Generic;
using System.Text;


class EnigmaCat
{
    static void Main(string[] args)
    {
        string inputInLowerCase = Console.ReadLine();
        string[] words = inputInLowerCase.Split(' ');
        StringBuilder lettersInWord = new StringBuilder();

        long[] dec = new long[words.Length];
        long num = 0;

        long[] result = new long[dec.Length];
        long remainder = 0;
        string output = string.Empty;


        for (int i = 0; i < words.Length; i++)
        {
            lettersInWord.Append(words[i]);
            long[] newStr = new long[lettersInWord.Length];

            for (int j = 0; j < lettersInWord.Length; j++)
            {
                num = lettersInWord[j] - 97;
                newStr[j] = num;
            }

            long multiplier = 1;

            for (int k = 0; k < newStr.Length; k++)
            {
                dec[i] = dec[i] + newStr[newStr.Length - 1 - k] * multiplier;
                multiplier = multiplier * 17;
            }

            lettersInWord.Clear();
        }

        List<long> tr = new List<long>();

        for (int i = 0; i < dec.Length; i++)
        {
            if (dec[i] == 0)
            {
                tr.Add(0);
            }

            while (dec[i] > 0)
            {
                remainder = dec[i] % 26;
                dec[i] = dec[i] / 26;
                tr.Add(remainder);
            }

            tr.Reverse();

            for (int m = 0; m < tr.Count; m++)
            {
                char letters = (char)(97 + tr[m]);
                Console.Write(letters);

                if (m == (tr.Count - 1) && (i != dec.Length - 1))
                {
                    Console.Write(' ');
                }
            }

            tr.Clear();
        }

        Console.WriteLine();
    }
}



