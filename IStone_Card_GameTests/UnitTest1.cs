using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IStone_Card_GameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // arrange
            int InputValue = 1;
            int expected = 2;

            // act  
            InputValue = InputValue * 2;

            // assert  
            Assert.AreEqual(expected, InputValue, "Fel Fel Fel....");
        }

    //    // arrange  
    //    double beginningBalance = 11.99;
    //    double debitAmount = 4.55;
    //    double expected = 7.44;
    //    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

    //    // act  
    //    account.Debit(debitAmount);  

    //// assert  
    //double actual = account.Balance;
    //    Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");  


    }
}
