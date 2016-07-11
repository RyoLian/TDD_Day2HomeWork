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


        [TestMethod]
        public void 第一集買一本_第二集也買一本_價格應為_190()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(1);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_價格應為_270()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(1);
            cal.BuyThird(1);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_價格應為_320()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(1);
            cal.BuyThird(1);
            cal.BuyForth(1);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void 一次買了整套_一二三四五集各買了一本_價格應為_375()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(1);
            cal.BuyThird(1);
            cal.BuyForth(1);
            cal.BuyFifth(1);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void 一二集各買了一本_第三集買了兩本_價格應為_370()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(1);
            cal.BuyThird(2);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void 第一集買了一本_第二三集各買了兩本_價格應為_460()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(2);
            cal.BuyThird(2);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 460;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void 第一集_1_第二集_3_第三集_3_第四集_5_第五集_2_應為1165()
        {
            //arrange
            var cal = new PotterShoppingCart_Class();
            cal.BuyFirst(1);
            cal.BuySecond(3);
            cal.BuyThird(3);
            cal.BuyForth(5);
            cal.BuyFifth(2);

            //act
            var actual = cal.Caltotal();

            //assert
            var expected = 1165;
            Assert.AreEqual(expected, actual);
        }
    }
}
