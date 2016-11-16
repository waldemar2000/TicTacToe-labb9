using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_labb9
{
    class Node
    {
        public bool Taken { get; set; } = false;
        public int Player { get; set; } = 1;
        public int PositionRow { get; set; } = 0;
        public int PositionCol { get; set; } = 0;

    }
}
