using System;
using System.Collections.Generic;

public class DecreasingAbsoluteDifference
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        string lines = string.Empty;
        bool isSmaller = false;
        bool isDec = false;
        List<int> absDiff = new List<int>();
        int absAbsDiff = 0;
        int temp = 0;

        for (int i = 0; i < numberOfLines; i++)
        {
            lines = Console.ReadLine();
            string[] linesStr = lines.Split(' ');

            int[] nums = new int[linesStr.Length];

            for (int j = 0; j < linesStr.Length; j++)
            {
                nums[j] = int.Parse(linesStr[j]);
            }

            for (int k = 0; k < nums.Length - 1; k++)
            {
                temp = nums[k] - nums[k + 1];

                if (temp < 0)
                {
                    temp = -(nums[k] - nums[k + 1]);
                }

                absDiff.Add(temp);
            }

            for (int j = 0; j < absDiff.Count - 1; j++)
            {
                absAbsDiff = absDiff[j] - absDiff[j + 1];

                if ((absAbsDiff != 0) && (absAbsDiff != 1) && (absAbsDiff != -1))
                {
                    isDec = true;
                    break;
                }
            }

            for (int m = 1; m < absDiff.Count; m++)
            {
                if (absDiff[m - 1] < absDiff[m])
                {
                    isSmaller = true;
                    break;
                }
            }

            if ((isDec == true) || (isSmaller == true))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            isDec = false;
            isSmaller = false;
            absDiff.Clear();
        }
    }
}


