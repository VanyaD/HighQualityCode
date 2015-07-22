namespace _02.RefactorIfStatements
{
    using System;
    
    public class Potato
    {
        private bool isPeeled;
        private bool isRotten;

        public Potato()
        {
            this.isPeeled = false;
            this.isRotten = false;
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                this.isPeeled = value;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }

            set
            {
                this.isRotten = value;
            }
        }
    }
}
