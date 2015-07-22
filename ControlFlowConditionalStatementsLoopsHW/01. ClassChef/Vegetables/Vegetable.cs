namespace _01.ClassChefInCSharp
{
    using System;

    public class Vegetable
    {
        private bool isPeeled;
        private bool isRotten;
        private bool isCutted;

        public Vegetable()
        {
            this.isPeeled = false;
            this.isRotten = false;
            this.isCutted = false;
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
        }

        public bool IsCutted
        {
            get
            {
                return this.isCutted;
            }

            set
            {
                this.IsCutted = value;
            }
        }
    }
}
