using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Scripting.Hosting;
using IPY = IronPython.Hosting;

namespace RGott.Python
{
    public class Wrapper
    {
        public static dynamic GetPythonRunTime()
        {
            return IPY.Python.CreateRuntime().UseFile("Main.py");
        }
    }
}
