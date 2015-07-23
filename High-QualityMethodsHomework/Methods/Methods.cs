namespace Methods
{
    using System;

    internal class Methods
    {
        internal enum FormatOptions
        {
            Round,
            Percent,
            AlignRight
        }

        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides cannot be negative or equal to zero!");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("A valid triangle cannot be formed with the given sides!");
            }

            double semiperimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) *
                                                    (semiperimeter - b) *
                                                    (semiperimeter - c));
            return area;
        }

        internal static string DigitToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Argument should be a digit between 0 and 9 inclusive");
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot pass an empty array");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static void PrintAsNumber(object number, FormatOptions format)
        {
            if (format == FormatOptions.Round)
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == FormatOptions.Percent)
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == FormatOptions.AlignRight)
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid format option");
            }
        }

        internal static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) +
                                        ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        internal static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

        internal static bool IsLineVertical(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

        internal static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToString(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, FormatOptions.Round);
            PrintAsNumber(0.75, FormatOptions.Percent);
            PrintAsNumber(2.30, FormatOptions.AlignRight);

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsLineHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + IsLineVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
