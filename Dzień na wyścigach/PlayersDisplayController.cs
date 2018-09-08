using System;
using System.Collections.Generic;

namespace DayAtTheRaces
{
    public class PlayersDisplayController
    {
        private readonly HashSet<Player> _players;


        public PlayersDisplayController(HashSet<Player> players)
        {
            _players = players;
        }

        public void AddPlayer(string playerName, string playerMoney)
        {
            decimal moneyDecimal;

            if (decimal.TryParse(playerMoney, out moneyDecimal))
            {
                Player player = new Player(playerName, moneyDecimal);

                if (moneyDecimal < Bet.MINIMUM_BET)
                {
                    throw new
                        ArgumentOutOfRangeException("moneyDecimal", String.Format("Amount: {0} is below minimum bet amount: {1}",
                            moneyDecimal, Bet.MINIMUM_BET));
                }
                                       

                if (!_players.Add(player))
                {
                    throw new ArgumentException(String.Format("Player with name '{0}' already exists", playerName));
                }  
            }
            else
            {
                throw new InvalidCastException("Invalid format for money");
            }
        }  
    }
}
