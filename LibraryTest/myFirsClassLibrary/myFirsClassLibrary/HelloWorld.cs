using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirsClassLibrary
{
    public interface PrintInfo {
        void PrintSomeInfo();
    }
    public class HelloWorld : PrintInfo
    {

        public HelloWorld(string someInfo) {
            info = someInfo;
        }

        string info;

        public void PrintSomeInfo()
        {
            Console.WriteLine("info");
        }
    }
}
