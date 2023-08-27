using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingTool
{
    public class DrawingTool
    {
        public DrawingTool(Shape shape)
        {
            shape.Draw();
        }
    }
}
