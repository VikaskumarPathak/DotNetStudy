using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationStudy
{
    internal class Student
    {
        public string StudentName;
        public int Marks {
            get
            {
                return _Marks * 10;
            }
            set { _Marks = value; } 
        
        }

        private int _Marks;

    }
}
