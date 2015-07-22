namespace _03.RefactorLoop
{
    using System;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            int expectedValue = 5;
            int[] values = new int[100];

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(values[i]);

                if ((i % 10 == 0) && (values[i] == expectedValue))
                {
                    Console.WriteLine("Value found");
                    break;
                }               
            }
        }
    }
}
