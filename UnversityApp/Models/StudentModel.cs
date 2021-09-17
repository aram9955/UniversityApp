using System;

namespace UniversityApp.Models
{
    public class StudentModel
    {
        public StudentModel(string name, int age, TeacherModel teacher)
        {
            _name = name;
            _age = age;
            _teacher = teacher;
            _id = Guid.NewGuid();
        }
        public Guid _id;
        public int _age;
        public string _name;
        public TeacherModel _teacher;
    }
}
