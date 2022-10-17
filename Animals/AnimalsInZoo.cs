
namespace Animals
{
    public class AnimalsInZoo
    {
        public string Type { get; set; }
        public string Habitat { get; set; }
        public int HabitatArea { get; set; }
        public string[] Food { get; set; }
        public bool IsPredator { get; set; }
        public string Sound { get; set; }
        public string Name { get; set; }
        public double WeightFood { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        private int _age;
        public void DoEat(string food, double weightFood)
        {
            for (int i = 0; i < Food.Length; i++)
            {
                if (food == Food[i])
                {
                    if (weightFood <= WeightFood)
                    {
                        Console.WriteLine($"I ate {food}");
                    }
                    else
                    {
                        Console.WriteLine("I gorged");
                    }
                }
            }
        }
        public void DoSound(string sound)
        {
            if (sound == Sound)
            {
                Console.WriteLine($"{sound}");
            }
        }
        public void DoPlay()
        {
            if (!IsPredator && _age <= 2)
            {
                Console.WriteLine($"{Type} play with you");
            }
            else if (IsPredator)
            {
                Console.WriteLine($"Play with {Type} is dangerous");
            }
        }

    }
}
