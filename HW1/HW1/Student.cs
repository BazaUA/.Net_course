using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class Student
    {
        public string Name { get; private set; }
        public int MathScore { get; private set; }
        public int JavaScore { get; private set; }
        public int DotNetScore { get; private set; }

        public Student(string Name, int MathScore, int JavaScore, int DotNetScore)
        {
            this.Name = Name;
            this.MathScore = MathScore;
            this.JavaScore = JavaScore;
            this.DotNetScore = DotNetScore;
        }

        public double getAvg()
        {
            return ((MathScore+JavaScore+DotNetScore)/3.0);
        }

        public override string ToString()
        {
            return "Name: "+Name+"\n math score :"+MathScore+ "\n java score :" + JavaScore+ "\n .NET score :" + DotNetScore+ "\n average score: "+getAvg();
        }


    }
}
