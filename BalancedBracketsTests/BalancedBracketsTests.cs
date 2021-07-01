using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        /*[TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }*/

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void OnlyBracketsAndEmptyReturnsTrue() //' "" ' condition
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void OnlyOpeningBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[")); //should fail
        }
        [TestMethod]
        public void OnlyClosingBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]")); //should fail
        }
        [TestMethod]
        public void UnBalancedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code[")); //should fail
        }
        [TestMethod]
        public void OneBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode")); //should fail
        }
        [TestMethod]
        public void UnclosedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][")); //should fail
        }
    }
}
