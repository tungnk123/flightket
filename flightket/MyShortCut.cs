using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightket
{
    public class MyShortCut
    {
        public string firctStroke;
        public string secondStroke;

        public MyShortCut()
        {
            firctStroke = "Ctrl";
            secondStroke = "";
        }
        public MyShortCut(string f, string s)
        {
            firctStroke = f;
            secondStroke = s;
        }
    }
}
