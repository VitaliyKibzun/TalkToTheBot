using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface Ibot
    {
        string Name { get; }

        string Answer(string message);
    }
}
