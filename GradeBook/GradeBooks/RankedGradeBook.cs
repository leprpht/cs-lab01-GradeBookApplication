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

            var sortedStudents = Students.OrderByDescending(s => s.AverageGrade).ToList();
            int studentPlace = sortedStudents.FindIndex(s => s.AverageGrade == averageGrade) + 1;
            double rankPercentage = (double)studentPlace / Students.Count;

            if (rankPercentage <= 0.2)
                return 'A';
            else if (rankPercentage <= 0.4)
                return 'B';
            else if (rankPercentage <= 0.6)
                return 'C';
            else if (rankPercentage <= 0.8)
                return 'D';
            else
                return 'F';
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            else
                base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            else
                base.CalculateStudentStatistics(name);
        }

    }
}
