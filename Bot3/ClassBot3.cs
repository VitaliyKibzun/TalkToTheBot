using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot3
{
    public class ClassBot3
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        public string Answer(string message)
        {
            if (message == "Hi Bot3")
            {
                return "Hi, how are you? I'm Bot3";
            }
            return "";
        }
    }
}
