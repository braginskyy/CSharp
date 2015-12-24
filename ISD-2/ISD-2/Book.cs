using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    public class Book
    {
        #region
        protected static string title = "";
        protected static string author = "";
        protected static string content = "";
        #endregion
        public string Title
        {
            set { title = value; }
        }
        public string Author
        {
            set { author = value; }
        }
        public string Content
        {
            set { content = value; }
        }
    }
}
