using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace TicTacToe_labb9
{
    class Runtime
    {
        
        GameBoard gameboard = new GameBoard();
        public void Start()
        {

            gameboard.DrawGameBoard();
            GamePlay();
        }
        public void GamePlay()
        {
            gameboard.Render();
            gameboard.PlaceMarker();
           
            GamePlay();

        }

        public void Pause()
        {

        }
    }
}
