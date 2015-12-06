using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    public class Player
    {
        public string Name { get; private set; }

        public decimal Money { get; private set; }


        public Player(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public override bool Equals(object obj)
        {
            Player player = obj as Player;

            return player != null && player.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
