using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class MinimumBasicException : Exception
    {
        public MinimumBasicException(string message) : base(message)
        {
            // Console.WriteLine("Minimum Basic suppose to be 5000.");
        }
    }
}
