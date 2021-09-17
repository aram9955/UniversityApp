using System;
using UniversityApp.Models;

namespace UniversityApp.Services
{
    public class StudentService
    {
        public StudentModel[] Create(int count)
        {
            StudentModel[] students = new StudentModel[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students[i] = new StudentModel($"name-{i}", rnd.Next(16, 30), null);
            }
            return students;
        }
        public void Show(StudentModel[] students)
        {
            Console.WriteLine("#########students#############");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < students.Length; i++)
            {
                string studentinfo = $"student: id = {students[i]._id} \t name = {students[i]._name} \t age = {students[i]._age}";
                if (students[i]._teacher == null)
                {
                    Console.WriteLine(studentinfo);
                }
                else
                {
                    string teacherinfo = $"\nteacher: id = {students[i]._teacher._id} \t name = {students[i]._teacher._name} \t age = {students[i]._teacher._age}\t subject = {students[i]._teacher._subject}";
                    Console.WriteLine(studentinfo + teacherinfo);
                }

                Console.WriteLine("-----------------------");
            }
        }
        public StudentModel GetStudent(Guid id, StudentModel[] students)
        {
            StudentModel student = null;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._id == id)
                    student = students[i];
            }
            return student;
        }
        public void  Swap(StudentModel[] students, TeacherModel[] teachers)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i]._teacher = teachers[i];
            }
        }
    }
}
