using Animals;

AnimalsInZoo elephant = new AnimalsInZoo();
elephant.Type = "elephant";
elephant.Food = new string[] { "grass", "leaves" }; 
elephant.WeightFood = 100;

elephant.DoEat("grass", 90);
elephant.Age = 1;
elephant.IsPredator = false;
Console.WriteLine(elephant.Age);
elephant.DoPlay();


AnimalsInZoo tiger = new AnimalsInZoo();
tiger.Type = "tiger";
tiger.Food = new string[] { "meat" };
tiger.WeightFood = 80;
tiger.Sound = "Rrrrrrr";
tiger.IsPredator = true;
tiger.Age = 1;

tiger.DoEat("meat", 100);
tiger.DoSound("Rrrrrrr");
tiger.DoPlay();