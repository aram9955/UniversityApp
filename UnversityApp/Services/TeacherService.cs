using System;
using UniversityApp.Models;

namespace UniversityApp.Services
{
    public class TeacherService
    {
        public  TeacherModel[] Create(int count)
        {
            Random rnd = new Random();
            TeacherModel[] teachers = new TeacherModel[count];
            for (int i = 0; i < count; i++)
            {
                teachers[i] = new TeacherModel($"name-{i}",(ushort)rnd.Next(22, 70), $"subject-{i}");
            }
            return teachers;
        }
        public void Show(TeacherModel[] teachers)
        {
            Console.WriteLine("#########teachers#############");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine($"teacher: id = {teachers[i]._id} \t name = {teachers[i]._name} \t age = {teachers[i]._age}\t subject = {teachers[i]._subject}");
                Console.WriteLine("-----------------------");
            }
        }
        public void Show(TeacherModel teacher)
        {
            Console.WriteLine($"id = {teacher._id}\n  name = {teacher._name} \n age = {teacher._age}");

        }
        public TeacherModel GetTeacher(Guid id, TeacherModel[] teachers)
        {
            TeacherModel teacher = null;
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i]._id == id)
                    teacher = teachers[i];
            }
            return teacher;
        }
    }
}
