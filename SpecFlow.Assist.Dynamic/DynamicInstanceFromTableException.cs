using System;

namespace SpecFlow.Assist.Dynamic
{
    public class DynamicInstanceFromTableException : Exception
    {
        public DynamicInstanceFromTableException(string message) : base(message) { }
    }
}