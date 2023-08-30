package com.threeIntegersSum;

import java.util.Arrays;
import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number1 = scan.nextInt();
        int number2 = scan.nextInt();
        int number3 = scan.nextInt();

        if (number1 + number2 == number3)
        {
            if (number1 <= number2)
            {
                System.out.println(number1 + " + " + number2 + " = " + number3);
            }
            else
            {
                System.out.println(number2 + " + " + number1 + " = " + number3);
            }
        }
        else if (number1 + number3 == number2)
        {
            if (number1 <= number3)
            {
                System.out.println(number1 + " + " + number3 + " = " + number2);
            }
            else
            {
                System.out.println(number3 + " + " + number1 + " = " + number2);
            }
        }
        else if (number2 + number3 == number1)
        {
            if (number2 <= number3)
            {
                System.out.println(number2 + " + " + number3 + " = " + number1);
            }
            else
            {
                System.out.println(number3 + " + " + number2 + " = " + number1);
            }
        }
        else
        {
            System.out.println("No");
        }
    }
}
