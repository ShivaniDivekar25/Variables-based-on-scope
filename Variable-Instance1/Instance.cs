using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Instance1
{
    internal class Instance
    {
        public int engMarks;
        public int mathsMarks;
        public int phyMarks;

        public void MarksDetails()
        {
            Console.WriteLine("English:{0} Maths:{1} Physics:{2}", engMarks, mathsMarks, phyMarks);
        }
    }
}
