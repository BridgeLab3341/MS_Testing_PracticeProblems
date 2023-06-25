using MS_Testing_PracticeProblems;

namespace PracticeProblemTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShopKeeperSoldItem_WhenAnalyze_ShouldReturnSoldOnce()
        {
            int[] prices = { 10, 20, 30, 10, 40, 50, 20 };
            PurchaseListOperation purchase = new PurchaseListOperation();
            int result=purchase.OneTimeSold(prices);
            Assert.AreEqual(result,30);
        }
        [TestMethod]
        public void ShopKeeperSoldItem_WhenAnalyze_ShouldReturnSoldMore()
        {
            int[] prices = { 10, 20, 30, 10, 40, 50, 20 };
            PurchaseListOperation purchase = new PurchaseListOperation();
            int result = purchase.SoldMore(prices);
            Assert.AreEqual(result,10);
        }
    }
}