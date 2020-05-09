using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.LP
{
    public class Square : Rectangle
    {
        public Square(int side)
        {
            Width = Height = side;
        }

        public void SetSize(int width, int height)
        {
            
        }

        //public new int Width { 
        //    set { base.Width = base.Height = value; }
        //}

        //public new int Height { 
        //    set { base.Height = base.Width = value; }
        //}
    }
}
