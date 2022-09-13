using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _12sep
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @" C:\Users\LENOVO\source\repos\12sep\ClassLibrary1\bin\Debug\ClassLibrary1.dll";
            Assembly asm = Assembly.LoadFrom(path);

            Type[] types = asm.GetTypes();
            Type t = null;

            foreach (var item in types)
            {
                //Console.WriteLine("name= " + item.Name);//classname
                //Console.WriteLine("Full Name= " + item.FullName);//assemblyname/namespacename and class

                //Console.WriteLine("IS Class=" + item.IsClass);
                //Console.WriteLine("IS Absatract=" + item.IsAbstract);
                //Console.WriteLine("Whether public " + item.IsPublic);


                //Console.WriteLine("-----------------");
                //MemberInfo[] minfo = item.GetMembers();

                //foreach (var minfoitem in minfo)
                //{

                //    Console.WriteLine("Member Info Name= " + minfoitem.Name);

                //    Console.WriteLine("Declaring type=" + minfoitem.DeclaringType);
                //}
                //Console.WriteLine("---------------------");
                //MethodInfo[] methodInfos = item.GetMethods();
                //foreach (var methodInfosItem in methodInfos)
                //{

                //    Console.WriteLine("name=" + methodInfosItem.Name);
                //    Console.WriteLine("IS PUBLIC=" + methodInfosItem.IsPublic);
                //    Console.WriteLine("IS STATIC =" + methodInfosItem.IsStatic);

                //    ParameterInfo[] pinfo = methodInfosItem.GetParameters();
                //    Console.WriteLine("---Add method Parameters----");


                //    foreach (var par in pinfo)
                //    {
                //        Console.WriteLine(par.Name);
                //        Console.WriteLine(par.Position);
                //        Console.WriteLine(par.ParameterType);


                //    }

                //}

                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);


                item.InvokeMember("SqrRt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 16 });

                item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 3 });

                break;












            }
            Console.ReadLine();



        }
    }
}