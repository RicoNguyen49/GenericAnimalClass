using System;

namespace GenericAnimalClass
{
    public class Animal<T>
    {
        // define a field of type T 

        private T data;

        // define a constructor of the Animal class 
        public Animal(T data)
        {
            this.data = data;
        }

        // Method to retrieve the animal data
        public T GetAnimal()
        {
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Animal objects with different data types
            Animal<string> animalName = new Animal<string>("kangaroo");

            Animal<string> animalHabitat = new Animal<string>("Savannah,woodlands");

            Animal<int> averageLifespan = new Animal<int>(7);

            Animal<string> Location = new Animal<string>("Australia,New Guinea");

            Animal<bool> endangered = new Animal<bool>(false);

            Animal<bool> extinct = new Animal<bool>(false);


            // Print out the values using the GetAnimal method
            Console.WriteLine("Animal Name: " + animalName.GetAnimal());
            Console.WriteLine("Animal Habitat: " + animalHabitat.GetAnimal());
            Console.WriteLine("Location found: " + Location.GetAnimal());
            Console.WriteLine("Average Lifespan: " + averageLifespan.GetAnimal() + " years");
            Console.WriteLine("Endangered: " + endangered.GetAnimal());
            Console.WriteLine("Extinct: " + extinct.GetAnimal());


        }
    }
}
