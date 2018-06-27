using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway
    {
        //Like creating an abstract class, but can be inherited (due to being an interface) by TwentyOneGame.cs and does NOT feel appropriate to put in the 'game.cs' file
        void WalkAway(Player player);
    }
}
