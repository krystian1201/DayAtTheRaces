using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    public class Bet
    {
        public Player Player { get; private set; }

        public Greyhound Greyhound { get; private set; }

        public decimal Amount { get; private set; }

        public Bet(Player player, Greyhound greyhound, decimal amount)
        {
            Player = player;
            Greyhound = greyhound;
            Amount = amount;
        }
    }
}
