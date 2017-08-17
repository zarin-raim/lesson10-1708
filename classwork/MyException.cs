using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace classwork
{
    public class MyException:IOException
    {
        public string GetMessage()
        {
            return Message;
        }
    }
}
