using System;
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
            score = 0;
            kot.score = 0;
            if (age > kot.age)
            {
                score++;
            }
            else
            {
                kot.score++;
            }

            if (weight > kot.weight)
            {
                score++;
            }
            else
            {
                kot.score++;
            }
            if (strenght > kot.strenght)
            {
                score++;
            }
            else
            {
                kot.score++;
            }

            Console.WriteLine(score);
            Console.WriteLine(kot.score);
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
