using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki
{
    internal class InneWymiaryException : Exception
    {
        public InneWymiaryException(string message) : base(message)
        {

        }
    }
}
