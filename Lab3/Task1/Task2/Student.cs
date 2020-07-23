using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
	class Student
	{
        public string Name { get; set; }
        public uint Course { get; set; }
        public bool HasGrants { get; set; }

        public Student(string name, uint course, bool hasGrants)
        {
            this.Name = name;
            this.Course = course;
            this.HasGrants = hasGrants;
        }

        public Student(string name, uint course)
        {
            this.Name = name;
            this.Course = course;
            this.HasGrants = false;
        }
    }
}
