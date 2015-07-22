namespace _01.ClassChefInCSharp
{
    using System;
    using System.Collections.Generic;
    using _01.ClassChefInCSharp;

    public class Chef
    {
        public Chef()
        {
        }

        public void Cook()
        {
            Bowl bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCutted = true;
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }
    }
}
