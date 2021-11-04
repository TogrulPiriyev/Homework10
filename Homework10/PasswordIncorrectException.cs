using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    class PasswordIncorrectException:Exception
    {
        public PasswordIncorrectException(string message) : base(message)
        {

        }
    }
}
