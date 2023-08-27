using BashSoft.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft
{
    public class RepositorySorter : IDataSorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsMarks, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();

            if (comparison == "ascending")
            {
                PrintStudents(studentsMarks.OrderBy(x => x.Value).Take(studentsToTake).ToDictionary(x => x.Key, x => x.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudents(studentsMarks.OrderByDescending(x => x.Value).Take(studentsToTake).ToDictionary(x => x.Key, x => x.Value));
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private void PrintStudents(Dictionary<string, double> studentsSorted)
        {
            foreach (var student in studentsSorted)
            {
                OutputWriter.PrintStudent(student);
            }
        }

        //private static void OrderAndTake(Dictionary<string, List<int>> wantedData, int studentsToTake, Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        //{
        //    Dictionary<string, List<int>> studentsSorted = GetSortedStudents(wantedData, studentsToTake, comparisonFunc);

        //    foreach (var student in studentsSorted)
        //    {
        //        OutputWriter.PrintStudent(student);
        //    }
        //}

        //private static Dictionary<string, List<int>> GetSortedStudents(Dictionary<string, List<int>> wantedData, int studentsToTake, Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        //{
        //    int studentsTaken = 0;
        //    Dictionary<string, List<int>> studentsSorted = new Dictionary<string, List<int>>();
        //    KeyValuePair<string, List<int>> nextInOrder = new KeyValuePair<string, List<int>>();

        //    bool isSorted = false;

        //    while (studentsTaken < studentsToTake)
        //    {
        //        isSorted = true;

        //        foreach (var students_score in wantedData)
        //        {
        //            if (!string.IsNullOrEmpty(nextInOrder.Key))
        //            {
        //                int comparisonResult = comparisonFunc(students_score, nextInOrder);

        //                if (comparisonResult >= 0 && !studentsSorted.ContainsKey(students_score.Key))
        //                {
        //                    nextInOrder = students_score;
        //                    isSorted = false;
        //                }
        //            }
        //            else
        //            {
        //                if (!studentsSorted.ContainsKey(students_score.Key))
        //                {
        //                    nextInOrder = students_score;
        //                    isSorted = false;
        //                }
        //            }
        //        }

        //        if (!isSorted)
        //        {
        //            studentsSorted.Add(nextInOrder.Key, nextInOrder.Value);
        //            studentsTaken++;
        //            nextInOrder = new KeyValuePair<string, List<int>>();
        //        }
        //    }

        //    return studentsSorted;
        //}

        //private static int CompareInOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        //{
        //    int totalScoreOfFirst = 0;

        //    foreach (var mark in firstValue.Value)
        //    {
        //        totalScoreOfFirst += mark;
        //    }

        //    int totalSoreOfSecond = 0;

        //    foreach (var mark in secondValue.Value)
        //    {
        //        totalSoreOfSecond += mark;
        //    }

        //    return totalSoreOfSecond.CompareTo(totalScoreOfFirst);
        //}

        //private static int CompareDescendingOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        //{
        //    int totalScoreOfFirst = 0;

        //    foreach (var mark in firstValue.Value)
        //    {
        //        totalScoreOfFirst += mark;
        //    }

        //    int totalSoreOfSecond = 0;

        //    foreach (var mark in secondValue.Value)
        //    {
        //        totalSoreOfSecond += mark;
        //    }

        //    return totalScoreOfFirst.CompareTo(totalSoreOfSecond);
        //}
    }
}
