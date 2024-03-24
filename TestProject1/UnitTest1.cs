using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farm_01;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void Cow_AddAnimal_AddsCowToDatabase()
        {
            // Arrange
            string cowType = "cow";
            double milkProductionPerWeek = 140.00;
            int initialCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            // Act
            Cow cow = new Cow();
            cow.AddAnimal();
            int updatedCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            // Assert
            Assert.That(updatedCowCount, Is.EqualTo(initialCowCount + 1), "Cow count should increase after adding");
        }

        [TestMethod]
        public void Cow_DeleteAnimal_RemovesCowFromDatabase()
        {
            string cowType = "cow";
            int initialCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            Cow cow = new Cow();
            cow.DeleteAnimal();
            int updatedCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            Assert.That(updatedCowCount, Is.EqualTo(initialCowCount - 1), "Cow count should decrease after deletion");
        }

        [TestMethod]
        public void Goat_AddAnimal_AddsGoatToDatabase()
        {
            string goatType = "goat";
            double milkProductionPerWeek = 15.00;
            int initialGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Goat goat = new Goat();
            goat.AddAnimal();
            int updatedGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Assert.That(updatedGoatCount, Is.EqualTo(initialGoatCount + 1), "Goat count should increase after adding");
        }

        [TestMethod]
        public void Goat_DeleteAnimal_RemovesGoatFromDatabase()
        {
            string goatType = "goat";
            int initialGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Goat goat = new Goat();
            goat.DeleteAnimal();
            int updatedGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Assert.That(updatedGoatCount, Is.EqualTo(initialGoatCount - 1), "Goat count should decrease after deletion");
        }

        [TestMethod]
        public void Hen_AddAnimal_AddsHenToDatabase()
        {
            string henType = "hen";
            int eggProductionPerWeek = 7;
            int initialHenCount = Animal.GetAnimals().GetValueOrDefault(henType, 0);

            Hen hen = new Hen();
            hen.AddAnimal();
            int updatedHenCount = Animal.GetAnimals().GetValueOrDefault(henType, 0);

            Assert.That(updatedHenCount, Is.EqualTo(initialHenCount + 1), "Hen count should increase after adding");
        }

        [TestMethod]
        public void Hen_DeleteAnimal_RemovesHenFromDatabase()
        {
            string henType = "hen";
            int initialHenCount = Animal.GetAnimals().GetValueOrDefault(henType, 0);

            Hen hen = new Hen();
            hen.DeleteAnimal();
            int updatedHenCount = Animal.GetAnimals().GetValueOrDefault(henType, 0);

            Assert.That(updatedHenCount, Is.EqualTo(initialHenCount - 1), "Hen count should decrease after deletion");
        }
    }
}