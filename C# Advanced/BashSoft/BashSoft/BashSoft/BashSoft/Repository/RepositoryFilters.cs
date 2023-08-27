using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft
{
    public static class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentToTake)
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
                FilterAndTake(wantedData, x => x >= 5, studentToTake);
            }
            else if (wantedFilter == "average")
            {
                FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentToTake);
            }
            else if (wantedFilter == "poor")
            {
                FilterAndTake(wantedData, x => x < 3.5, studentToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentsFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentToTake)
        {
            int counterForPrinted = 0;

            foreach (var studentPoints in wantedData)
            {
                if (counterForPrinted == studentToTake)
                {
                    break;
                }

                //double averageMark = Average(studentPoints.Value);

                double averageScore = studentPoints.Value.Average();
                double percentageOfFullfilment = averageScore / 100.0;
                double averageMark = percentageOfFullfilment * 4 + 2;

                if (givenFilter(averageMark))
                {
                    OutputWriter.PrintStudent(studentPoints);
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
