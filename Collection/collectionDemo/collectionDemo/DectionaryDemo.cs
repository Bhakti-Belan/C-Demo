using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionDemo
{
    internal class DectionaryDemo
    {
        public static void DictOpr()
        {
            Dictionary<int,string> student = new Dictionary<int,string>();
            student.Add(1, "John");
            student.Add(2, "Jane");
            foreach(var kvp in student)
            {
                Console.WriteLine($"ID: {kvp.Key},Name:{kvp.Value}");
            }


        }
    }
}
