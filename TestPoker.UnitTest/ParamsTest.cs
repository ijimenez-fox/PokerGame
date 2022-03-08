using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerGame;
using System;

namespace TestPoker.UnitTest
{
    [TestClass]
    public class ParamsTest
    {


        [TestMethod]
        public void ValFourofaKindResult()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 2, 2, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.FourOfKind(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValFourofaKindResultend()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 3, 3, 3 };
            int mResult = 0;
            int mHighCard = 0;
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.FourOfKind(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValFulHouseResult()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 2, 3, 3 };
            int mResult = 0;
            int mHighCard = 0;
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.FullHouse(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValFulHouseResultend()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 3, 3, 3 };
            int mResult = 0;
            int mHighCard = 0;
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.FullHouse(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }
        [TestMethod]
        public void ValStraightResult()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 4, 5, 6 };
            int mResult = 0;
            int mHighCard = 0;
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.Straight(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }
        
        [TestMethod]
        public void ValThreeofaKindInitial()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 2, 4, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.ThreeofKind(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValThreeofaKindInitial2()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 3, 3, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.ThreeofKind(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValThreeofaKindInitial3()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 3, 3, 3 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.ThreeofKind(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        
        [TestMethod]
        public void ValTwoPairsInitial()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 3, 3, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.TwoPairs(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValTwoPairs2nd()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 3, 4, 4 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.TwoPairs(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValTwoPairs3d()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 3, 4, 4 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.TwoPairs(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }


        [TestMethod]
        public void ValOnePairInitial()
        {
            //Arrange
            int[] mCards = new int[] { 2, 2, 3, 4, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.OnePair(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValOnePair2nd()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 3, 4, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.OnePair(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValOnePair3d()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 4, 4, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.OnePair(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void ValOnePair4t()
        {
            //Arrange
            int[] mCards = new int[] { 2, 3, 4, 5, 5 };
            int mResult = 0;
            int mHighCard = 0;
            //Act
            var result = PokerCls.OnePair(mCards, ref mResult, ref mHighCard);
            //Assert
            Assert.IsTrue(result);
            //ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        }

        [TestMethod]
        public void NotValidInitialParmsDuplicate()
        {
            //Arrange Duplicate Values 3S
            string cards = "2C, 2D, 3S, 3D, 4D | 3S, AC, KS, QS, JD";
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.SeparateHands(cards);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InValidInitialParms()
        {
            //Arrange Check for weight between 1...10 and A J Q K  (Not valid weight BH)
            string cards = "2C, 2S, 3S, 3D, 4D | BH, AC, KS, QS, JD";
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.SeparateHands(cards);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasDuplicateCards()
        {
            //Arrange Check for weight between 1...10 and A J Q K
            string cards = "10C, 2S, 3D, 4D, 4D | BH, AC, KS, QS, JD";
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.SeparateHands(cards);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MissingPipeInitialParms()
        {
            //Arrange
            string cards = "2C, 2S, 3S, 3D, 4D  AH, AC, KS, QS, JD";
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.SeparateHands(cards);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreValidCards()
        {
            //Arrange 
            string[] cards = new string[] { "2H", "2S", "3S", "3D", "4D" };
            //Act
            var result = PokerCls.ValidateCards(ref cards);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCardCountLessThan5()
        {
            //Arrange
            string[] cards = new string[] {"2H", "2S", "3S", "3D"};
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.ValidateCards(ref cards);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSuiteInvalid()
        {
            //Arrange
            
            string[] cards = new string[] { "2K", "2S", "3S", "3D", "4D" };
            //var firsttest = new PokerCls();
            //Act
            var result = PokerCls.ValidateCards(ref cards);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
