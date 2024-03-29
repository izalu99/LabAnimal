﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<author> Iza Lumpio </author>
            ///<date> February 10 2023 </date>

            ///<summary>
            ///for testing;
            ///To test the program, ask the user for a dog name and create a new Dog type object from
            ////the Main of the program.Give the Dog object a name, colour and age, and then execute
            ////the getter methods to print these properties and the Eat methods.
            ///</summary>

            //dog
            Console.WriteLine("Enter Dog's name: ");
            string enteredDogName = Console.ReadLine();
            string aColour = "brown";
            int anAge = 7;

            Dog newDog = new Dog(enteredDogName, aColour, anAge);
            
            Console.WriteLine(String.Format("Dogname: {0}\n" +
                              "Colour:{1}\n" +
                              "Age:{2}", newDog.Name, newDog.Colour,newDog.Age));

            //cat
            Console.WriteLine("Enter Cat's name: ");
            string enteredCatName = Console.ReadLine();

            Cat newCat = new Cat(enteredCatName, "grey", 6);

            Console.WriteLine(String.Format("Cat name: {0}\n" +
                              "Colour:{1}\n" +
                              "Age:{2}", newCat.Name, newCat.Colour, newCat.Age));

            //testing the interface
            ImplementedCat cat2 = new ImplementedCat("Kat", "white", 4);
            cat2.Eat();
            Console.WriteLine(cat2.Cry());

            ImplementedDog dog2 = new ImplementedDog("Dogogo", "white", 5);
            dog2.Eat();
            Console.WriteLine(dog2.Cry());


            // create a list called animals and populate the list
            // make this more efficient
            List<Animal> animals = new List<Animal>();
            Dog dog3 = new Dog("Berry", "white", 3);
            Dog dog4 = new Dog("Pumpkin", "grey", 3);
            Dog dog5 = new Dog("Cookie", "brown", 3);
            Cat cat3 = new Cat("Strawberry", "grey", 4);
            Cat cat4 = new Cat("Lemons", "grey", 4);
            Cat cat5 = new Cat("Boots", "grey", 3);
            animals.Add(cat3);
            animals.Add(cat4);
            animals.Add(dog3);
            animals.Add(dog4);
            animals.Add(dog5);
            animals.Add(cat5);
            animals.Add(dog5);
            //print all the names of the animals
            Console.WriteLine("The names of cats and dogs in the list is: \n");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
                
            }


        }
    }
}
