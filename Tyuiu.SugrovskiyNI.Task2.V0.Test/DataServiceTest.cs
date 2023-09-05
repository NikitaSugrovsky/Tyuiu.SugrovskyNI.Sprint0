using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SugrovskiyNI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SugrovskiyNI.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Никита";
            var res = DataService.GetMassage(name);



            Assert.AreEqual("Привет, Никита", res);
        }
    }
}
