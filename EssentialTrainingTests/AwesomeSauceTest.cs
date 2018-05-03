using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Texas Pete");
            testInstance.Sauces.Add("B & M BBQ");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Texas Pete"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Red Hot"));
        }
    }
}
