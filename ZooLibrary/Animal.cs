namespace ZooLibrary
{
    public abstract class Animal: IComparable<Animal>
    {
        public string Name { get; set; }

		private int limbCount;

		public int LimbCount
		{
			get { return limbCount; }
			set { 
                if (value < 0) 
                {
                    value = 0;
                }
                limbCount = value; 
            }
		}

        private string colour;

        //public string GetColour()
        //{
        //	return colour;
        //}

        //public void SetColour(string value)
        //{
        //	List<string> colours = new List<string> { "Grey", "Brown", "Yellow", "Black", "White,", "Black and White" };
        //	if (!colours.Contains(value)) 
        //	{
        //		value = "Grey";
        //	}
        //	colour = value;
        //}

        public string Colour
        {
            get { 
                return colour;
            }
            set
            {
                List<string> colours = new List<string> { "Grey", "Brown", "Yellow", "Black", "White", "Black and White" };
                if (!colours.Contains(value))
                {
                    value = "Grey";
                }
                colour = value;
            }
        }

        public override string ToString()
        {
            return $"I'm a {this.Colour} animal called {this.Name} and I have {this.LimbCount} limbs.";
        }

        //public virtual string Eat(string food)
        //{

        //   return $"I'm a {this.GetType().Name} eating {food}";
        //}

        public abstract string Eat(string food);

        public string Move(string direction)
        {

            return $"I'm a {this.GetType().Name} moving {direction}";
        }

        public int CompareTo(Animal? other)
        {
            return this.LimbCount - other.LimbCount;
        }

        #region comparare

        //Limb Count Comparer Stuff
        private static IComparer<Animal> animalLimbCountComparer = null;
        public static IComparer<Animal> GetAnimalLimbCountComparer
        {
            get
            {
                if (animalLimbCountComparer == null)
                {
                    animalLimbCountComparer = new AnimalLimbCountComparer();
                }
                return animalLimbCountComparer;
            }
        }

        private class AnimalLimbCountComparer : IComparer<Animal>
        {
            public int Compare(Animal? x, Animal? y)
            {
                return x.LimbCount.CompareTo(y.LimbCount);
            }
        }

        //Name Comparer Stuff
        private static IComparer<Animal> animalNameComparer = null;
        public static IComparer<Animal> GetAnimalNameComparer
        {
            get
            {
                if (animalNameComparer == null)
                {
                    animalNameComparer = new AnimalNameComparer();
                }
                return animalNameComparer;
            }
        }

        private class AnimalNameComparer : IComparer<Animal>
        {
            public int Compare(Animal? x, Animal? y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        private static IComparer<Animal> animalColourComparer = null;
        public static IComparer<Animal> GetAnimalColourComparer
        {
            get
            {
                if (animalColourComparer == null)
                {
                    animalColourComparer = new AnimalColourComparer();
                }
                return animalColourComparer;
            }
        }

        private class AnimalColourComparer : IComparer<Animal>
        {
            public int Compare(Animal? x, Animal? y)
            {
                return x.Colour.CompareTo(y.Colour);
            }
        }
        #endregion
    }
}

