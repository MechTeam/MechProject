using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Models.Domain.Providers
{
    public class StudentInLessonProvider:BaseProvider<StudentInLesson>
    {
        public new void Add(StudentInLesson studentInLesson)
        {
            StudentProvider studentProvider = new StudentProvider();
            LessonProvider lessonProvider = new LessonProvider();

            if (studentInLesson.Lesson == null)
                throw new Exception(string.Format("Поле предмет не заполнено!"));

            if (studentInLesson.Student == null)
                throw new Exception(string.Format("Поле студент не заполнено!"));

            if (studentProvider.GetByID(studentInLesson.Student.ID) == null)
                throw new Exception(string.Format("Студента {0} {1} с ID:{2} нет в БД!", studentInLesson.Student.User.FirstName, 
                    studentInLesson.Student.User.SecondName, studentInLesson.Student.ID));

            if (lessonProvider.GetByID(studentInLesson.Lesson.ID) == null)
                throw new Exception(string.Format("Предмета {0} с ID:{1} нет в БД!", 
                    studentInLesson.Lesson.LessonType, studentInLesson.Lesson.ID));

            base.Add(studentInLesson);
        }
    }
}