using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Point
    {
        #region
        int x = 0;
        int y = 0;
        string s = "";
        #endregion
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string S
        {
            get { return s; }
        }
        public Point(int x, int y, string s)
        {
            this.x = x;
            this.y = y;
            this.s = s;

        }
    }
}
