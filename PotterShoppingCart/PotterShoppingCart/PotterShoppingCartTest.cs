using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.cs;

namespace PotterShoppingCartTest
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void PotterShoppingCart_只買第一集一本_價格100元()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

    }
}
