﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class StudentPoit : Student, IStudent
    {
        public StudentPoit() { }
        public StudentPoit(string name, string sex, DateTime birthday, List<Exam> examSchedule)
            : base(name, sex, birthday, examSchedule) { }
        public bool LessonsAreCorrect()
        {
            for (int i = 0; i < ExamSchedule.Count; i++)
            {
                if (ExamSchedule[i].title != Lessons.Математика && ExamSchedule[i].title != Lessons.ДМ &&
                    ExamSchedule[i].title != Lessons.ИнЯз && ExamSchedule[i].title != Lessons.ОАиП &&
                    ExamSchedule[i].title != Lessons.Физика)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
