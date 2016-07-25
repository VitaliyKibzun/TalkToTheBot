using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Bot2
{
    public class ClassBot2 : Ibot
    {
        private string name;

        public string Name
        {
            get { return name; } 
        }

        public string Answer(string message)
        {
            if (message == "Hi Bot2")
            {
                return "Hi, how are you? I'm Bot2";
            }
            return "";
        }
    }
}
