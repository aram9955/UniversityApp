using System;
using UniversityApp.Models;
using UniversityApp.Services;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherService teacherService = new TeacherService();
            TeacherModel[] teachers = teacherService.Create(5);
            teacherService.Show(teachers);
            StudentService studentService = new StudentService();
            StudentModel[] students = studentService.Create(5);
            studentService.Show(students);
            studentService.Swap(students, teachers);
            studentService.Show(students);
        }
    }
}
