using System;


namespace Task2
{
    public class Crocodile
    {

        public string Name { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Crocodile(string name, double weight, double length, int age, string gender)
        {
            Name = name;
            Weight = weight;
            Length = length;
            Age = age;
            Gender = gender;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Weight: {Weight} kg, Length: {Length} m, Age: {Age} years, Gender: {Gender}";
        }
    }
}
