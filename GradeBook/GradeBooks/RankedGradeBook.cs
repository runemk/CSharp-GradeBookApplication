using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override void CalculateStatistics()
        {
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            base.CalculateStudentStatistics(name);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override double GetGPA(char letterGrade, StudentType studentType)
        {
            return base.GetGPA(letterGrade, studentType);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
             throw new InvalidOperationException();

            if (averageGrade >= 80)
            {
                return 'A';
            }
            else if(averageGrade >= 60 )
            {
                return 'B';
            }
            else if(averageGrade >= 40)
            {
                return 'C';
            }
            else if (averageGrade >= 20)
            {
                return 'D';
            }

            return 'F';
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
