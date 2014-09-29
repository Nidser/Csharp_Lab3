using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Must reference the main solution. RC Unit test -> Add -> SolutionName

        //Ensure main class is "public" i.e. public class Sphere : IHasVolume

        //Ensure that classes are dll and not console Applications
        // Project -> Properties (at the bottom) -> change output to class Library. (no main required)        

        [TestMethod]
        public void TestMethod1()
        {
            int radius = 22;
            Sphere s1 = new Sphere(Color.Blue, radius);
            double result = s1.calcVolume();
            // Assert.
            Assert.AreNotSame(radius, result);            
        }

        [TestMethod]
        public void testMethod2()
        {
            int radius = 22;
            Sphere s1 = new Sphere(Color.Blue, radius);
            double result = s1.calcVolume();
            // Assert.
            Assert.IsTrue(result > radius);
            

        }
    }
}
