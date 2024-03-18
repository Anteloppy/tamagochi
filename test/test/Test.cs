using Microsoft.VisualStudio.TestTools.UnitTesting;
using tamagochi.entities;

namespace test
{
    [TestClass]
    public class Test
    {
        Stat s = new Stat();
        [TestMethod]
        public void FeedPetTest()
        {
            double x = 65;
            double add = 25;
            double expexted = 90;
            double actual = s.Act(x, add);
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod]
        public void PlayPetTest()
        {
            double x = 75;
            double add = 25;
            double expexted = 100;
            double actual = s.Act(x, add);
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod]
        public void PutPetTest()
        {
            double x = 55;
            double add = 25;
            double expexted = 80;
            double actual = s.Act(x, add);
            Assert.AreEqual(expexted, actual);
        }
    }
}
