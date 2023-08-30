using BashSoft.Exceptions;
using BashSoft.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BashSoft
{
    public class StudentsRepository
    {
        private bool isDataInitialized = false;
        private RepositoryFilter filter;
        private RepositorySorter sorter;
        private Dictionary<string, Course> courses;
        private Dictionary<string, Student> students;

        public void LoadData(string fileName)
        {
            if (isDataInitialized)
            {
                throw new InvalidOperationException(ExceptionMessages.DataAlreadyInitializedException);
            }

            OutputWriter.WriteMessageOnNewLine("Reading data...");
            students = new Dictionary<string, Student>();
            courses = new Dictionary<string, Course>();
            ReadData(fileName);
        }

        public void UnloadData()
        {
            if (!isDataInitialized)
            {
                throw new InvalidOperationException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            students = null;
            courses = null;
            isDataInitialized = false;
        }

        public void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = courses[courseName].StudentsByName.ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);

                filter.FilterAndTake(marks, givenFilter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentToTake == null)
                {
                    studentToTake = courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = courses[courseName].StudentsByName.ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);

                sorter.OrderAndTake(marks, comparison, studentToTake.Value);
            }
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;

            if (File.Exists(path))
            {
                string pattern = @"([A-Z][a-zA-Z#\+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)";
                Regex rgx = new Regex(pattern);
                string[] allInputLines = File.ReadAllLines(path);

                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]) && rgx.IsMatch(allInputLines[line]))
                    {
                        Match currentMatch = rgx.Match(allInputLines[line]);
                        string courseName = currentMatch.Groups[1].Value;
                        string username = currentMatch.Groups[2].Value;
                        //int studentsScoreOnTasks;
                        //bool hasParsedScore = int.TryParse(currentMatch.Groups[3].Value, out studentsScoreOnTasks);

                        //if (hasParsedScore && studentsScoreOnTasks >= 0 && studentsScoreOnTasks <= 100)
                        //{
                        //    if (!studentsByCourse.ContainsKey(course))
                        //    {
                        //        studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                        //    }

                        //    if (!studentsByCourse[course].ContainsKey(student))
                        //    {
                        //        studentsByCourse[course].Add(student, new List<int>());
                        //    }

                        //    studentsByCourse[course][student].Add(studentsScoreOnTasks);
                        //}

                        string scoreStr = currentMatch.Groups[3].Value;

                        try
                        {
                            int[] scores = scoreStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                            if (scores.Any(x => x > 100 || x < 0))
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidScore);
                            }

                            if (scores.Length > Course.NumberOfTasksOnExam)
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                                continue;
                            }

                            if (!students.ContainsKey(username))
                            {
                                students.Add(username, new Student(username));
                            }

                            if (!courses.ContainsKey(courseName))
                            {
                                courses.Add(courseName, new Course(courseName));
                            }

                            Course course = courses[courseName];
                            Student student = students[username];

                            student.EnrollInCourse(course);
                            student.SetMarkOnCourse(courseName, scores);

                            course.EnrollStudent(student);
                        }
                        catch (FormatException fex)
                        {
                            OutputWriter.DisplayException(fex.Message + $"at line : {line}");
                        }
                    }
                }
            }
            else
            {
                //throw new DirectoryNotFoundException(ExceptionMessages.InvalidPath);
                throw new InvalidPathException();
            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (courses.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private bool IsQueryForStudentPossiblе(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && courses[courseName].StudentsByName.ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public void GetStudentsScoresFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossiblе(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, double>(username, courses[courseName].StudentsByName[username].MarksByCourseName[courseName]));
            }
        }

        public void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}");
                foreach (var studentMarksEntry in courses[courseName].StudentsByName)
                {
                    //OutputWriter.PrintStudent(studentMarksEntry);
                    GetStudentsScoresFromCourse(courseName, studentMarksEntry.Key);
                }
            }
        }

        public StudentsRepository(RepositoryFilter filter, RepositorySorter sorter)
        {
            this.filter = filter;
            this.sorter = sorter;
        }
    }
}
