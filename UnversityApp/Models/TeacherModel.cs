using System;

namespace UniversityApp.Models
{
    public class TeacherModel
    {
        public TeacherModel(string name, ushort age, string subject)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _subject = subject;
        }
        public Guid _id;
        public string _name;
        public ushort _age;
        public string _subject;
    }
}
