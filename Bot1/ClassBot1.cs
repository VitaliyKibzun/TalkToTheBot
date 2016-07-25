using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Bot1
{
    public class ClassBot1: Ibot
    {
        private string name;
        
        public string Name
        {
            get { return name; }
        }

        public string Answer(string message)
        {
            if (message == "Hi Bot1")
            {
                return "Hi, how are you? I'm Bot1";
            }
            return "";
        }
    }
}
