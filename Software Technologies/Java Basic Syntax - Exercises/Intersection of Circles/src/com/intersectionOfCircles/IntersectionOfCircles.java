package com.intersectionOfCircles;

import java.util.Arrays;
import java.util.Scanner;

public class IntersectionOfCircles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double[] circle1Details = Arrays.stream(scanner.nextLine().split(" ")).mapToDouble(Double::parseDouble).toArray();
        double[] circle2Details = Arrays.stream(scanner.nextLine().split(" ")).mapToDouble(Double::parseDouble).toArray();

        Circle circle1 = new Circle(circle1Details[0], circle1Details[1], circle1Details[2]);
        Circle circle2 = new Circle(circle2Details[0], circle2Details[1], circle2Details[2]);

        System.out.println(Intersect(circle1, circle2) ? "Yes" : "No");
    }

    public static boolean Intersect(Circle circle1, Circle circle2) {
        double shortLeg = Math.abs(circle1.center.x - circle2.center.x);
        double longLeg = Math.abs(circle1.center.y - circle2.center.y);
        double d = Math.sqrt(Math.pow(shortLeg, 2) + Math.pow(longLeg, 2));

        if (d <= circle1.radius + circle2.radius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Circle
{
    Circle(double x, double y, double r)
    {
        this.center = new Point(x, y);
        this.radius = r;
    }

    public Point center;
    public double radius;
}

class Point
{
    Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double x;
    public double y;
}
