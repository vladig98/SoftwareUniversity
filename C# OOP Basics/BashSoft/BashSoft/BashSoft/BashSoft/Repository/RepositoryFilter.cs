using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft
{
    public class RepositoryFilter
    {
        //public void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentToTake)
        public void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentToTake)
        {
            //if (wantedFilter == "excellent")
            //{
            //    FilterAndTake(wantedData, ExcellentFilter, studentToTake);
            //}
            //else if (wantedFilter == "average")
            //{
            //    FilterAndTake(wantedData, AverageFilter, studentToTake);
            //}
            //else if (wantedFilter == "poor")
            //{
            //    FilterAndTake(wantedData, PoorFilter, studentToTake);
            //}
            if (wantedFilter == "excellent")
            {
                //FilterAndTake(wantedData, x => x >= 5, studentToTake);
                FilterAndTake(studentsWithMarks, x => x >= 5, studentToTake);
            }
            else if (wantedFilter == "average")
            {
                //FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentToTake);
                FilterAndTake(studentsWithMarks, x => x < 5 && x >= 3.5, studentToTake);
            }
            else if (wantedFilter == "poor")
            {
                //FilterAndTake(wantedData, x => x < 3.5, studentToTake);
                FilterAndTake(studentsWithMarks, x => x < 3.5, studentToTake);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidStudentsFilter);
            }
        }

        //private void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentToTake)
        private void FilterAndTake(Dictionary<string, double> studentsWithMarks, Predicate<double> givenFilter, int studentToTake)
        {
            int counterForPrinted = 0;

            foreach (var studentMark in studentsWithMarks)
            {
                if (counterForPrinted == studentToTake)
                {
                    break;
                }

                //double averageMark = Average(studentPoints.Value);

                //double averageScore = studentPoints.Value.Average();
                //double percentageOfFullfilment = averageScore / 100.0;
                //double averageMark = percentageOfFullfilment * 4 + 2;

                if (givenFilter(studentMark.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(studentMark.Key, studentMark.Value));
                    counterForPrinted++;
                }
            }
        }

        //private static bool ExcellentFilter(double mark)
        //{
        //    return mark >= 5.0;
        //}

        //private static bool AverageFilter(double mark)
        //{
        //    return mark < 5.00 && mark >= 3.5;
        //}

        //private static bool PoorFilter(double mark)
        //{
        //    return mark < 3.5;
        //}

        //private static double Average(List<int> scoresOnTasks)
        //{
        //    int totalScore = 0;
        //    foreach (var score in scoresOnTasks)
        //    {
        //        totalScore += score;
        //    }

        //    var percentageOfAll = totalScore / (scoresOnTasks.Count * 100);
        //    var mark = percentageOfAll * 4 + 2;

        //    return mark;
        //}
    }
}
