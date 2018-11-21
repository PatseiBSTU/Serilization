
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Serialization
{
  
        [Serializable]
        public class Point
        {
            public int x = 10;
            public int y = 20;
            public virtual int Sum()
            { return x + y; }
        public Point (int x, int y )
        {
            this.x = x;
            this.y = y;
        }

        }

  
}