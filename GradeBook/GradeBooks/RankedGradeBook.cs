using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Too few students!");

            int studentPlace = 1;
            foreach (var student in Students)
            {
                if (student.AverageGrade > averageGrade)
                    studentPlace++;
            }

            if (studentPlace / Students.Count >= 0.2)
                return 'A';
            else if (studentPlace / Students.Count <= 0.2 && studentPlace / Students.Count > 0.4)
                return 'B';
            else if (studentPlace / Students.Count <= 0.4 && studentPlace / Students.Count > 0.6)
                return 'C';
            else if (studentPlace / Students.Count <= 0.6 && studentPlace / Students.Count > 0.8)
                return 'D';
            else
                return 'F';
        }
    }
}
