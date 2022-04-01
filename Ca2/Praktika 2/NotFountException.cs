using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2
{
    class NotFountException:Exception
    {
        public NotFountException(string msg):base(msg)
        {
        }
    }
}
