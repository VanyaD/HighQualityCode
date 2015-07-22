namespace _01.ClassChefInCSharp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Bowl 
    {
        private List<Vegetable> setOfVegetables = new List<Vegetable>();

        public Bowl()
        {
            this.setOfVegetables = new List<Vegetable>();
        }

        public List<Vegetable> SetOfVegetables
        {
            get
            {
                return this.setOfVegetables;
            }
        }

        public void Add(Vegetable vegetable)
        {
            this.setOfVegetables.Add(vegetable);
        }    
    }
}
