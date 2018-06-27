using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        //instantiate lists privately
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        //dictionary storing bets
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        //abstract method can only exist inside of an abstract class, and contains no implementation
        //All it does is state that any class inheriting the Game class MUST contain this method
        public abstract void Play();

        //A virtual method inside of an abstract class means that the method gets inherited but has the ability to override the inheriting class. 
        //Unlike an abstract method, a virtual method DOES have implementation.
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
