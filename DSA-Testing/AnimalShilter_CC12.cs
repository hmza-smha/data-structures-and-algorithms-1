using System;
using data_structures_and_algorithms_1.stack_queue_animal_shelter;
using Xunit;

namespace DSA_Testing
{
    public class AnimalShilter_CC12
    {
        [Fact]
        public void Test_Dog()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog1 = new Dog();
            animalShelter.Enqueue(dog1);

            Assert.True(animalShelter.Dogs.Dequeue() is Dog);
        }


        [Fact]
        public void Test_Cat()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal cat1 = new Cat();
            animalShelter.Enqueue(cat1);

            Assert.True(animalShelter.Cats.Dequeue() is Cat);
        }


        [Fact]
        public void Test_Dog_Dequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog1 = new Dog();
            animalShelter.Enqueue(dog1);

            Assert.True(animalShelter.Dequeue("dog") is Dog);
        }

        [Fact]
        public void Test_Cat_Dequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal cat1 = new Cat();
            animalShelter.Enqueue(cat1);

            Assert.True(animalShelter.Dequeue("cat") is Cat);
        }
    }
}
