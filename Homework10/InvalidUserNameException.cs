using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    class InvalidUserNameException:Exception
    {
        public InvalidUserNameException(string message) : base(message)
        {

        }
    }
}
