using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestToStringWithAceHearts()
        {
            Card testCard = new Card(CardFace.Ace, CardSuit.Spades);
            Console.WriteLine(testCard);
            Assert.AreEqual(
                "A♠",
                testCard.ToString(),
                "ToString method should return string in the format '[CardFace - number or capital first letter][Card Suit Char]'.");
        }

        [TestMethod]
        public void TestToStringWithKingDiamonds()
        {
            Card testCard = new Card(CardFace.King, CardSuit.Diamonds);
            Assert.AreEqual(
                "K♦",
                testCard.ToString(),
                "ToString method should return string in the format '[CardFace - number or capital first letter][Card Suit Char]'.");
        }

        [TestMethod]
        public void TestToStringWithQueenClubs()
        {
            Card testCard = new Card(CardFace.Queen, CardSuit.Clubs);
            Assert.AreEqual(
                "Q♣",
                testCard.ToString(),
                "ToString method should return string in the format '[CardFace - number or capital first letter][Card Suit Char]'.");
        }

        [TestMethod]
        public void TestToStringWithJackSpades()
        {
            Card testCard = new Card(CardFace.Jack, CardSuit.Spades);
            Assert.AreEqual(
                "J♠",
                testCard.ToString(),
                "ToString method should return string in the format '[CardFace - number or capital first letter][Card Suit Char]'.");
        }

        [TestMethod]
        public void TestToStringWithANumber()
        {
            Card testCard = new Card(CardFace.Five, CardSuit.Hearts);
            Assert.AreEqual(
                "5♥",
                testCard.ToString(),
                "ToString method should return string in the format '[CardFace - number or capital first letter][Card Suit Char]'.");
        }
    }
}
