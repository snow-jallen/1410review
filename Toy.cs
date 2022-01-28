namespace MyApp // Note: actual namespace depends on the project name.
{
    public abstract class Toy : IProduct
    {
        public Toy(int minAge)
        {
            MinAge = minAge;
            Console.WriteLine("\tIn the Toy ctor");
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int minAge;
        public int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }

        public bool Inspect()
        {
            if (MinAge < 3)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"Toy: {base.ToString()}: ";
        }
    }

    public class Dradle : Toy
    {
        public Dradle(int minAge, DradleSize size) : base(minAge)
        {
            Size = size;
        }

        private DradleSize size;
        public DradleSize Size
        {
            get { return size; }
            set { size = value; }
        }
        
        public override string ToString()
        {
            return base.ToString() + " (" + Size + ")";
        }
    }

    public enum DradleSize
    {
        Small,
        Medium,
        Large
    }

    public class TekDek : Toy
    {
        public TekDek() : base(5)
        {

        }
    }

    public class Lego : Toy
    {
        public Lego(int minAge, string name) : base(minAge)
        {
            Console.WriteLine("\tIn the Lego() ctor");
            Name = name;
        }

        public Lego Combine(Lego otherSet)
        {
            var newMinAge = Math.Max(this.MinAge, otherSet.MinAge);
            var newName = $"{this.Name} + {otherSet.Name}";
            var newMegaSet = new Lego(newMinAge, newName);
            return newMegaSet;
        }
    }

    public class Technic : Lego
    {
        public Technic(int minAge, string name) : base(minAge, name)
        {
            Console.WriteLine("\tIn the Technic constructor");
        }
    }
}