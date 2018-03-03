using System;

namespace RGott
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = "Hello World";
            RGott.Interop.Language.StaticBinding(msg);
        }
    }
}
