using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //className objectName = new className()
            Student objstu = new Student();
            objstu.id = 1;
            objstu.Name = "shubham";
            Console.WriteLine(objstu.id + "" + objstu.Name);
        }
    }
}
