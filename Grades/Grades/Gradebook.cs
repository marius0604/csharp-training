﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Gradebook
    {

        public Gradebook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();
            
            float sum = 0;
            foreach(float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;

    }
}
