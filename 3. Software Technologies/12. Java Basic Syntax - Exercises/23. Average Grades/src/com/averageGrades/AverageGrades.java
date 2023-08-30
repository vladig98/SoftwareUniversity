package com.averageGrades;

import java.util.*;
import java.util.stream.Collectors;

public class AverageGrades {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int until = Integer.parseInt(scanner.nextLine());

        Comparator<Student> byName = new Comparator<Student>() {
            @Override
            public int compare(Student o1, Student o2) {
                return o1.Name.compareTo(o2.Name);
            }
        };

        Comparator<Student> byGrade = new Comparator<Student>() {
            @Override
            public int compare(Student o1, Student o2) {
                return o1.AverageGrade.compareTo(o2.AverageGrade);
            }
        };

        ArrayList<Student> students = new ArrayList<Student>();

        for (int i = 0; i < until; i++)
        {
            String[] inputTokens = scanner.nextLine().split(" ");
            String Name = inputTokens[0];
            List<Double> Grades = Arrays.stream(inputTokens).skip(1).mapToDouble(Double::parseDouble).boxed().collect(Collectors.toList());

            Student student = new Student(Name, Grades);
            students.add(student);
        }

        students.removeIf(s -> s.AverageGrade < 5.00);

        Collections.sort(students, byName.thenComparing(byGrade.reversed()));

        students.forEach((n) -> System.out.println(n.Name + " -> " + String.format("%.2f", n.AverageGrade)));
    }
}

class Student
{
    Student(String name, List<Double> Grades)
    {
        this.Name = name;
        this.Grades = Grades;
        OptionalDouble averageGrade = Grades.stream().mapToDouble(a -> a).average();
        this.AverageGrade = averageGrade.getAsDouble();
    }

    public String Name;
    public List<Double> Grades;
    public final Double AverageGrade;
}

