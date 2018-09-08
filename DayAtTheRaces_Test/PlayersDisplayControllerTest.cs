using System;
using System.Collections.Generic;
using DayAtTheRaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DayAtTheRaces_Test
{
    [TestClass]
    public class PlayersDisplayControllerTest
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldNotAddPlayerIfPlayerWithSuchNameAlreadyExists()
        {
            HashSet<Player> players = new HashSet<Player>();

            PlayersDisplayController controller = new PlayersDisplayController(players);

            string name  = "Player";

            controller.AddPlayer(name, "10");
            controller.AddPlayer(name, "20");
            
            Assert.AreEqual(1, players.Count);
        }


        [ExpectedException(typeof(InvalidCastException))]
        [TestMethod]
        public void ShouldNotAddPlayerIfMoneyIsStringOfLetters()
        {
            HashSet<Player> players = new HashSet<Player>();

            PlayersDisplayController controller = new PlayersDisplayController(players);

            controller.AddPlayer("Player", "sadfds");

            Assert.AreEqual(0, players.Count);
        }


        [ExpectedException(typeof(InvalidCastException))]
        [TestMethod]
        public void ShouldNotAddPlayerIfMoneyContainsDot()
        {
            HashSet<Player> players = new HashSet<Player>();

            PlayersDisplayController controller = new PlayersDisplayController(players);

            controller.AddPlayer("Player", "10.23");

            Assert.AreEqual(0, players.Count);
        }


        [TestMethod]
        public void ShouldAddPlayerIfMoneyContainsComma()
        {
            HashSet<Player> players = new HashSet<Player>();

            PlayersDisplayController controller = new PlayersDisplayController(players);

            controller.AddPlayer("Player", "10,23");

            Assert.AreEqual(1, players.Count);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ShouldNotAddPlayerIfMoneyIsBelowMinimumBet()
        {
            HashSet<Player> players = new HashSet<Player>();

            PlayersDisplayController controller = new PlayersDisplayController(players);

            controller.AddPlayer("Player", (Bet.MINIMUM_BET - 0.1m).ToString());

            Assert.AreEqual(0, players.Count);
        }

    }
}
