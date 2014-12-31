using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IronPythonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic pys = Python.CreateRuntime().UseFile("CodeFile1.py");
            Console.WriteLine(pys.hello());
        }
    }
}
