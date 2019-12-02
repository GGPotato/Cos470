using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    public interface Piece
    {
       public bool HasMoved;
       public Color Color;
        public int x;
        public int y;

        public abstract void Move(Piece[][][] board, int x, int y)
           }
}
