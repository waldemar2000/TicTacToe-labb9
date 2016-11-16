using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_labb9
{
    interface Interface
    {
        Node[,] Grid { get; set; }

        void PlaceMarker();
        void Render();
    }
}
