namespace CatFactory
{
	class Cat
    {
		public string name;
		public double age;
		public double weight;
		public double strenght;
        int score = 0;
        public Cat(string name, double age, double weight, double strenght)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.strenght = strenght;
        }
        public string Fight(Cat kot)
        {
            if (age > kot.age)
            {
                score++;
                if (weight > kot.weight)
                {
                    score++;
                    if (strenght > kot.strenght)
                    {
                        score++;
                    }
                }
            }
            if (age < kot.age)
            {
                kot.score++;
                if (weight < kot.weight)
                {
                    kot.score++;
                    if (strenght < kot.strenght)
                    {
                        kot.score++;
                    }
                }
            }

            if (score < kot.score)
            {
                return kot.name;
            }
            else
            {
                return name;
            }
        }
	}
}
