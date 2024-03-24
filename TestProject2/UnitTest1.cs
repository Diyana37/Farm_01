using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farm_01;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
    [TestClass]
    public class AnimalTests
    {
        private void AssertCountEquals(int expected, int actual)
        {
            if (expected != actual)
            {
                throw new AssertionException($"Expected goat count: {expected}. Actual goat count: {actual}");
            }
        }
        private void AssertCountNotNegative(int actualCount)
        {
            if (actualCount < 0)
            {
                throw new AssertionException($"Count of cows is negative: {actualCount}");
            }
        }
        private void AssertCountNotOver1000(int actualCount)
        {
            if (actualCount > 1000)
            {
                throw new AssertionException($"Sheep count is over 1000: {actualCount}");
            }
        }
        private void AssertCountNotOver10000(int actualCount)
        {
            if (actualCount > 10000)
            {
                throw new AssertionException($"Wool count is over 10000: {actualCount}");
            }
        }
        [Test]
        public void Cow_AddAnimal_AddsCowToDatabase()
        {
            // Arrange
            string cowType = "cow";
            int initialCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            // Act
            Cow cow = new Cow();
            cow.AddAnimal();
            int updatedCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            // Assert
            Assert.That(updatedCowCount, Is.EqualTo(initialCowCount + 1), "Cow count should increase after adding");
        }

        [Test]
        public void Cow_DeleteAnimal_RemovesCowFromDatabase()
        {
            string cowType = "cow";
            int initialCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            Cow cow = new Cow();
            cow.DeleteAnimal();
            int updatedCowCount = Animal.GetAnimals().GetValueOrDefault(cowType, 0);

            Assert.That(updatedCowCount, Is.EqualTo(initialCowCount - 1), "Cow count should decrease after deletion");
        }

        [Test]
        public void Goat_AddAnimal_AddsGoatToDatabase()
        {
            string goatType = "goat";
            int initialGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Goat goat = new Goat();
            goat.AddAnimal();
            int updatedGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Assert.That(updatedGoatCount, Is.EqualTo(initialGoatCount + 1), "Goat count should increase after adding");
        }

        [Test]
        public void Goat_DeleteAnimal_RemovesGoatFromDatabase()
        {
            string goatType = "goat";
            int initialGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Goat goat = new Goat();
            goat.DeleteAnimal();
            int updatedGoatCount = Animal.GetAnimals().GetValueOrDefault(goatType, 0);

            Assert.That(updatedGoatCount, Is.EqualTo(initialGoatCount - 1), "Goat count should decrease after deletion");
        }

        [Test]
        public void Chicken_AddAnimal_AddsChickenToDatabase()
        {
            string chickenType = "chicken";
            int initialChickenCount = Animal.GetAnimals().GetValueOrDefault(chickenType, 0);

            Chicken chicken = new Chicken();
            chicken.AddAnimal();
            int updatedChickenCount = Animal.GetAnimals().GetValueOrDefault(chickenType, 0);

            Assert.That(updatedChickenCount, Is.EqualTo(initialChickenCount + 1), "Chicken count should increase after adding");
        }

        [Test]
        public void Chicken_DeleteAnimal_RemovesChickenFromDatabase()
        {
            string chickenType = "chicken";
            int initialChickenCount = Animal.GetAnimals().GetValueOrDefault(chickenType, 0);

            Chicken chicken = new Chicken();
            chicken.DeleteAnimal();
            int updatedChickenCount = Animal.GetAnimals().GetValueOrDefault(chickenType, 0);

            Assert.That(updatedChickenCount, Is.EqualTo(initialChickenCount - 1), "Chicken count should decrease after deletion");
        }
        [Test]
        public void Sheep_AddAnimal_AddsSheepToDatabase()
        {
            string sheepType = "sheep";
            int initialSheepCount = Animal.GetAnimals().GetValueOrDefault(sheepType, 0);

            Sheep sheep = new Sheep();
            sheep.AddAnimal();
            int updatedSheepCount = Animal.GetAnimals().GetValueOrDefault(sheepType, 0);

            Assert.That(updatedSheepCount, Is.EqualTo(initialSheepCount + 1), "Sheep count should increase after adding");
        }

        [Test]
        public void Sheep_DeleteAnimal_RemovesChickenFromDatabase()
        {
            string sheepType = "sheep";
            int initialSheepCount = Animal.GetAnimals().GetValueOrDefault(sheepType, 0);

            Sheep sheep = new Sheep();
            sheep.DeleteAnimal();
            int updatedSheepCount = Animal.GetAnimals().GetValueOrDefault(sheepType, 0);

            Assert.That(updatedSheepCount, Is.EqualTo(initialSheepCount - 1), "Sheep count should decrease after deletion");
        }
        [Test]
        public void MilkGoat_AddProduct_AddsMilkGoatToDatabase()
        {
            // Arrange
            string productType = "milk_goat";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Goat milkGoat = new Goat();
            milkGoat.AddProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            // Assert
            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount + 1), "Milk goat count should increase after adding");
        }

        [Test]
        public void MilkGoat_DeleteProduct_RemovesMilkGoatFromDatabase()
        {
            string productType = "milk_goat";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Goat milkGoat = new Goat();
            milkGoat.DeleteProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount - 1), "Milk goat count should decrease after deletion");
        }
        [Test]
        public void MilkCow_AddProduct_AddsMilkCowToDatabase()
        {
            // Arrange
            string productType = "milk_cow";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Cow milkCow = new Cow();
            milkCow.AddProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            // Assert
            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount + 1), "Milk cow count should increase after adding");
        }

        [Test]
        public void MilkCow_DeleteProduct_RemovesMilkCowFromDatabase()
        {
            string productType = "milk_cow";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Cow milkCow = new Cow();
            milkCow.DeleteProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount - 1), "Milk cow count should decrease after deletion");
        }

        [Test]
        public void Wool_AddProduct_AddsWoolToDatabase()
        {
            // Arrange
            string productType = "wool";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Sheep wool = new Sheep();
            wool.AddProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            // Assert
            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount + 1), "Wool count should increase after adding");
        }

        [Test]
        public void Wool_DeleteProduct_RemovesWoolFromDatabase()
        {
            string productType = "wool";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Sheep wool = new Sheep();
            wool.DeleteProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount - 1), "Wool count should decrease after deletion");
        }

        [Test]
        public void Eggs_AddProduct_AddsEggsToDatabase()
        {
            // Arrange
            string productType = "eggs";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Chicken eggs = new Chicken();
            eggs.AddProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            // Assert
            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount + 1), "Eggs count should increase after adding");
        }

        [Test]
        public void Eggs_DeleteProduct_RemovesEggsFromDatabase()
        {
            string productType = "eggs";
            int initialProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Chicken eggs = new Chicken();
            eggs.DeleteProduct();
            int updatedProductCount = Animal.GetProducts().GetValueOrDefault(productType, 0);

            Assert.That(updatedProductCount, Is.EqualTo(initialProductCount - 1), "Eggs count should decrease after deletion");
        }
        [Test]
        public void TestGoatCount()
        {

            // Arrange
            Dictionary<string, int> animals = Animal.GetAnimals();
            int expectedGoatCount = animals["goat"];

            // Act
            var goats = Animal.GetAnimals();
            int actualGoatCount = goats.ContainsKey("goat") ? goats["goat"] : 0;

            // Assert
            AssertCountEquals(expectedGoatCount, actualGoatCount);
        }
        [Test]
        public void TestCowCount()
        { 
            // Arrange
            Dictionary<string, int> animals = Animal.GetAnimals();
            int expectedCowCount = animals["cow"];

            // Act
            var cows = Animal.GetAnimals();
            int actualCowCount = cows.ContainsKey("cow") ? cows["cow"] : 0;

            // Assert
            AssertCountEquals(expectedCowCount, actualCowCount);
        }
        [Test]
        public void TestChickenCount()
        {

            // Arrange
            Dictionary<string, int> animals = Animal.GetAnimals();
            int expectedChickenCount = animals["chicken"];

            // Act
            var chickens = Animal.GetAnimals();
            int actualChickenCount = chickens.ContainsKey("chicken") ? chickens["chicken"] : 0;

            // Assert
            AssertCountEquals(expectedChickenCount, actualChickenCount);
        }
        [Test]
        public void TestSheepCount()
        {

            // Arrange
            Dictionary<string, int> animals = Animal.GetAnimals();
            int expectedSheepCount = animals["sheep"];

            // Act
            var sheeps = Animal.GetAnimals();
            int actualSheepCount = sheeps.ContainsKey("sheep") ? sheeps["sheep"] : 0;

            // Assert
            AssertCountEquals(expectedSheepCount, actualSheepCount);
        }
        [Test]
        public void TestGoatMilkCount()
        {

            // Arrange
            Dictionary<string, int> products = Animal.GetProducts();
            int expectedGoatMilkCount = products["milk_goat"];

            // Act
            var product = Animal.GetProducts();
            int actualGoatMilkCount = product.ContainsKey("milk_goat") ? product["milk_goat"] : 0;

            // Assert
            AssertCountEquals(expectedGoatMilkCount, actualGoatMilkCount);
        }
        [Test]
        public void TestCowMilkCount()
        {

            // Arrange
            Dictionary<string, int> products = Animal.GetProducts();
            int expectedCowMilkCount = products["milk_cow"];

            // Act
            var product = Animal.GetProducts();
            int actualCowMilkCount = product.ContainsKey("milk_cow") ? product["milk_cow"] : 0;

            // Assert
            AssertCountEquals(expectedCowMilkCount, actualCowMilkCount);
        }
        [Test]
        public void TestEggCount()
        {

            // Arrange
            Dictionary<string, int> products = Animal.GetProducts();
            int expectedEggCount = products["eggs"];

            // Act
            var product = Animal.GetProducts();
            int actualEggCount = product.ContainsKey("eggs") ? product["eggs"] : 0;

            // Assert
            AssertCountEquals(expectedEggCount, actualEggCount);
        }
        [Test]
        public void TestWoolCount()
        {

            // Arrange
            Dictionary<string, int> products = Animal.GetProducts();
            int expectedWoolCount = products["wool"];

            // Act
            var product = Animal.GetProducts();
            int actualWoolCount = product.ContainsKey("wool") ? product["wool"] : 0;

            // Assert
            AssertCountEquals(expectedWoolCount, actualWoolCount);
        }
        [Test]
        public void TestCowCount_NotNegative()
        {
            // Act
            var cows = Animal.GetAnimals();
            int actualCowCount = cows.ContainsKey("cow") ? cows["cow"] : 0;

            // Assert
            AssertCountNotNegative(actualCowCount);
        }
        [Test]
        public void TestChickenCount_NotNegative()
        {
            // Act
            var chickens = Animal.GetAnimals();
            int actualChickenCount = chickens.ContainsKey("chicken") ? chickens["chicken"] : 0;

            // Assert
            AssertCountNotNegative(actualChickenCount);
        }

        [Test]
        public void TestGoatCount_NotNegative()
        {
            // Act
            var goats = Animal.GetAnimals();
            int actualGoatCount = goats.ContainsKey("goat") ? goats["goat"] : 0;

            // Assert
            AssertCountNotNegative(actualGoatCount);
        }
        [Test]
        public void TestSheepCount_NotNegative()
        {
            // Act
            var sheeps = Animal.GetAnimals();
            int actualSheepCount = sheeps.ContainsKey("sheep") ? sheeps["sheep"] : 0;

            // Assert
            AssertCountNotNegative(actualSheepCount);
        }
        [Test]
        public void TestCowMilkCount_NotNegative()
        {
            // Act
            var cowMilk = Animal.GetAnimals();
            int actualCowMilkCount = cowMilk.ContainsKey("milk_cow") ? cowMilk["milk_cow"] : 0;

            // Assert
            AssertCountNotNegative(actualCowMilkCount);
        }
        [Test]
        public void TestEggsCount_NotNegative()
        {
            // Act
            var eggs = Animal.GetProducts();
            int actualEggsCount = eggs.ContainsKey("eggs") ? eggs["eggs"] : 0;

            // Assert
            AssertCountNotNegative(actualEggsCount);
        }

        [Test]
        public void TestGoatMilkCount_NotNegative()
        {
            // Act
            var goatMilk = Animal.GetProducts();
            int actualGoatMilkCount = goatMilk.ContainsKey("milk_goat") ? goatMilk["milk_goat"] : 0;

            // Assert
            AssertCountNotNegative(actualGoatMilkCount);
        }
        [Test]
        public void TestWoolCount_NotNegative()
        {
            // Act
            var wool = Animal.GetProducts();
            int actualWoolCount = wool.ContainsKey("wool") ? wool["wool"] : 0;

            // Assert
            AssertCountNotNegative(actualWoolCount);
        }
        [Test]
        public void TestSheepCount_NotOver1000()
        {
            // Act
            var sheeps = Animal.GetAnimals();
            int actualSheepCount = sheeps.ContainsKey("sheep") ? sheeps["sheep"] : 0;

            // Assert
            
            AssertCountNotOver1000(actualSheepCount);       
        }
        [Test]
        public void TestCowCount_NotOver1000()
        {
            // Act
            var cows = Animal.GetAnimals();
            int actualCowCount = cows.ContainsKey("cow") ? cows["cow"] : 0;

            // Assert
          
            AssertCountNotOver1000(actualCowCount);          
        }
        [Test]
        public void TestChickenCount_NotOver1000()
        {
            // Act
            var chickens = Animal.GetAnimals();
            int actualChickenCount = chickens.ContainsKey("chicken") ? chickens["chicken"] : 0;

            // Assert
          
            AssertCountNotOver1000(actualChickenCount);       
        }
        [Test]
        public void TestGoatCount_NotOver1000()
        {
            // Act
            var goats = Animal.GetAnimals();
            int actualGoatCount = goats.ContainsKey("goat") ? goats["goat"] : 0;

            // Assert      
            AssertCountNotOver1000(actualGoatCount);
        }
        [Test]
        public void TestWoolCount_NotOver10000()
        {
            // Act
            var wool = Animal.GetProducts();
            int actualWoolCount = wool.ContainsKey("wool") ? wool["wool"] : 0;

            // Assert
            AssertCountNotOver10000(actualWoolCount);
        }
        [Test]
        public void TestEggsCount_NotOver10000()
        {
            // Act
            var eggs = Animal.GetProducts();
            int actualEggsCount = eggs.ContainsKey("eggs") ? eggs["eggs"] : 0;

            // Assert
            AssertCountNotOver10000(actualEggsCount);
        }
        [Test]
        public void TestMilkGoatCount_NotOver10000()
        {
            // Act
            var milkGoat = Animal.GetProducts();
            int actualMilkGoatCount = milkGoat.ContainsKey("milk_goat") ? milkGoat["milk_goat"] : 0;

            // Assert
          
            AssertCountNotOver10000(actualMilkGoatCount);
        }
        [Test]
        public void TestMilkCowCount_NotOver10000()
        {
            // Act
            var milkCow = Animal.GetProducts();
            int actualMilkCowCount = milkCow.ContainsKey("milk_cow") ? milkCow["milk_cow"] : 0;

            // Assert
            AssertCountNotOver10000(actualMilkCowCount);
        }
    }
}