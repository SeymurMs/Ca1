using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika1Aprel
{
    class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string msg):base(msg)
        {
        }
    }
}
