namespace _02.RefactorIfStatements
{
    using System;
    using System.IO;

    public class RefactoredIfStatements
    {
        public static void Main()
        {
            const int MIN_ROW = 0;
            const int MAX_ROW = 25;
            const int MIN_COL = 0;
            const int MAX_COL = 5;

           /*
           Potato potato;
           if (potato != null)
               if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                   Cook(potato);
           */

            Potato potato = new Potato();
            potato.IsPeeled = true;
            Cook(potato);

            /*
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            {
               VisitCell();
            }
             */

            int row = 20;
            int col = 50; 
            bool canBeVisited = true;
        
            if (isValidPosition(row, MIN_ROW, MAX_ROW) && 
                isValidPosition(col, MIN_COL, MAX_COL) &&
                canBeVisited)
            {
                VisitCell();
            }
                
        }

        private static void VisitCell()
        {
            // implement some visitcell logic;
        }
      
        private static bool isValidPosition(int value, int minValue, int maxValue)
        {
            if ( minValue <= value && value <= maxValue)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        private static void Cook(Potato potato)
        {
            if (PotatoIsProvided(potato) && potato.IsPeeled && !potato.IsRotten)
            {
                Console.WriteLine("Cooking");
            }
        }

        private static bool PotatoIsProvided(Potato potato)
        {
            if (potato != null)
            {
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("A Potato object should be passed");
            }
        }
    }
}
