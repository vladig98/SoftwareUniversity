package com.sumTwoNumbers;

import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double num1 = Double.parseDouble(scan.nextLine());
        double num2 = Double.parseDouble(scan.nextLine());

        System.out.printf("Sum = %.2f", num1 + num2);
    }
}
