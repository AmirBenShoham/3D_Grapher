using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapher
{
    class Info
    {
        private int grade;
        private string name;
        public Info()
        {
        }
        public Info(int grade, string name)
        {
            this.grade = grade;
            this.name = name;
        }
        public void SetGrade(int grade)
        {
            this.grade = grade;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetGrade()
        {
            return this.grade;
        }
        public string GetName()
        {
            return this.name;
        }
        public override string ToString()
        {
            return grade.ToString() + " , " + name;
        }
    }
}
