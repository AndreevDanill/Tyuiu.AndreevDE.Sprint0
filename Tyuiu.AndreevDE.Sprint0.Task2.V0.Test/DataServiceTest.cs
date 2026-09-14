using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AndreevDE.Sprint0.Task2.V0.lib;
namespace Tyuiu.AndreevDE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVakid()
        {
            var name = "Даниил";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Даниил", res);
        }
    }
}
