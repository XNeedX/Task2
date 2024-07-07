using System;

namespace Task2
{
    public class CrocodileService
    {
        private List<Crocodile> crocodiles = new List<Crocodile>();

        public void CreateCrocodile(string name, double weight, double length, int age, string gender)
        {
            Crocodile crocodile = new Crocodile(name, weight, length, age, gender);
            crocodiles.Add(crocodile);
        }

        public void PrintAllCrocodiles()
        {
            foreach (var croc in crocodiles)
            {
                Console.WriteLine(croc.ToString());
            }
        }

        public void PrintCrocodilesLongerThan(double length)
        {
            var longCrocodiles = crocodiles.Where(c => c.Length > length);
            foreach (var croc in longCrocodiles)
            {
                Console.WriteLine(croc.ToString());
            }
        }

        public void PrintOldestCrocodile()
        {
            if (crocodiles.Count == 0)
            {
                Console.WriteLine("No crocodiles available.");
                return;
            }
            var oldestCrocodile = crocodiles.OrderByDescending(c => c.Age).First();
            Console.WriteLine("Oldest Crocodile: " + oldestCrocodile.ToString());
        }

        public void PrintHeaviestCrocodile()
        {
            if (crocodiles.Count == 0)
            {
                Console.WriteLine("No crocodiles available.");
                return;
            }
            var heaviestCrocodile = crocodiles.OrderByDescending(c => c.Weight).First();
            Console.WriteLine("Heaviest Crocodile: " + heaviestCrocodile.ToString());
        }
    }
}
