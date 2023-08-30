using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingTool
{
    public abstract class Shape
    {
        public abstract void Draw();

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
