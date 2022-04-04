using System;

namespace SML.Models
{
    public class PresentatedFunction
    {
        public string FunctionName { get; set; }
        public Func<object, object> Function { get; set; }

        public PresentatedFunction(string functionName, Func<object, object> function)
        {
            FunctionName = functionName;
            Function = function;
        }
    }
}