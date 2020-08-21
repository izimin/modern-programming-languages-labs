using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp_task1
{
    class OutOfBoundSetException : ApplicationException
    {
        public OutOfBoundSetException() { }
        public  OutOfBoundSetException (string message) : base(message) { }
    }
}
