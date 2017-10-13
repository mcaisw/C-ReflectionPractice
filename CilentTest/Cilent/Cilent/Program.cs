using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//using myFirsClassLibrary;//不用using引用也可以使用myFirsClassLibrary里的类和方法，利用反射

namespace Cilent
{
    class Program
    {
        static void Main(string[] args)
        {
            /*获取动态链接库里所有的类*/
            Assembly t = Assembly.Load("myFirsClassLibrary");
            //Assembly t = Assembly.LoadFrom("myFirsClassLibrary");
            foreach (Type item in t.GetTypes())//获取动态链接库里的所有类
            {
                Console.WriteLine(item.Name);
            }

            /*获取动态链接库里所有的module
             这里的module只有myFirsClassLibrary.dll*/
            Module[] modules = t.GetModules();
            foreach (Module item in modules)
            {
                Console.WriteLine("module name:"+ item.Name);
            }

            /*得到myFirsClassLibrary.dll里封装的类*/
            Type a = typeof(myFirsClassLibrary.HelloWorld);//得到myFirsClassLibrary.dll里封装的类
            //Type b = t.GetType("myFirsClassLibrary.HelloWorld");
            Console.WriteLine(a.Name);

            /*使用myFirsClassLibrary.dll封装的类来创建实例*/
            string temp = "helloWorld";
            object obj = Activator.CreateInstance(a, temp);
            //object obj = t.CreateInstance("myFirsClassLibrary.HelloWorld");

            /*显示myFirsClassLibrary.dll所有共有的方法*/
            MethodInfo[] myFunc = a.GetMethods();
            foreach (MethodInfo item in myFunc)
            {
                Console.WriteLine(item.Name);
            }
            

        }
    }
}
