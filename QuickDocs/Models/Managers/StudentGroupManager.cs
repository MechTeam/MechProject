using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;
using QuickDocs.Models.Domain.Providers;

namespace QuickDocs.Models.Managers
{
    public class StudentGroupManager
    {
        public void Transfer(StudentGroup LastGroup, StudentGroup NewGroup, Student student)
        {
            StudentGroupProvider studentGroupProvider = new StudentGroupProvider();
            StudentProvider studentProvider = new StudentProvider();

            for (int i = 0; i < LastGroup.Students.Count; i++)
            {
                if (LastGroup.Students[i] == student)
                {
                    studentGroupProvider.GetByID(LastGroup.ID).Students.RemoveAt(i);
                    studentGroupProvider.GetByID(NewGroup.ID).Students.Add(student);
                    student.StudentGroup = NewGroup;

                    studentGroupProvider.Update(LastGroup);
                    studentGroupProvider.Update(NewGroup);
                    studentProvider.Update(student);
                }
            }
        }

        public void DeleteFromGroup(Student student)
        {
            StudentGroupProvider studentGroupProvider = new StudentGroupProvider();
            StudentProvider studentProvider = new StudentProvider();

            for (int i = 0; i < studentGroupProvider.GetByID(student.StudentGroup.ID).Students.Count; i++)
            {
                if (studentGroupProvider.GetByID(student.StudentGroup.ID).Students[i] == student)
                {
                    studentGroupProvider.GetByID(student.StudentGroup.ID).Students.RemoveAt(i);
                    student.StudentGroup = null;

                    studentGroupProvider.Update(studentGroupProvider.GetByID(student.StudentGroup.ID));
                    studentProvider.Update(student);
                }
            }
        }

        public void AddToGroup(Student student, StudentGroup studentGroup)
        {
            StudentGroupProvider studentGroupProvider = new StudentGroupProvider();
            StudentProvider studentProvider = new StudentProvider();

            student.StudentGroup = studentGroup;
            studentGroup.Students.Add(student);

            studentGroupProvider.Update(studentGroup);
            studentProvider.Update(student);
        }

        public void NameAutochanger(StudentGroup studentgroup)
        {
            DateTime time = new DateTime();
            StudentGroupProvider studentGroupProvider = new StudentGroupProvider();

            if (time.Day == 31 && (time.Month == 8 || time.Month == 1))
            {
                int number = Convert.ToInt32(studentgroup.Name[studentgroup.Name.Length - 2]);
                int newNumber = number + 1;

                studentgroup.Name.Insert(studentgroup.Name.Length - 2, Convert.ToString(newNumber));

                studentGroupProvider.Update(studentgroup);
            }
        }
    }
}