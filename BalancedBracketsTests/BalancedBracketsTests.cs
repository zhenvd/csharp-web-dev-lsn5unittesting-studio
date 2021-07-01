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
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void OnlyBracketsAndEmptyReturnsTrue() //' "" ' condition
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void OnlyOpeningBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[")); //should fail
        }
        [TestMethod]
        public void OnlyClosingBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("]")); //should fail
        }
        [TestMethod]
        public void UnBalancedBracketsReturnFalse()
        {
            Assert.IsTrue(BalancedBrackets.UnBalancedBracketsHasClosingBracketsFirst("Launch]Code[")); //should fail
        }

    }
}
